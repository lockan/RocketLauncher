using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ScriptLauncher;

namespace ScriptLauncher
{
    public partial class SLauncher : Form
    {
		private static SLConfig cfg = new SLConfig();
		
		public SLauncher()
        {
            InitializeComponent();		
		}

		// ---- There's another solution here: 
		// http://stackoverflow.com/questions/1730731/how-to-start-winform-app-minimized-to-tray
		// Look this stuff up later to understand it. 
		
		private void SLauncher_Load(object sender, EventArgs e)
		{
			initContextMenu();
			this.WindowState = FormWindowState.Minimized;
			trayIcon.Visible = true;
			cfg = new SLConfig();
		}

        private void SLauncher_Resize(object sender, EventArgs e)
        {
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				//trayIcon.Visible = true;
			}
        }
		
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			this.Show();
        }

		// Context menu item event handler. 
		// Name of the sender object is the command to execute.  
		private void cMenu_Click(object sender, EventArgs e)
		{
			//Verify that we clicked a ToolStripMenuItem
			if (sender.GetType() == typeof(System.Windows.Forms.ToolStripMenuItem))
			{
				//Cast object sender back to ToolStripMenuItem object so we can reference the name property. 
				ToolStripMenuItem clickedItem = (ToolStripMenuItem) sender;	
				System.Diagnostics.Debug.WriteLine(clickedItem.Name);
				//Create a new process
				System.Diagnostics.Process command = new System.Diagnostics.Process();
				System.Diagnostics.ProcessStartInfo commandInfo = new System.Diagnostics.ProcessStartInfo();
				commandInfo.FileName = clickedItem.Name;
				command.StartInfo = commandInfo;
				command.Start();
			}
		}
		
		//Context menu default application exit item
		private void exitItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void initContextMenu()
		{
			//NEED AN INTERFACE TO STORE THESE ITEMS IN A LIST AND POPULATE THE MENU
			//ALSO NEED A GUI FOR ADDING/REMOVE ITEMS
			contextMenuStrip.Items.Clear();

			for (int c = 0; c < cfg.Categories.Count; c++)
			{
				string currentCat = (string)cfg.Categories[c];
				ToolStripLabel catLabel = new ToolStripLabel(currentCat);
				contextMenuStrip.Items.Add(catLabel);

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
						contextMenuStrip.Items.Add(newItem);
					}
				}
			}

			//Always add Exit Button to bottom of menu
			contextMenuStrip.Items.Add(new ToolStripSeparator());
			ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit", null, null, "Exit");
			exitItem.Click += exitItem_Click;
			contextMenuStrip.Items.Add(exitItem);
		}
	}
}
