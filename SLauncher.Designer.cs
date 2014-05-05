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
			this.buttonHide = new System.Windows.Forms.Button();
			this.labelCategories = new System.Windows.Forms.Label();
			this.listBoxCats = new System.Windows.Forms.ListBox();
			this.contextMenuStrip.SuspendLayout();
			this.panelOuter.SuspendLayout();
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
			this.labelConfig.Location = new System.Drawing.Point(13, 13);
			this.labelConfig.Name = "labelConfig";
			this.labelConfig.Size = new System.Drawing.Size(37, 13);
			this.labelConfig.TabIndex = 1;
			this.labelConfig.Text = "Config";
			// 
			// panelOuter
			// 
			this.panelOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelOuter.Controls.Add(this.listBoxCats);
			this.panelOuter.Controls.Add(this.labelCategories);
			this.panelOuter.Location = new System.Drawing.Point(12, 29);
			this.panelOuter.Name = "panelOuter";
			this.panelOuter.Size = new System.Drawing.Size(560, 291);
			this.panelOuter.TabIndex = 2;
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
			// labelCategories
			// 
			this.labelCategories.AutoSize = true;
			this.labelCategories.Location = new System.Drawing.Point(4, 4);
			this.labelCategories.Name = "labelCategories";
			this.labelCategories.Size = new System.Drawing.Size(57, 13);
			this.labelCategories.TabIndex = 1;
			this.labelCategories.Text = "Categories";
			// 
			// listBoxCats
			// 
			this.listBoxCats.FormattingEnabled = true;
			this.listBoxCats.Location = new System.Drawing.Point(3, 21);
			this.listBoxCats.Name = "listBoxCats";
			this.listBoxCats.Size = new System.Drawing.Size(129, 264);
			this.listBoxCats.TabIndex = 2;
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
		private System.Windows.Forms.ListBox listBoxCats;
		private System.Windows.Forms.Label labelCategories;
    }
}

