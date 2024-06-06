namespace Transport_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTransportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnTransports = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSearchCategory = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSearchButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.labelManage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversToolStripMenuItem,
            this.routesToolStripMenuItem,
            this.transportsToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.routesToolStripMenuItem.Text = "Routes";
            this.routesToolStripMenuItem.Click += new System.EventHandler(this.routesToolStripMenuItem_Click);
            // 
            // transportsToolStripMenuItem
            // 
            this.transportsToolStripMenuItem.Name = "transportsToolStripMenuItem";
            this.transportsToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.transportsToolStripMenuItem.Text = "Transports";
            this.transportsToolStripMenuItem.Click += new System.EventHandler(this.transportsToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversToolStripMenuItem1,
            this.routesToolStripMenuItem1,
            this.transportsToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // driversToolStripMenuItem1
            // 
            this.driversToolStripMenuItem1.Name = "driversToolStripMenuItem1";
            this.driversToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.driversToolStripMenuItem1.Text = "Drivers";
            this.driversToolStripMenuItem1.Click += new System.EventHandler(this.driversToolStripMenuItem1_Click);
            // 
            // routesToolStripMenuItem1
            // 
            this.routesToolStripMenuItem1.Name = "routesToolStripMenuItem1";
            this.routesToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.routesToolStripMenuItem1.Text = "Routes";
            this.routesToolStripMenuItem1.Click += new System.EventHandler(this.routesToolStripMenuItem1_Click);
            // 
            // transportsToolStripMenuItem1
            // 
            this.transportsToolStripMenuItem1.Name = "transportsToolStripMenuItem1";
            this.transportsToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.transportsToolStripMenuItem1.Text = "Transports";
            this.transportsToolStripMenuItem1.Click += new System.EventHandler(this.transportsToolStripMenuItem1_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDriversToolStripMenuItem,
            this.manageRoutesToolStripMenuItem,
            this.manageTransportsToolStripMenuItem,
            this.chartToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // manageDriversToolStripMenuItem
            // 
            this.manageDriversToolStripMenuItem.Name = "manageDriversToolStripMenuItem";
            this.manageDriversToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.manageDriversToolStripMenuItem.Text = "Manage Drivers";
            this.manageDriversToolStripMenuItem.Click += new System.EventHandler(this.manageDriversToolStripMenuItem_Click);
            // 
            // manageRoutesToolStripMenuItem
            // 
            this.manageRoutesToolStripMenuItem.Name = "manageRoutesToolStripMenuItem";
            this.manageRoutesToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.manageRoutesToolStripMenuItem.Text = "Manage Routes";
            this.manageRoutesToolStripMenuItem.Click += new System.EventHandler(this.manageRoutesToolStripMenuItem_Click);
            // 
            // manageTransportsToolStripMenuItem
            // 
            this.manageTransportsToolStripMenuItem.Name = "manageTransportsToolStripMenuItem";
            this.manageTransportsToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.manageTransportsToolStripMenuItem.Text = "Manage Transports";
            this.manageTransportsToolStripMenuItem.Click += new System.EventHandler(this.manageTransportsToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contactSupportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactSupportToolStripMenuItem
            // 
            this.contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
            this.contactSupportToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.contactSupportToolStripMenuItem.Text = "Contact Support";
            this.contactSupportToolStripMenuItem.Click += new System.EventHandler(this.contactSupportToolStripMenuItem_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDrivers.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.Location = new System.Drawing.Point(15, 80);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(227, 91);
            this.btnDrivers.TabIndex = 3;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackColor = System.Drawing.Color.MistyRose;
            this.btnRoutes.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.Location = new System.Drawing.Point(15, 177);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(227, 89);
            this.btnRoutes.TabIndex = 4;
            this.btnRoutes.Text = "Routes";
            this.btnRoutes.UseVisualStyleBackColor = false;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnTransports
            // 
            this.btnTransports.BackColor = System.Drawing.Color.Bisque;
            this.btnTransports.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransports.Location = new System.Drawing.Point(15, 272);
            this.btnTransports.Name = "btnTransports";
            this.btnTransports.Size = new System.Drawing.Size(227, 90);
            this.btnTransports.TabIndex = 5;
            this.btnTransports.Text = "Transports";
            this.btnTransports.UseVisualStyleBackColor = false;
            this.btnTransports.Click += new System.EventHandler(this.btnTransports_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearchCategory,
            this.toolStripSearchTextBox,
            this.toolStripSearchButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSearchCategory
            // 
            this.toolStripSearchCategory.Name = "toolStripSearchCategory";
            this.toolStripSearchCategory.Size = new System.Drawing.Size(121, 28);
            this.toolStripSearchCategory.Click += new System.EventHandler(this.toolStripSearchCategory_Click);
            // 
            // toolStripSearchTextBox
            // 
            this.toolStripSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSearchTextBox.Name = "toolStripSearchTextBox";
            this.toolStripSearchTextBox.Size = new System.Drawing.Size(100, 28);
            this.toolStripSearchTextBox.Click += new System.EventHandler(this.toolStripSearchTextBox_Click);
            // 
            // toolStripSearchButton
            // 
            this.toolStripSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearchButton.Image")));
            this.toolStripSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearchButton.Name = "toolStripSearchButton";
            this.toolStripSearchButton.Size = new System.Drawing.Size(29, 28);
            this.toolStripSearchButton.Text = "Search";
            this.toolStripSearchButton.Click += new System.EventHandler(this.toolStripSearchButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightPink;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(191, 20);
            this.toolStripStatusLabel.Text = "Welcome to Transport App!";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportReportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(171, 28);
            this.contextMenuStrip.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.exportReportToolStripMenuItem.Text = "Export Report";
            this.exportReportToolStripMenuItem.Click += new System.EventHandler(this.exportReportToolStripMenuItem_Click_1);
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.PrintDocument;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // labelManage
            // 
            this.labelManage.AutoSize = true;
            this.labelManage.Location = new System.Drawing.Point(12, 80);
            this.labelManage.Name = "labelManage";
            this.labelManage.Size = new System.Drawing.Size(0, 16);
            this.labelManage.TabIndex = 2;
            this.labelManage.Click += new System.EventHandler(this.labelManage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(629, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnTransports);
            this.Controls.Add(this.btnRoutes);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.labelManage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Transport App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.exportReportToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTransportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Button btnTransports;
        private System.Windows.Forms.ToolStripMenuItem contactSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripSearchTextBox;
        private System.Windows.Forms.ToolStripComboBox toolStripSearchCategory;
        private System.Windows.Forms.ToolStripButton toolStripSearchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.Label labelManage;
    }

}

