using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_App.Entities;

namespace Transport_App
{
    public partial class TransportForm : Form
    {
        private TransportContext _context;
        private ErrorProvider errorProvider;
        public TransportForm()
        {
            InitializeComponent();
            _context = new TransportContext();
            ConfigureDataGridView();
            LoadTransports();
            LoadDrivers();
            LoadRoutes();

            errorProvider = new ErrorProvider();
        }

        private void ConfigureDataGridView()
        {
            dgvTransports.AutoGenerateColumns = false;

            dgvTransports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TransportId",
                HeaderText = "Transport ID",
                DataPropertyName = "TransportId",
                ReadOnly = true // IDs are typically read-only
            });

            dgvTransports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DriverLastName",
                HeaderText = "Driver Last Name",
                DataPropertyName = "DriverLastName"
            });

            dgvTransports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DriverId",
                HeaderText = "Driver ID",
                DataPropertyName = "DriverId"
            });

            dgvTransports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RouteId",
                HeaderText = "Route ID",
                DataPropertyName = "RouteId"
            });

            dgvTransports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RouteDetails",
                HeaderText = "Route",
                DataPropertyName = "RouteDetails"
            });

            dgvTransports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Date",
                HeaderText = "Transport Date",
                DataPropertyName = "Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });

            dgvTransports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LoadDetails",
                HeaderText = "Load Details",
                DataPropertyName = "LoadDetails"
            });
        }

        private void LoadTransports()
        {
            var transportData = from t in _context.Transports
                                join d in _context.Drivers on t.DriverId equals d.DriverId
                                join r in _context.Routes on t.RouteId equals r.RouteId
                                select new
                                {
                                    t.TransportId,
                                    t.DriverId,
                                    DriverLastName = d.LastName,
                                    t.RouteId,
                                    RouteDetails = r.Origin + " - " + r.Destination,
                                    t.Date,
                                    t.LoadDetails
                                };

            dgvTransports.DataSource = transportData.ToList();
        }

        private void LoadDrivers()
        {
            cmbDriverId.DataSource = _context.Drivers.ToList();
            cmbDriverId.DisplayMember = "DriverId";
            cmbDriverId.ValueMember = "DriverId";
        }

        private void LoadRoutes()
        {
            cmbRouteId.DataSource = _context.Routes.ToList();
            cmbRouteId.DisplayMember = "RouteId";
            cmbRouteId.ValueMember = "RouteId";
        }

        private void ClearForm()
        {
            cmbDriverId.SelectedIndex = -1;
            cmbRouteId.SelectedIndex = -1;
            dtpTransportDate.Value = DateTime.Now;
            txtLoadDetails.Clear();
        }


        private void cmbDriverId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRouteId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpTransportDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLoadDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTransport_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var transport = new Transport
                {
                    DriverId = (int)cmbDriverId.SelectedValue,
                    RouteId = (int)cmbRouteId.SelectedValue,
                    Date = dtpTransportDate.Value,
                    LoadDetails = txtLoadDetails.Text
                };
                _context.Transports.Add(transport);
                _context.SaveChanges();
                LoadTransports();
                ClearForm();
            }
        }

        private void btnUpdateTransport_Click(object sender, EventArgs e)
        {
            if (dgvTransports.CurrentRow != null && ValidateChildren())
            {
                var transportId = (int)dgvTransports.CurrentRow.Cells["TransportId"].Value;
                var transport = _context.Transports.Find(transportId);
                if (transport != null)
                {
                    transport.DriverId = (int)cmbDriverId.SelectedValue;
                    transport.RouteId = (int)cmbRouteId.SelectedValue;
                    transport.Date = dtpTransportDate.Value;
                    transport.LoadDetails = txtLoadDetails.Text;
                    _context.SaveChanges();
                    LoadTransports();
                    ClearForm();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransports.CurrentRow != null)
            {
                var transportId = (int)dgvTransports.CurrentRow.Cells["TransportId"].Value;
                var transport = _context.Transports.Find(transportId);
                if (transport != null)
                {
                    _context.Transports.Remove(transport);
                    _context.SaveChanges();
                    LoadTransports();
                    ClearForm();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpTransportDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpTransportDate.Value == null)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpTransportDate, "Please select a valid date.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtpTransportDate, null);
            }
        }

        private void txtLoadDetails_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoadDetails.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLoadDetails, "Please enter load details.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLoadDetails, null);
            }
        }
    }
}
