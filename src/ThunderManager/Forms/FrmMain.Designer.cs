namespace ThunderManager.Forms
{
    partial class FrmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMods = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvModsThunderstore = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDownloads = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnUpdated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openWebsiteTsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabMods.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvModsThunderstore)).BeginInit();
            this.TsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblStatusValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Status";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(36, 17);
            this.lblStatusValue.Text = "None";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabMods
            // 
            this.tabMods.Controls.Add(this.tabPage1);
            this.tabMods.Controls.Add(this.tabPage2);
            this.tabMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMods.Location = new System.Drawing.Point(0, 24);
            this.tabMods.Name = "tabMods";
            this.tabMods.SelectedIndex = 0;
            this.tabMods.Size = new System.Drawing.Size(996, 554);
            this.tabMods.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Installed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvModsThunderstore);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thunderstore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvModsThunderstore
            // 
            this.lvModsThunderstore.AllColumns.Add(this.olvColumnName);
            this.lvModsThunderstore.AllColumns.Add(this.olvColumnVersion);
            this.lvModsThunderstore.AllColumns.Add(this.olvColumnDownloads);
            this.lvModsThunderstore.AllColumns.Add(this.olvColumnUpdated);
            this.lvModsThunderstore.CellEditUseWholeCell = false;
            this.lvModsThunderstore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnVersion,
            this.olvColumnDownloads,
            this.olvColumnUpdated});
            this.lvModsThunderstore.ContextMenuStrip = this.TsMenuStrip;
            this.lvModsThunderstore.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvModsThunderstore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvModsThunderstore.FullRowSelect = true;
            this.lvModsThunderstore.GridLines = true;
            this.lvModsThunderstore.Location = new System.Drawing.Point(3, 3);
            this.lvModsThunderstore.Name = "lvModsThunderstore";
            this.lvModsThunderstore.ShowGroups = false;
            this.lvModsThunderstore.Size = new System.Drawing.Size(982, 522);
            this.lvModsThunderstore.TabIndex = 3;
            this.lvModsThunderstore.UseCompatibleStateImageBehavior = false;
            this.lvModsThunderstore.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.FillsFreeSpace = true;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 195;
            // 
            // olvColumnVersion
            // 
            this.olvColumnVersion.AspectName = "Version";
            this.olvColumnVersion.Text = "Version";
            this.olvColumnVersion.Width = 90;
            // 
            // olvColumnDownloads
            // 
            this.olvColumnDownloads.AspectName = "Downloads";
            this.olvColumnDownloads.Text = "Downloads";
            this.olvColumnDownloads.Width = 140;
            // 
            // olvColumnUpdated
            // 
            this.olvColumnUpdated.AspectName = "UpdatedAt";
            this.olvColumnUpdated.Text = "Updated";
            this.olvColumnUpdated.Width = 90;
            // 
            // TsMenuStrip
            // 
            this.TsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWebsiteTsMenuItem});
            this.TsMenuStrip.Name = "TsMenuStrip";
            this.TsMenuStrip.Size = new System.Drawing.Size(201, 26);
            // 
            // openWebsiteTsMenuItem
            // 
            this.openWebsiteTsMenuItem.Name = "openWebsiteTsMenuItem";
            this.openWebsiteTsMenuItem.Size = new System.Drawing.Size(200, 22);
            this.openWebsiteTsMenuItem.Text = "View on thunderstore.io";
            this.openWebsiteTsMenuItem.Click += new System.EventHandler(this.OpenWebsiteTsMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 600);
            this.Controls.Add(this.tabMods);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThunderManager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMods.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvModsThunderstore)).EndInit();
            this.TsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusValue;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMods;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private BrightIdeasSoftware.ObjectListView lvModsThunderstore;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnVersion;
        private BrightIdeasSoftware.OLVColumn olvColumnUpdated;
        private BrightIdeasSoftware.OLVColumn olvColumnDownloads;
        private System.Windows.Forms.ContextMenuStrip TsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openWebsiteTsMenuItem;
    }
}

