using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_App.Entities;
using System.IO;
using System.Drawing.Printing;

namespace Transport_App
{
    public partial class MainForm : Form
    {
        private DataManager _dataManager;
        private TransportContext _context;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;

        public MainForm()
        {
            InitializeComponent();

            _context = new TransportContext();
            _dataManager = new DataManager(_context);

            fileToolStripMenuItem.Text = "&File"; // Alt + F
            viewToolStripMenuItem.Text = "&View"; // Alt + V
            helpToolStripMenuItem.Text = "&Help"; // Alt + H

            btnDrivers.Text = "&Drivers"; // Alt + D
            btnRoutes.Text = "&Routes"; // Alt + R
            btnTransports.Text = "&Transports"; // Alt + T

            toolStripSearchCategory.Items.AddRange(new object[] {
        "Drivers",
        "Routes",
        "Transports"});

            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    this.exportReportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);

            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportReportToolStripMenuItem.Text = "Export Report";
            this.exportReportToolStripMenuItem.Click += new System.EventHandler(this.exportReportToolStripMenuItem_Click);

            // MainForm
            // 
            this.ContextMenuStrip = this.contextMenuStrip; // Associate the context menu with the MainForm
            this.components = new System.ComponentModel.Container();
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

            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            // Add Print Preview menu item
            ToolStripMenuItem printPreviewMenuItem = new ToolStripMenuItem("Print Preview");
            printPreviewMenuItem.Click += new EventHandler(printPreviewToolStripMenuItem_Click);
            fileToolStripMenuItem.DropDownItems.Add(printPreviewMenuItem);

            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm();
            driverForm.ShowDialog();
            toolStripStatusLabel.Text = "Opened Driver Form";
        }

