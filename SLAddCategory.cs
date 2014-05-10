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
	public partial class SLDlg_AddCategory : Form
	{
		private bool editMode = false;
		private string editString = String.Empty;

		public SLDlg_AddCategory()
		{
			InitializeComponent();
		}

		public SLDlg_AddCategory(bool editflag, string catEditString)
		{
			InitializeComponent();
			this.editMode = editflag;
			if (editMode == true)
			{
				editString = catEditString;
				this.Text = "Edit Category";
			}
		}

		private void SLDlg_AddCategory_Load(object sender, EventArgs e)
		{
			textBoxNewCat.Text = editString;	//Either null or selected category. 
		}
	}
}
