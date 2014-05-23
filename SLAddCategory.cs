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
	public partial class Dialog_AddCategory : Form
	{
		private bool editMode = false;
		private string editString = String.Empty;

		public Dialog_AddCategory()
		{
			InitializeComponent();
		}

		public Dialog_AddCategory(bool editflag, string catEditString)
		{
			InitializeComponent();
			this.editMode = editflag;
			if (editMode == true)
			{
				editString = catEditString;
				this.Text = "Edit Category";
				labelNewCategory.Text = "Edit Category";
				buttonAdd.Text = "Edit";
			}
		}

		private void Dialog_AddCategory_Load(object sender, EventArgs e)
		{
			textBoxNewCat.Text = editString;	//Either null or selected category. 
		}

		// Handles adding AND editing of strings. I know, it's confusing. 
		void buttonAdd_Click(object sender, EventArgs e)
		{
			string newCatString = textBoxNewCat.Text.Trim();
			
			if (editMode)	// Edit existing category string
			{
				if (newCatString != String.Empty && newCatString != " ")
				{
					SLConfig.RenameCategory(editString, newCatString);
					this.DialogResult = DialogResult.OK;
				}
			}
			else if (!editMode)		// Add new category string
			{
				if (newCatString != String.Empty && newCatString != " ")
				{
					SLConfig.Dbg("Adding " + newCatString);
					SLConfig.AddCategory(newCatString);
					this.DialogResult = DialogResult.OK;
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