        private void manageRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteForm routeForm = new RouteForm();
            routeForm.ShowDialog();
            toolStripStatusLabel.Text = "Opened Route Form";
        }

        private void manageTransportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransportForm transportForm = new TransportForm();
            transportForm.ShowDialog();
            toolStripStatusLabel.Text = "Opened Transport Form";
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm();
            driverForm.ShowDialog();
            toolStripStatusLabel.Text = "Opened Driver Form";
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            RouteForm routesForm = new RouteForm();
            routesForm.ShowDialog();
            toolStripStatusLabel.Text = "Opened Route Form";
        }

        private void btnTransports_Click(object sender, EventArgs e)
        {
            TransportForm transportForm = new TransportForm();
            transportForm.ShowDialog();
            toolStripStatusLabel.Text = "Opened Transport Form";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Transport Management App\nVersion 1.0\nDeveloped by Sabina-Maria Andrici\n" +
                                  "This application helps manage drivers, routes, and transports efficiently.";
            MessageBox.Show(aboutMessage, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripStatusLabel.Text = "Displayed About Information";
        }

        private void contactSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string supportMessage = "For support, please contact us at:\nEmail: support@transportapp.com\nPhone: 0729034485";
            MessageBox.Show(supportMessage, "Contact Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripStatusLabel.Text = "Displayed Contact Support Information";
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataManager.SerializeDrivers("drivers.json");
            MessageBox.Show("Drivers serialized successfully.");
            toolStripStatusLabel.Text = "Serialized Drivers";
        }

        private void driversToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dataManager.DeserializeDrivers("drivers.json");
            MessageBox.Show("Drivers deserialized successfully.");
            toolStripStatusLabel.Text = "Deserialized Drivers";
        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataManager.SerializeRoutes("routes.json");
            MessageBox.Show("Routes serialized successfully.");
            toolStripStatusLabel.Text = "Serialized Routes";
        }

        private void routesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dataManager.DeserializeRoutes("routes.json");
            MessageBox.Show("Routes deserialized successfully.");
            toolStripStatusLabel.Text = "Deserialized Routes";
        }

        private void transportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dataManager.SerializeTransports("transports.json");
            MessageBox.Show("Transports serialized successfully.");
            toolStripStatusLabel.Text = "Serialized Transports";
        }

        private void transportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dataManager.DeserializeTransports("transports.json");
            MessageBox.Show("Transports deserialized successfully.");
            toolStripStatusLabel.Text = "Deserialized Transports";
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SearchDrivers(string searchText)
        {
            var results = _context.Drivers.Where(d => d.FirstName.ToLower().Contains(searchText) ||
                                              d.LastName.ToLower().Contains(searchText) ||
                                              d.LicenseNumber.ToLower().Contains(searchText) ||
                                              d.PhoneNumber.ToLower().Contains(searchText) ||
                                              d.Email.ToLower().Contains(searchText)).ToList();

            // Display results in a message box or a DataGridView
            MessageBox.Show($"Found {results.Count} drivers matching '{searchText}'.");
        }

        private void SearchRoutes(string searchText)
        {
            var results = _context.Routes.Where(r => r.Origin.ToLower().Contains(searchText) ||
                                             r.Destination.ToLower().Contains(searchText)).ToList();

            // Display results in a message box or a DataGridView
            MessageBox.Show($"Found {results.Count} routes matching '{searchText}'.");
        }

        private void SearchTransports(string searchText)
        {
            var results = _context.Transports.Where(t => t.LoadDetails.ToLower().Contains(searchText) ||
                                                 t.Driver.FirstName.ToLower().Contains(searchText) ||
                                                 t.Driver.LastName.ToLower().Contains(searchText) ||
                                                 t.Route.Origin.ToLower().Contains(searchText) ||
                                                 t.Route.Destination.ToLower().Contains(searchText)).ToList();

            // Display results in a message box or a DataGridView
            MessageBox.Show($"Found {results.Count} transports matching '{searchText}'.");
        }

        private void toolStripSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = toolStripSearchTextBox.Text;
            string searchCategory = toolStripSearchCategory.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (searchCategory == null)
            {
                MessageBox.Show("Please select a search category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (searchCategory)
            {
                case "Drivers":
                    SearchDrivers(searchTerm);
                    toolStripStatusLabel.Text = $"Searched Drivers for '{searchTerm}'";
                    break;
                case "Routes":
                    SearchRoutes(searchTerm);
                    toolStripStatusLabel.Text = $"Searched Routes for '{searchTerm}'";
                    break;
                case "Transports":
                    SearchTransports(searchTerm);
                    toolStripStatusLabel.Text = $"Searched Transports for '{searchTerm}'";
                    break;
                default:
                    MessageBox.Show("Invalid search category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripStatusLabel.Text = "Invalid search category";
                    break;
            }
        }

        private void toolStripSearchTextBox_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSearchCategory_Click(object sender, EventArgs e)
        {

        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportReport();
        }
        private void ExportReport()
        {
            StringBuilder reportBuilder = new StringBuilder();

            reportBuilder.AppendLine("Driver Report");
            reportBuilder.AppendLine("-------------");

            var drivers = _context.Drivers.ToList();
            foreach (var driver in drivers)
            {
                reportBuilder.AppendLine($"ID: {driver.DriverId}, Name: {driver.FirstName} {driver.LastName}, License: {driver.LicenseNumber}, Phone: {driver.PhoneNumber}, Email: {driver.Email}");
            }

            SaveReportToFile(reportBuilder.ToString());
        }

        private void SaveReportToFile(string reportContent)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, reportContent);
                    MessageBox.Show("Report exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            exportReportToolStripMenuItem.Enabled = true;
        }


        private void exportReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ExportReport();
          
            toolStripStatusLabel.Text = "Export Report triggered.";
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            chartForm.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var drivers = _context.Drivers.ToList();
            float yPos = e.MarginBounds.Top;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = this.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            foreach (var driver in drivers)
            {
                line = $"ID: {driver.DriverId}, Name: {driver.FirstName} {driver.LastName}, License: {driver.LicenseNumber}";
                yPos = topMargin + (count * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPos, new StringFormat());
                count++;
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void labelManage_Click(object sender, EventArgs e)
        {

        }
    }
}



