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
    public partial class RouteForm : Form
    {
        private TransportContext _context;
        private ErrorProvider errorProvider;
        public RouteForm()
        {
            InitializeComponent();
            _context = new TransportContext();
            errorProvider = new ErrorProvider();
            ConfigureDataGridView();
            LoadRoutes();

            tbDistance.KeyPress += tbDistance_KeyPress;
            tbDistance.Validating += tbDistance_Validating;
        }
        private void ConfigureDataGridView()
        {
            dgvRoutes.AutoGenerateColumns = false;

            dgvRoutes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RouteId",
                HeaderText = "Route ID",
                DataPropertyName = "RouteId",
                ReadOnly = true // IDs are typically read-only
            });

            dgvRoutes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Origin",
                HeaderText = "Origin",
                DataPropertyName = "Origin"
            });

            dgvRoutes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Destination",
                HeaderText = "Destination",
                DataPropertyName = "Destination"
            });

            dgvRoutes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Distance",
                HeaderText = "Distance",
                DataPropertyName = "Distance"
            });
        }

        private void LoadRoutes()
        {
            dgvRoutes.DataSource = _context.Routes.ToList();
        }

        private void ClearForm()
        {
            
            tbOrigin.Clear();
            tbDestination.Clear();
            tbDistance.Clear();
        }



        private void tbRouteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOrigin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var route = new Route
                {
                    Origin = tbOrigin.Text,
                    Destination = tbDestination.Text,
                    Distance = double.Parse(tbDistance.Text)
                };
                _context.Routes.Add(route);
                _context.SaveChanges();
                LoadRoutes();
                ClearForm();
            }
        }

        private void btnUpdateRoute_Click(object sender, EventArgs e)
        {
            if (dgvRoutes.CurrentRow != null && ValidateChildren())
            {
                var routeId = (int)dgvRoutes.CurrentRow.Cells["RouteId"].Value;
                var route = _context.Routes.Find(routeId);
                if (route != null)
                {
                    route.Origin = tbOrigin.Text;
                    route.Destination = tbDestination.Text;
                    route.Distance = double.Parse(tbDistance.Text);
                    _context.SaveChanges();
                    LoadRoutes();
                    ClearForm();
                }
            }
        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            if (dgvRoutes.CurrentRow != null)
            {
                var routeId = (int)dgvRoutes.CurrentRow.Cells["RouteId"].Value;
                var route = _context.Routes.Find(routeId);
                if (route != null)
                {
                    _context.Routes.Remove(route);
                    _context.SaveChanges();
                    LoadRoutes();
                    ClearForm();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Reject the input
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Reject the input
            }
        }

        private void tbDistance_Validating(object sender, CancelEventArgs e)
        {

            if (!double.TryParse(tbDistance.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(tbDistance, "Please enter a valid number for Distance.");
            }
            else
            {
                e.Cancel = false; 
                errorProvider.SetError(tbDistance, null);
            }
        }
    }
}
