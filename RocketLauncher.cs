using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using RocketLauncher;

namespace RocketLauncher
{
    public partial class RLauncher : Form
    {
		//New private instance of config. Constructor runs ParseConfig.
		private static RLConfig cfg = new RLConfig();

        //Form visibility control flags. 
        private bool showForm;
        private bool closeForm;
		
		public RLauncher()
        {
            InitializeComponent();
            initContextMenu();
            SetVisibleCore(false);
		}

        private void RocketLauncher_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            trayIcon.Visible = true;
            dataGridCommands.AutoGenerateColumns = false;
            listBoxCategories.DataSource = cfg.Categories;
        }

        // ---- Credit for this solution goes to Hans Passant on Stack Overflow. 
        // http://stackoverflow.com/questions/1730731/how-to-start-winform-app-minimized-to-tray
        protected override void SetVisibleCore(bool value)
        {
            if (!showForm)
            {
                value = false;
            }
            base.SetVisibleCore(value);
        }
        // Intercept closing event, hide form instead. 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!closeForm)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showForm = true;
            this.Show();
        }

		// Context menu item event handler. 
		// Name of the sender object is the command to execute.  
		private void cMenu_Click(object sender, EventArgs e)
		{
			//TODO: Need to try/catch for exceptions here, in case launching process fails. 
			//Verify that we clicked a ToolStripMenuItem
			if (sender.GetType() == typeof(System.Windows.Forms.ToolStripMenuItem))
			{
				RunCommand(sender);
			}
		}
		
		//Context menu default application exit item
		private void exitItem_Click(object sender, EventArgs e)
		{
            closeForm = true;
            Application.Exit();
		}

		// Creates a ToolStripMenuItem for each item in category array. 
		// Adds dropdown items for each item in the cmd array to the toolstrip with the matching category name.  
		private void initContextMenu()
		{
            RLConfig.Dbg("IN context init");
            contextMenuStrip.Items.Clear();

			for (int c = 0; c < cfg.Categories.Count; c++)
			{
				// Retrieve category, create ToolStripMenu. 
				string currentCat = (string)cfg.Categories[c];
				ToolStripMenuItem catLabel = new ToolStripMenuItem(currentCat);
				contextMenuStrip.Items.Add(catLabel);

				//Create dropdown items for all commands and place them 
				// into the matching category dropdownitems list. 
				for (int cmd = 0; cmd < cfg.CMDList.Count; cmd++)
				{
					CmdItem current = (CmdItem)cfg.CMDList[cmd];
					string nameString = current.Name;
					string cmdString = current.Value;
					string catString = current.Category;

					if (catString == currentCat)
					{
						ToolStripMenuItem newItem = new ToolStripMenuItem(
							nameString,
							null,
							null,
							cmdString
						);
						newItem.Click += cMenu_Click;
						catLabel.DropDownItems.Add(newItem);
					}
				}
                RLConfig.Dbg("Done context init");
			}

			//Always add Exit Button to bottom of menu
			contextMenuStrip.Items.Add(new ToolStripSeparator());
			ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit", null, null, "Exit");
			exitItem.Click += exitItem_Click;
			contextMenuStrip.Items.Add(exitItem);
		}

		private void buttonHide_Click(object sender, EventArgs e)
		{
            this.Hide();
		}

		private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxCategories.SelectedItem != null)
			{
				string filterString = listBoxCategories.SelectedItem.ToString();
				dataGridCommands.DataSource = FilterCommands(filterString);
			}
		}

        private ArrayList FilterCommands(string catFilter)
        {
            ArrayList filteredList = new ArrayList();
            foreach (CmdItem cItem in cfg.CMDList) 
            {
                if (cItem.Category == catFilter) 
                {
                    filteredList.Add(cItem);
                }
            }
            return filteredList;
        }

		private void RunCommand(Object clicked)
		{
			//Cast object sender back to ToolStripMenuItem object so we can reference the name property. 
			ToolStripMenuItem clickedItem = (ToolStripMenuItem)clicked;
			System.Diagnostics.Debug.WriteLine(clickedItem.Name);
			//Create a new process and launch it. 
			System.Diagnostics.Process command = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo commandInfo = new System.Diagnostics.ProcessStartInfo();
            commandInfo.FileName = clickedItem.Name;
            try 
            {
                command.StartInfo = commandInfo;
                command.Start();
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Error: Could not find command \"" + commandInfo.FileName
                    + "\" or command was not valid."
                    + " Please ensure the command and path are correct."
                    + "\n\n If you are certain the path is correct the command"
                    + " may not be supported by RocketLauncher.",
                    "Error: RocketLauncher misfired!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
		}

		private void buttonAddCat_Click(object sender, EventArgs e)
		{
			Form addDlg = new Dialog_AddCategory();
			DialogResult result = addDlg.ShowDialog();

			if (result == DialogResult.OK)
			{
				listBoxCategories.DataSource = null;
				listBoxCategories.DataSource = cfg.Categories;
				initContextMenu();
			}  
		}

		private void buttonEditCat_Click(object sender, EventArgs e)
		{
			if (listBoxCategories.SelectedItem != null)
            {
                string selectedCat = listBoxCategories.SelectedItem.ToString();
                System.Diagnostics.Debug.WriteLine(listBoxCategories.SelectedItem);
                Form editDlg = new Dialog_AddCategory(true, listBoxCategories.SelectedItem.ToString());
                DialogResult result = editDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    listBoxCategories.DataSource = null;
                    listBoxCategories.DataSource = cfg.Categories;
                    initContextMenu();
                }
            }
            else
            {
                MessageBox.Show("Edit category failed. No category selected", "Error: Edit Category", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
		}

        private void buttonAddCmd_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                string currentCat = listBoxCategories.SelectedItem.ToString();
                Form addCmdDlg = new Dialog_AddCmd(currentCat);
                DialogResult result = addCmdDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dataGridCommands.DataSource = null;
                    dataGridCommands.DataSource = FilterCommands(currentCat);
                    initContextMenu();
                }
            }
            else
            {
                MessageBox.Show("Add command failed. No category selected.", "Error: Add Command",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

		private void buttonEditCmd_Click(object sender, EventArgs e)
		{
            if (listBoxCategories.SelectedItem != null)
            {
                string currentCat = listBoxCategories.SelectedItem.ToString();

                int selectedRow = dataGridCommands.CurrentCell.RowIndex;
                string selName = dataGridCommands.Rows[selectedRow].Cells[0].Value.ToString();
                int selCmdIndex = RLConfig.FindCmdByName(selName);
                System.Diagnostics.Debug.WriteLine("SelCmd: " + selName + " SelIndex: " + selCmdIndex);

                CmdItem selectedCmd = cfg.CMDList[selCmdIndex];
                System.Diagnostics.Debug.WriteLine("Selected in Config: " + selectedCmd.ToString());

                Form addCmdDlg = new Dialog_AddCmd(true, currentCat, selectedCmd, selCmdIndex);
                DialogResult result = addCmdDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dataGridCommands.DataSource = null;
                    dataGridCommands.DataSource = FilterCommands(currentCat);
                    initContextMenu();
                } 
            }
            else
            {
                MessageBox.Show("Edit command failed. No category or command selected.", "Error: Edit Command",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
		}

		private void buttonDelCmd_Click(object sender, EventArgs e)
		{
			if (listBoxCategories.SelectedItem != null )
            {
                string currentCat = listBoxCategories.SelectedItem.ToString();

                int selectedRow = dataGridCommands.CurrentCell.RowIndex;
                string selName = dataGridCommands.Rows[selectedRow].Cells[0].Value.ToString();
                int selCmdIndex = RLConfig.FindCmdByName(selName);

                DialogResult result = ShowDeleteConfirmation(selName);

                if (result == DialogResult.Yes)
                {
                    RLConfig.DeleteCommand(selCmdIndex);
                    dataGridCommands.DataSource = null;
                    dataGridCommands.DataSource = FilterCommands(currentCat);
                    initContextMenu();
                }
            }
            else
            {
                MessageBox.Show("Delete command failed. No category or command selected", "Error: Delete Command",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
		}

		private void buttonDelCat_Click(object sender, EventArgs e)
		{
            if (listBoxCategories.SelectedItem != null) 
            {
                string currentCat = listBoxCategories.SelectedItem.ToString();

                DialogResult result = ShowDeleteConfirmation(currentCat);

                if (result == DialogResult.Yes)
                {
                    RLConfig.DeleteCategory(currentCat);
                    dataGridCommands.DataSource = null;
                    dataGridCommands.DataSource = FilterCommands(currentCat);
                    listBoxCategories.DataSource = null;
                    listBoxCategories.DataSource = cfg.Categories;
                    initContextMenu();
                }
            }
            else
            {
                MessageBox.Show("Delete category failed. No category selected", "Error: Delete Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
		}

		private DialogResult ShowDeleteConfirmation(string selectedItemString)
		{
			DialogResult result = MessageBox.Show(
				"Are you sure you wish to delete the item \"" + selectedItemString + 
				"\"? Changes cannot be undone. ",
				"Delete Confirmation",
				MessageBoxButtons.YesNo);

			return result;
		}

        private void sLConfigBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panelBanner_Paint(object sender, PaintEventArgs e)
        {

        }
	}
}
