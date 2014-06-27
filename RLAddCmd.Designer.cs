namespace RocketLauncher
{
	partial class Dialog_AddCmd
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxCmdValue = new System.Windows.Forms.TextBox();
			this.labelNewCmd = new System.Windows.Forms.Label();
			this.textBoxCmdName = new System.Windows.Forms.TextBox();
			this.labelNewCmdName = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.textBoxCmdValue);
			this.panel1.Controls.Add(this.labelNewCmd);
			this.panel1.Controls.Add(this.textBoxCmdName);
			this.panel1.Controls.Add(this.labelNewCmdName);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(387, 95);
			this.panel1.TabIndex = 0;
			// 
			// textBoxCmdValue
			// 
			this.textBoxCmdValue.Location = new System.Drawing.Point(3, 45);
			this.textBoxCmdValue.Name = "textBoxCmdValue";
			this.textBoxCmdValue.Size = new System.Drawing.Size(379, 20);
			this.textBoxCmdValue.TabIndex = 3;
			// 
			// labelNewCmd
			// 
			this.labelNewCmd.AutoSize = true;
			this.labelNewCmd.Location = new System.Drawing.Point(3, 29);
			this.labelNewCmd.Name = "labelNewCmd";
			this.labelNewCmd.Size = new System.Drawing.Size(57, 13);
			this.labelNewCmd.TabIndex = 2;
			this.labelNewCmd.Text = "Command:";
			// 
			// textBoxCmdName
			// 
			this.textBoxCmdName.Location = new System.Drawing.Point(74, 4);
			this.textBoxCmdName.Name = "textBoxCmdName";
			this.textBoxCmdName.Size = new System.Drawing.Size(168, 20);
			this.textBoxCmdName.TabIndex = 1;
			// 
			// labelNewCmdName
			// 
			this.labelNewCmdName.AutoSize = true;
			this.labelNewCmdName.Location = new System.Drawing.Point(5, 7);
			this.labelNewCmdName.Name = "labelNewCmdName";
			this.labelNewCmdName.Size = new System.Drawing.Size(62, 13);
			this.labelNewCmdName.TabIndex = 0;
			this.labelNewCmdName.Text = "Cmd Name:";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(243, 113);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(324, 113);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// Dialog_AddCmd
			// 
			this.AcceptButton = this.buttonAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(411, 150);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.panel1);
			this.Name = "Dialog_AddCmd";
			this.Text = "Add Command";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelNewCmdName;
		private System.Windows.Forms.TextBox textBoxCmdValue;
		private System.Windows.Forms.Label labelNewCmd;
		private System.Windows.Forms.TextBox textBoxCmdName;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
	}
}