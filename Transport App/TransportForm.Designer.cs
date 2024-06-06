namespace Transport_App
{
    partial class TransportForm
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
            this.cmbDriverId = new System.Windows.Forms.ComboBox();
            this.cmbRouteId = new System.Windows.Forms.ComboBox();
            this.dtpTransportDate = new System.Windows.Forms.DateTimePicker();
            this.txtLoadDetails = new System.Windows.Forms.TextBox();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.labelRouteID = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.btnAddTransport = new System.Windows.Forms.Button();
            this.btnUpdateTransport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTransports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransports)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDriverId
            // 
            this.cmbDriverId.FormattingEnabled = true;
            this.cmbDriverId.Location = new System.Drawing.Point(178, 35);
            this.cmbDriverId.Name = "cmbDriverId";
            this.cmbDriverId.Size = new System.Drawing.Size(121, 24);
            this.cmbDriverId.TabIndex = 0;
            this.cmbDriverId.SelectedIndexChanged += new System.EventHandler(this.cmbDriverId_SelectedIndexChanged);
            // 
            // cmbRouteId
            // 
            this.cmbRouteId.FormattingEnabled = true;
            this.cmbRouteId.Location = new System.Drawing.Point(178, 85);
            this.cmbRouteId.Name = "cmbRouteId";
            this.cmbRouteId.Size = new System.Drawing.Size(121, 24);
            this.cmbRouteId.TabIndex = 1;
            this.cmbRouteId.SelectedIndexChanged += new System.EventHandler(this.cmbRouteId_SelectedIndexChanged);
            // 
            // dtpTransportDate
            // 
            this.dtpTransportDate.Location = new System.Drawing.Point(178, 135);
            this.dtpTransportDate.Name = "dtpTransportDate";
            this.dtpTransportDate.Size = new System.Drawing.Size(200, 22);
            this.dtpTransportDate.TabIndex = 2;
            this.dtpTransportDate.ValueChanged += new System.EventHandler(this.dtpTransportDate_ValueChanged);
            this.dtpTransportDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpTransportDate_Validating);
            this.dtpTransportDate.Validated += new System.EventHandler(this.dtpTransportDate_ValueChanged);
            // 
            // txtLoadDetails
            // 
            this.txtLoadDetails.Location = new System.Drawing.Point(178, 180);
            this.txtLoadDetails.Name = "txtLoadDetails";
            this.txtLoadDetails.Size = new System.Drawing.Size(200, 22);
            this.txtLoadDetails.TabIndex = 3;
            this.txtLoadDetails.TextChanged += new System.EventHandler(this.txtLoadDetails_TextChanged);
            this.txtLoadDetails.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoadDetails_Validating);
            this.txtLoadDetails.Validated += new System.EventHandler(this.txtLoadDetails_TextChanged);
            // 
            // labelDriverId
            // 
            this.labelDriverId.AutoSize = true;
            this.labelDriverId.Location = new System.Drawing.Point(48, 38);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(62, 16);
            this.labelDriverId.TabIndex = 4;
            this.labelDriverId.Text = "Driver ID:";
            // 
            // labelRouteID
            // 
            this.labelRouteID.AutoSize = true;
            this.labelRouteID.Location = new System.Drawing.Point(48, 88);
            this.labelRouteID.Name = "labelRouteID";
            this.labelRouteID.Size = new System.Drawing.Size(62, 16);
            this.labelRouteID.TabIndex = 5;
            this.labelRouteID.Text = "Route ID:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(48, 140);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(97, 16);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Transport Date";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(48, 186);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(86, 16);
            this.labelDetails.TabIndex = 7;
            this.labelDetails.Text = "Load Details:";
            // 
            // btnAddTransport
            // 
            this.btnAddTransport.Location = new System.Drawing.Point(51, 248);
            this.btnAddTransport.Name = "btnAddTransport";
            this.btnAddTransport.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransport.TabIndex = 8;
            this.btnAddTransport.Text = "Add";
            this.btnAddTransport.UseVisualStyleBackColor = true;
            this.btnAddTransport.Click += new System.EventHandler(this.btnAddTransport_Click);
            // 
            // btnUpdateTransport
            // 
            this.btnUpdateTransport.Location = new System.Drawing.Point(178, 248);
            this.btnUpdateTransport.Name = "btnUpdateTransport";
            this.btnUpdateTransport.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTransport.TabIndex = 9;
            this.btnUpdateTransport.Text = "Update";
            this.btnUpdateTransport.UseVisualStyleBackColor = true;
            this.btnUpdateTransport.Click += new System.EventHandler(this.btnUpdateTransport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(465, 697);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(303, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTransports
            // 
            this.dgvTransports.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvTransports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransports.GridColor = System.Drawing.Color.Gray;
            this.dgvTransports.Location = new System.Drawing.Point(51, 307);
            this.dgvTransports.Name = "dgvTransports";
            this.dgvTransports.RowHeadersWidth = 51;
            this.dgvTransports.RowTemplate.Height = 24;
            this.dgvTransports.Size = new System.Drawing.Size(467, 348);
            this.dgvTransports.TabIndex = 12;
            this.dgvTransports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(564, 743);
            this.Controls.Add(this.dgvTransports);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateTransport);
            this.Controls.Add(this.btnAddTransport);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelRouteID);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.txtLoadDetails);
            this.Controls.Add(this.dtpTransportDate);
            this.Controls.Add(this.cmbRouteId);
            this.Controls.Add(this.cmbDriverId);
            this.Name = "TransportForm";
            this.Text = "TransportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDriverId;
        private System.Windows.Forms.ComboBox cmbRouteId;
        private System.Windows.Forms.DateTimePicker dtpTransportDate;
        private System.Windows.Forms.TextBox txtLoadDetails;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Label labelRouteID;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Button btnAddTransport;
        private System.Windows.Forms.Button btnUpdateTransport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTransports;
    }
}