using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptLauncher
{
	public partial class Dialog_AddCmd : Form
	{
		private string category;
		
		public Dialog_AddCmd()
		{
			InitializeComponent();
		}

		public Dialog_AddCmd(string selectedCat)
		{
			InitializeComponent();
			category = selectedCat;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			string newCName = textBoxCmdName.Text.Trim();
			string newCValue = textBoxCmdValue.Text.Trim();
			SLConfig.AddCommand(category, newCName, newCValue);
			this.DialogResult = DialogResult.OK;
		}
	}
}
