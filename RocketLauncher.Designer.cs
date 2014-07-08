namespace RocketLauncher
{
    partial class RLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RLauncher));
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
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.panelBanner = new System.Windows.Forms.Panel();
            this.RLConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.panelOuter.SuspendLayout();
            this.panelGridPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLConfigBindingSource)).BeginInit();
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
            this.contextMenuStrip.Text = "RocketLauncher";
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
            this.trayIcon.Text = "RocketLauncher";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfig.Location = new System.Drawing.Point(12, 75);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(37, 13);
            this.labelConfig.TabIndex = 0;
            this.labelConfig.Text = "Config";
            // 
            // panelOuter
            // 
            this.panelOuter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelOuter.Location = new System.Drawing.Point(12, 91);
            this.panelOuter.Name = "panelOuter";
            this.panelOuter.Size = new System.Drawing.Size(560, 229);
            this.panelOuter.TabIndex = 1;
            // 
            // buttonEditCmd
            // 
            this.buttonEditCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditCmd.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCmd.Image")));
            this.buttonEditCmd.Location = new System.Drawing.Point(179, 190);
            this.buttonEditCmd.Name = "buttonEditCmd";
            this.buttonEditCmd.Size = new System.Drawing.Size(32, 30);
            this.buttonEditCmd.TabIndex = 12;
            this.toolTipButtons.SetToolTip(this.buttonEditCmd, "Edit Command");
            this.buttonEditCmd.UseVisualStyleBackColor = true;
            this.buttonEditCmd.Click += new System.EventHandler(this.buttonEditCmd_Click);
            // 
            // buttonDelCmd
            // 
            this.buttonDelCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelCmd.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelCmd.Image")));
            this.buttonDelCmd.Location = new System.Drawing.Point(217, 190);
            this.buttonDelCmd.Name = "buttonDelCmd";
            this.buttonDelCmd.Size = new System.Drawing.Size(32, 30);
            this.buttonDelCmd.TabIndex = 13;
            this.toolTipButtons.SetToolTip(this.buttonDelCmd, "Delete Command");
            this.buttonDelCmd.UseVisualStyleBackColor = true;
            this.buttonDelCmd.Click += new System.EventHandler(this.buttonDelCmd_Click);
            // 
            // buttonAddCmd
            // 
            this.buttonAddCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddCmd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCmd.Image")));
            this.buttonAddCmd.Location = new System.Drawing.Point(141, 190);
            this.buttonAddCmd.Name = "buttonAddCmd";
            this.buttonAddCmd.Size = new System.Drawing.Size(32, 30);
            this.buttonAddCmd.TabIndex = 11;
            this.toolTipButtons.SetToolTip(this.buttonAddCmd, "Add Command");
            this.buttonAddCmd.UseVisualStyleBackColor = true;
            this.buttonAddCmd.Click += new System.EventHandler(this.buttonAddCmd_Click);
            // 
            // buttonEditCat
            // 
            this.buttonEditCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditCat.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCat.Image")));
            this.buttonEditCat.Location = new System.Drawing.Point(42, 190);
            this.buttonEditCat.Name = "buttonEditCat";
            this.buttonEditCat.Size = new System.Drawing.Size(32, 30);
            this.buttonEditCat.TabIndex = 9;
            this.toolTipButtons.SetToolTip(this.buttonEditCat, "Edit Category");
            this.buttonEditCat.UseVisualStyleBackColor = true;
            this.buttonEditCat.Click += new System.EventHandler(this.buttonEditCat_Click);
            // 
            // buttonDelCat
            // 
            this.buttonDelCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelCat.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelCat.Image")));
            this.buttonDelCat.Location = new System.Drawing.Point(80, 190);
            this.buttonDelCat.Name = "buttonDelCat";
            this.buttonDelCat.Size = new System.Drawing.Size(32, 30);
            this.buttonDelCat.TabIndex = 10;
            this.toolTipButtons.SetToolTip(this.buttonDelCat, "Delete Category");
            this.buttonDelCat.UseVisualStyleBackColor = true;
            this.buttonDelCat.Click += new System.EventHandler(this.buttonDelCat_Click);
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddCat.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCat.Image")));
            this.buttonAddCat.Location = new System.Drawing.Point(4, 190);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(32, 30);
            this.buttonAddCat.TabIndex = 8;
            this.toolTipButtons.SetToolTip(this.buttonAddCat, "Add Category");
            this.buttonAddCat.UseVisualStyleBackColor = true;
            this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
            // 
            // panelGridPane
            // 
            this.panelGridPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGridPane.Controls.Add(this.dataGridCommands);
            this.panelGridPane.Location = new System.Drawing.Point(141, 21);
            this.panelGridPane.Name = "panelGridPane";
            this.panelGridPane.Size = new System.Drawing.Size(403, 163);
            this.panelGridPane.TabIndex = 6;
            // 
            // dataGridCommands
            // 
            this.dataGridCommands.AllowUserToOrderColumns = true;
            this.dataGridCommands.AllowUserToResizeRows = false;
            this.dataGridCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumnName,
            this.gridColumnCommand});
            this.dataGridCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCommands.Location = new System.Drawing.Point(0, 0);
            this.dataGridCommands.MultiSelect = false;
            this.dataGridCommands.Name = "dataGridCommands";
            this.dataGridCommands.ReadOnly = true;
            this.dataGridCommands.RowHeadersVisible = false;
            this.dataGridCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridCommands.Size = new System.Drawing.Size(403, 163);
            this.dataGridCommands.TabIndex = 7;
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
            this.listBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(4, 21);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(130, 160);
            this.listBoxCategories.TabIndex = 4;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // labelCmds
            // 
            this.labelCmds.AutoSize = true;
            this.labelCmds.Location = new System.Drawing.Point(138, 3);
            this.labelCmds.Name = "labelCmds";
            this.labelCmds.Size = new System.Drawing.Size(59, 13);
            this.labelCmds.TabIndex = 5;
            this.labelCmds.Text = "&Commands";
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Location = new System.Drawing.Point(4, 4);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(57, 13);
            this.labelCategories.TabIndex = 3;
            this.labelCategories.Text = "C&ategories";
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHide.Location = new System.Drawing.Point(497, 326);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(75, 23);
            this.buttonHide.TabIndex = 14;
            this.buttonHide.Text = "&Hide";
            this.toolTipButtons.SetToolTip(this.buttonHide, "Hide in task tray");
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBanner.BackgroundImage")));
            this.panelBanner.Location = new System.Drawing.Point(39, 12);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(500, 50);
            this.panelBanner.TabIndex = 15;
            this.panelBanner.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBanner_Paint);
            // 
            // RLConfigBindingSource
            // 
            this.RLConfigBindingSource.DataSource = typeof(RocketLauncher.RLConfig);
            this.RLConfigBindingSource.CurrentChanged += new System.EventHandler(this.sLConfigBindingSource_CurrentChanged);
            // 
            // RLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.panelOuter);
            this.Controls.Add(this.labelConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "RLauncher";
            this.Text = "RocketLauncher";
            this.Load += new System.EventHandler(this.RocketLauncher_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.panelOuter.ResumeLayout(false);
            this.panelOuter.PerformLayout();
            this.panelGridPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLConfigBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource RLConfigBindingSource;
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
        private System.Windows.Forms.ToolTip toolTipButtons;
        private System.Windows.Forms.Panel panelBanner;
    }
}

