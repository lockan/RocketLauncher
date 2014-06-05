namespace ScriptLauncher
{
    partial class SLauncher
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLauncher));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitSLauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.labelConfig = new System.Windows.Forms.Label();
			this.panelOuter = new System.Windows.Forms.Panel();
			this.buttonEditCmd = new System.Windows.Forms.Button();
			this.buttonDelCmd = new System.Windows.Forms.Button();
			this.buttonAddCmd = new System.Windows.Forms.Button();
			this.buttonEditCat = new System.Windows.Forms.Button();
			this.buttonDelCat = new System.Windows.Forms.Button();
			this.buttonAddCat = new System.Windows.Forms.Button();
			this.panelGridPane = new System.Windows.Forms.Panel();
			this.dataGridCommands = new System.Windows.Forms.DataGridView();
			this.gridColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gridColumnCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listBoxCategories = new System.Windows.Forms.ListBox();
			this.labelCmds = new System.Windows.Forms.Label();
			this.labelCategories = new System.Windows.Forms.Label();
			this.buttonHide = new System.Windows.Forms.Button();
			this.sLConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.panelOuter.SuspendLayout();
			this.panelGridPane.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCommands)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sLConfigBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitSLauncherToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(181, 70);
			this.contextMenuStrip.Text = "SLauncher";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "toolStripMenuItem1";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem2.Text = "toolStripMenuItem2";
			// 
			// exitSLauncherToolStripMenuItem
			// 
			this.exitSLauncherToolStripMenuItem.Name = "exitSLauncherToolStripMenuItem";
			this.exitSLauncherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitSLauncherToolStripMenuItem.Text = "E&xit SLauncher";
			// 
			// trayIcon
			// 
			this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.trayIcon.BalloonTipText = "BALLOONTIP!";
			this.trayIcon.BalloonTipTitle = "BALLOONTITLE";
			this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "SLauncher";
			this.trayIcon.Visible = true;
			this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// labelConfig
			// 
			this.labelConfig.AutoSize = true;
			this.labelConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConfig.Location = new System.Drawing.Point(13, 13);
			this.labelConfig.Name = "labelConfig";
			this.labelConfig.Size = new System.Drawing.Size(37, 13);
			this.labelConfig.TabIndex = 1;
			this.labelConfig.Text = "Config";
			// 
			// panelOuter
			// 
			this.panelOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelOuter.Controls.Add(this.buttonEditCmd);
			this.panelOuter.Controls.Add(this.buttonDelCmd);
			this.panelOuter.Controls.Add(this.buttonAddCmd);
			this.panelOuter.Controls.Add(this.buttonEditCat);
			this.panelOuter.Controls.Add(this.buttonDelCat);
			this.panelOuter.Controls.Add(this.buttonAddCat);
			this.panelOuter.Controls.Add(this.panelGridPane);
			this.panelOuter.Controls.Add(this.listBoxCategories);
			this.panelOuter.Controls.Add(this.labelCmds);
			this.panelOuter.Controls.Add(this.labelCategories);
			this.panelOuter.Location = new System.Drawing.Point(12, 29);
			this.panelOuter.Name = "panelOuter";
			this.panelOuter.Size = new System.Drawing.Size(560, 291);
			this.panelOuter.TabIndex = 2;
			// 
			// buttonEditCmd
			// 
			this.buttonEditCmd.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCmd.Image")));
			this.buttonEditCmd.Location = new System.Drawing.Point(179, 252);
			this.buttonEditCmd.Name = "buttonEditCmd";
			this.buttonEditCmd.Size = new System.Drawing.Size(32, 30);
			this.buttonEditCmd.TabIndex = 13;
			this.buttonEditCmd.UseVisualStyleBackColor = true;
			this.buttonEditCmd.Click += new System.EventHandler(this.buttonEditCmd_Click);
			// 
			// buttonDelCmd
			// 
			this.buttonDelCmd.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelCmd.Image")));
			this.buttonDelCmd.Location = new System.Drawing.Point(217, 252);
			this.buttonDelCmd.Name = "buttonDelCmd";
			this.buttonDelCmd.Size = new System.Drawing.Size(32, 30);
			this.buttonDelCmd.TabIndex = 12;
			this.buttonDelCmd.UseVisualStyleBackColor = true;
			this.buttonDelCmd.Click += new System.EventHandler(this.buttonDelCmd_Click);
			// 
			// buttonAddCmd
			// 
			this.buttonAddCmd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCmd.Image")));
			this.buttonAddCmd.Location = new System.Drawing.Point(141, 252);
			this.buttonAddCmd.Name = "buttonAddCmd";
			this.buttonAddCmd.Size = new System.Drawing.Size(32, 30);
			this.buttonAddCmd.TabIndex = 11;
			this.buttonAddCmd.UseVisualStyleBackColor = true;
			this.buttonAddCmd.Click += new System.EventHandler(this.buttonAddCmd_Click);
			// 
			// buttonEditCat
			// 
			this.buttonEditCat.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCat.Image")));
			this.buttonEditCat.Location = new System.Drawing.Point(42, 252);
			this.buttonEditCat.Name = "buttonEditCat";
			this.buttonEditCat.Size = new System.Drawing.Size(32, 30);
			this.buttonEditCat.TabIndex = 10;
			this.buttonEditCat.UseVisualStyleBackColor = true;
			this.buttonEditCat.Click += new System.EventHandler(this.buttonEditCat_Click);
			// 
			// buttonDelCat
			// 
			this.buttonDelCat.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelCat.Image")));
			this.buttonDelCat.Location = new System.Drawing.Point(80, 252);
			this.buttonDelCat.Name = "buttonDelCat";
			this.buttonDelCat.Size = new System.Drawing.Size(32, 30);
			this.buttonDelCat.TabIndex = 9;
			this.buttonDelCat.UseVisualStyleBackColor = true;
			this.buttonDelCat.Click += new System.EventHandler(this.buttonDelCat_Click);
			// 
			// buttonAddCat
			// 
			this.buttonAddCat.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCat.Image")));
			this.buttonAddCat.Location = new System.Drawing.Point(4, 252);
			this.buttonAddCat.Name = "buttonAddCat";
			this.buttonAddCat.Size = new System.Drawing.Size(32, 30);
			this.buttonAddCat.TabIndex = 8;
			this.buttonAddCat.UseVisualStyleBackColor = true;
			this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
			// 
			// panelGridPane
			// 
			this.panelGridPane.Controls.Add(this.dataGridCommands);
			this.panelGridPane.Location = new System.Drawing.Point(141, 21);
			this.panelGridPane.Name = "panelGridPane";
			this.panelGridPane.Size = new System.Drawing.Size(403, 225);
			this.panelGridPane.TabIndex = 7;
			// 
			// dataGridCommands
			// 
			this.dataGridCommands.AllowUserToOrderColumns = true;
			this.dataGridCommands.AllowUserToResizeRows = false;
			this.dataGridCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumnName,
            this.gridColumnCommand});
			this.dataGridCommands.Location = new System.Drawing.Point(0, 0);
			this.dataGridCommands.MultiSelect = false;
			this.dataGridCommands.Name = "dataGridCommands";
			this.dataGridCommands.ReadOnly = true;
			this.dataGridCommands.RowHeadersVisible = false;
			this.dataGridCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridCommands.Size = new System.Drawing.Size(403, 225);
			this.dataGridCommands.TabIndex = 6;
			// 
			// gridColumnName
			// 
			this.gridColumnName.DataPropertyName = "Name";
			this.gridColumnName.HeaderText = "Name";
			this.gridColumnName.Name = "gridColumnName";
			this.gridColumnName.ReadOnly = true;
			this.gridColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// gridColumnCommand
			// 
			this.gridColumnCommand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.gridColumnCommand.DataPropertyName = "Value";
			this.gridColumnCommand.HeaderText = "Command";
			this.gridColumnCommand.Name = "gridColumnCommand";
			this.gridColumnCommand.ReadOnly = true;
			// 
			// listBoxCategories
			// 
			this.listBoxCategories.FormattingEnabled = true;
			this.listBoxCategories.Location = new System.Drawing.Point(4, 21);
			this.listBoxCategories.Name = "listBoxCategories";
			this.listBoxCategories.Size = new System.Drawing.Size(130, 225);
			this.listBoxCategories.TabIndex = 5;
			this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
			// 
			// labelCmds
			// 
			this.labelCmds.AutoSize = true;
			this.labelCmds.Location = new System.Drawing.Point(138, 3);
			this.labelCmds.Name = "labelCmds";
			this.labelCmds.Size = new System.Drawing.Size(59, 13);
			this.labelCmds.TabIndex = 4;
			this.labelCmds.Text = "Commands";
			// 
			// labelCategories
			// 
			this.labelCategories.AutoSize = true;
			this.labelCategories.Location = new System.Drawing.Point(4, 4);
			this.labelCategories.Name = "labelCategories";
			this.labelCategories.Size = new System.Drawing.Size(57, 13);
			this.labelCategories.TabIndex = 1;
			this.labelCategories.Text = "Categories";
			// 
			// buttonHide
			// 
			this.buttonHide.Location = new System.Drawing.Point(497, 326);
			this.buttonHide.Name = "buttonHide";
			this.buttonHide.Size = new System.Drawing.Size(75, 23);
			this.buttonHide.TabIndex = 3;
			this.buttonHide.Text = "&Hide";
			this.buttonHide.UseVisualStyleBackColor = true;
			this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
			// 
			// sLConfigBindingSource
			// 
			this.sLConfigBindingSource.DataSource = typeof(ScriptLauncher.SLConfig);
			// 
			// SLauncher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.buttonHide);
			this.Controls.Add(this.panelOuter);
			this.Controls.Add(this.labelConfig);
			this.Name = "SLauncher";
			this.Text = "ScriptLauncher";
			this.Load += new System.EventHandler(this.SLauncher_Load);
			this.Resize += new System.EventHandler(this.SLauncher_Resize);
			this.contextMenuStrip.ResumeLayout(false);
			this.panelOuter.ResumeLayout(false);
			this.panelOuter.PerformLayout();
			this.panelGridPane.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCommands)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sLConfigBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ToolStripMenuItem exitSLauncherToolStripMenuItem;
		private System.Windows.Forms.Label labelConfig;
		private System.Windows.Forms.Panel panelOuter;
        private System.Windows.Forms.Button buttonHide;
		private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelCmds;
        private System.Windows.Forms.BindingSource sLConfigBindingSource;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.DataGridView dataGridCommands;
        private System.Windows.Forms.Panel panelGridPane;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnCommand;
		private System.Windows.Forms.Button buttonAddCat;
		private System.Windows.Forms.Button buttonEditCmd;
		private System.Windows.Forms.Button buttonDelCmd;
		private System.Windows.Forms.Button buttonAddCmd;
		private System.Windows.Forms.Button buttonEditCat;
		private System.Windows.Forms.Button buttonDelCat;
    }
}

