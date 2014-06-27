using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketLauncher
{
	public partial class Dialog_AddCmd : Form
	{
        private string category;
        // Below only apply to edit mode.
        private bool editMode = false;
        private int editIndex = -1;
 		
		public Dialog_AddCmd()
		{
			InitializeComponent();
		}

		// Constructor for Add mode
        public Dialog_AddCmd(string selectedCat)
		{
			InitializeComponent();
           	category = selectedCat;
		}

        //Constructor for Edit mode
        public Dialog_AddCmd(bool editFlag, string selectedCat, CmdItem editCmd, int cmdIndex)
        {
            InitializeComponent();
            this.editMode = editFlag;
            category = selectedCat;

            if (editMode == true)
            {
                this.Text = "Edit Command";
                labelNewCmdName.Text = "Edit Name:";
                labelNewCmd.Text = "Edit Command:";
                buttonAdd.Text = "Edit";

                editIndex = cmdIndex;
                textBoxCmdName.Text = editCmd.Name;
                textBoxCmdValue.Text = editCmd.Value;
            }
        }

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (editMode)
            {
                string newCName = textBoxCmdName.Text.Trim();
                string newCValue = textBoxCmdValue.Text.Trim();
                CmdItem editedCmd = new CmdItem(category, newCName, newCValue);
                RLConfig.ReplaceCommand(editIndex, editedCmd);
                this.DialogResult = DialogResult.OK;
            }
            else if (!editMode)
            { 
                string newCName = textBoxCmdName.Text.Trim();
			    string newCValue = textBoxCmdValue.Text.Trim();
			    RLConfig.AddCommand(category, newCName, newCValue);
			    this.DialogResult = DialogResult.OK;
            }
		}
	}
}
