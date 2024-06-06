namespace Transport_App
{
    partial class DriverForm
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
            this.txtDriverId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelLicenseNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLicenseNumber = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLicenseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDriverId
            // 
            this.txtDriverId.Location = new System.Drawing.Point(220, 24);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(100, 22);
            this.txtDriverId.TabIndex = 0;
            this.txtDriverId.TextChanged += new System.EventHandler(this.txtDriverId_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(220, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(215, 22);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(220, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(215, 22);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(220, 168);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(215, 22);
            this.txtLicenseNumber.TabIndex = 3;
            this.txtLicenseNumber.TextChanged += new System.EventHandler(this.txtLicenseNumber_TextChanged);
            this.txtLicenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseNumber_Validating);
            this.txtLicenseNumber.Validated += new System.EventHandler(this.txtLicenseNumber_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(220, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(220, 271);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(215, 22);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // labelDriverId
            // 
            this.labelDriverId.AutoSize = true;
            this.labelDriverId.Location = new System.Drawing.Point(74, 27);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(62, 16);
            this.labelDriverId.TabIndex = 6;
            this.labelDriverId.Text = "Driver ID:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(74, 74);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 16);
            this.labelFirstName.TabIndex = 7;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(74, 122);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 16);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelLicenseNumber
            // 
            this.labelLicenseNumber.AutoSize = true;
            this.labelLicenseNumber.Location = new System.Drawing.Point(74, 171);
            this.labelLicenseNumber.Name = "labelLicenseNumber";
            this.labelLicenseNumber.Size = new System.Drawing.Size(108, 16);
            this.labelLicenseNumber.TabIndex = 9;
            this.labelLicenseNumber.Text = "License Number:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(74, 222);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 16);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(74, 274);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(100, 16);
            this.labelPhoneNumber.TabIndex = 11;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(77, 343);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(75, 23);
            this.btnAddDriver.TabIndex = 12;
            this.btnAddDriver.Text = "Add";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.Location = new System.Drawing.Point(220, 343);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDriver.TabIndex = 13;
            this.btnUpdateDriver.Text = "Update";
            this.btnUpdateDriver.UseVisualStyleBackColor = true;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(360, 343);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDriver.TabIndex = 14;
            this.btnDeleteDriver.Text = "Delete";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(569, 24);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.RowHeadersWidth = 51;
            this.dgvDrivers.RowTemplate.Height = 24;
            this.dgvDrivers.Size = new System.Drawing.Size(737, 342);
            this.dgvDrivers.TabIndex = 15;
            this.dgvDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1231, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // epLicenseNumber
            // 
            this.epLicenseNumber.ContainerControl = this;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1332, 497);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.btnDeleteDriver);
            this.Controls.Add(this.btnUpdateDriver);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLicenseNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLicenseNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtDriverId);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "DriverForm";
            this.Text = "Manage Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLicenseNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDriverId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelLicenseNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epLicenseNumber;
    }
}