using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportAppControls
{
    public partial class DriverInfoControl : UserControl
    {
        public DriverInfoControl()
        {
            InitializeComponent();
        }
        public int DriverId
        {
            get => int.TryParse(txtDriverId.Text, out int id) ? id : 0;
            set => txtDriverId.Text = value.ToString();
        }

        public string FirstName
        {
            get => txtFirstName.Text;
            set => txtFirstName.Text = value;
        }

        public string LastName
        {
            get => txtLastName.Text;
            set => txtLastName.Text = value;
        }

        public string LicenseNumber
        {
            get => txtLicenseNumber.Text;
            set => txtLicenseNumber.Text = value;
        }

        public string PhoneNumber
        {
            get => txtPhoneNumber.Text;
            set => txtPhoneNumber.Text = value;
        }

        public string Email
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
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
    }
}


