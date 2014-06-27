namespace RocketLauncher
{
	partial class Dialog_AddCategory
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelNewCategory = new System.Windows.Forms.Label();
			this.textBoxNewCat = new System.Windows.Forms.TextBox();
			this.panelNewCat = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.panelNewCat.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelNewCategory
			// 
			this.labelNewCategory.AutoSize = true;
			this.labelNewCategory.Location = new System.Drawing.Point(3, 11);
			this.labelNewCategory.Name = "labelNewCategory";
			this.labelNewCategory.Size = new System.Drawing.Size(77, 13);
			this.labelNewCategory.TabIndex = 0;
			this.labelNewCategory.Text = "New Category:";
			// 
			// textBoxNewCat
			// 
			this.textBoxNewCat.Location = new System.Drawing.Point(86, 8);
			this.textBoxNewCat.Name = "textBoxNewCat";
			this.textBoxNewCat.Size = new System.Drawing.Size(150, 20);
			this.textBoxNewCat.TabIndex = 1;
			// 
			// panelNewCat
			// 
			this.panelNewCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelNewCat.Controls.Add(this.labelNewCategory);
			this.panelNewCat.Controls.Add(this.textBoxNewCat);
			this.panelNewCat.Location = new System.Drawing.Point(12, 12);
			this.panelNewCat.Name = "panelNewCat";
			this.panelNewCat.Size = new System.Drawing.Size(248, 39);
			this.panelNewCat.TabIndex = 2;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(184, 58);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(103, 57);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// Dialog_AddCategory
			// 
			this.AcceptButton = this.buttonAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(269, 94);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.panelNewCat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Dialog_AddCategory";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Category";
			this.Load += new System.EventHandler(this.Dialog_AddCategory_Load);
			this.panelNewCat.ResumeLayout(false);
			this.panelNewCat.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelNewCategory;
		private System.Windows.Forms.TextBox textBoxNewCat;
		private System.Windows.Forms.Panel panelNewCat;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonAdd;
	}
}