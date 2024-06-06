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
    public partial class DriverForm : Form
    {
        private TransportContext _context;

        public DriverForm()
        {
            InitializeComponent();
            _context = new TransportContext();
            ConfigureDataGridView();
            LoadDrivers();

            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            this.txtLicenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseNumber_Validating);   
        }


        private void ConfigureDataGridView()
        {
            dgvDrivers.AutoGenerateColumns = false;

            dgvDrivers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DriverId",
                HeaderText = "Driver ID",
                DataPropertyName = "DriverId",
                ReadOnly = true 
            });

            dgvDrivers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last Name",
                DataPropertyName = "LastName"
            });

            dgvDrivers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First Name",
                DataPropertyName = "FirstName"
            });

            dgvDrivers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LicenseNumber",
                HeaderText = "License Number",
                DataPropertyName = "LicenseNumber"
            });

            dgvDrivers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                HeaderText = "Phone Number",
                DataPropertyName = "PhoneNumber"
            });

            dgvDrivers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email"
            });

        }
        private void LoadDrivers()
        {
            var drivers = _context.Drivers.ToList();
            dgvDrivers.DataSource = drivers;
        }

        private void txtDriverId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLicenseNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var driver = new Driver
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    LicenseNumber = txtLicenseNumber.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text
                };
                _context.Drivers.Add(driver);
                _context.SaveChanges();
                LoadDrivers();
                ClearForm();
            }

        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.CurrentRow != null && ValidateChildren())
            {
                var driverId = (int)dgvDrivers.CurrentRow.Cells["DriverId"].Value;
                var driver = _context.Drivers.Find(driverId);
                if (driver != null)
                {
                    driver.LastName = txtLastName.Text;
                    driver.FirstName = txtFirstName.Text;
                    driver.LicenseNumber = txtLicenseNumber.Text;
                    driver.PhoneNumber = txtPhoneNumber.Text;
                    driver.Email = txtEmail.Text;
                    _context.SaveChanges();
                    LoadDrivers();
                    ClearForm();
                }
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.CurrentRow != null)
            {
                var driverId = (int)dgvDrivers.CurrentRow.Cells["DriverId"].Value;
                var driver = _context.Drivers.Find(driverId);
                if (driver != null)
                {
                    _context.Drivers.Remove(driver);
                    _context.SaveChanges();
                    LoadDrivers();
                    ClearForm();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDrivers.CurrentRow != null)
            {
                txtDriverId.Text = dgvDrivers.CurrentRow.Cells["DriverId"].Value.ToString();
                txtLastName.Text = dgvDrivers.CurrentRow.Cells["LastName"].Value.ToString();
                txtFirstName.Text = dgvDrivers.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLicenseNumber.Text = dgvDrivers.CurrentRow.Cells["LicenseNumber"].Value.ToString();
                txtPhoneNumber.Text = dgvDrivers.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = dgvDrivers.CurrentRow.Cells["Email"].Value.ToString();
            }

      
        }
        private void ClearForm()
        {
            txtDriverId.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtLicenseNumber.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                epFirstName.SetError(txtFirstName, "First name is required.");
            }
            else
            {
                e.Cancel = false;
                epFirstName.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                epLastName.SetError(txtLastName, "Last name is required.");
            }
            else
            {
                e.Cancel = false;
                epLastName.SetError(txtLastName, "");
            }
        }

        private void txtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                e.Cancel= true;
                epLicenseNumber.SetError(txtLicenseNumber, "License number is required.");
            }
            else
            {
                e.Cancel = false;
                epLicenseNumber.SetError(txtLicenseNumber, "");
            }
        }
    }

}
