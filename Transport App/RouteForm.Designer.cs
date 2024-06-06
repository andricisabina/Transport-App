namespace Transport_App
{
    partial class RouteForm
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
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnUpdateRoute = new System.Windows.Forms.Button();
            this.btnDeleteRoute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(211, 139);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(100, 22);
            this.tbDistance.TabIndex = 3;
            this.tbDistance.TextChanged += new System.EventHandler(this.tbDistance_TextChanged);
            this.tbDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDistance_KeyPress);
            this.tbDistance.Validating += new System.ComponentModel.CancelEventHandler(this.tbDistance_Validating);
            this.tbDistance.Validated += new System.EventHandler(this.tbDistance_TextChanged);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(211, 88);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(190, 22);
            this.tbDestination.TabIndex = 2;
            this.tbDestination.TextChanged += new System.EventHandler(this.tbDestination_TextChanged);
            // 
            // tbOrigin
            // 
            this.tbOrigin.Location = new System.Drawing.Point(211, 37);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(190, 22);
            this.tbOrigin.TabIndex = 1;
            this.tbOrigin.TextChanged += new System.EventHandler(this.tbOrigin_TextChanged);
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(83, 40);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(99, 16);
            this.labelOrigin.TabIndex = 5;
            this.labelOrigin.Text = "Origin Location:";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(83, 91);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(77, 16);
            this.labelDestination.TabIndex = 6;
            this.labelDestination.Text = "Destination:";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(83, 142);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(63, 16);
            this.labelDistance.TabIndex = 7;
            this.labelDistance.Text = "Distance:";
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(86, 218);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoute.TabIndex = 8;
            this.btnAddRoute.Text = "Add";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnUpdateRoute
            // 
            this.btnUpdateRoute.Location = new System.Drawing.Point(211, 218);
            this.btnUpdateRoute.Name = "btnUpdateRoute";
            this.btnUpdateRoute.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRoute.TabIndex = 9;
            this.btnUpdateRoute.Text = "Update";
            this.btnUpdateRoute.UseVisualStyleBackColor = true;
            this.btnUpdateRoute.Click += new System.EventHandler(this.btnUpdateRoute_Click);
            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.Location = new System.Drawing.Point(326, 218);
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRoute.TabIndex = 10;
            this.btnDeleteRoute.Text = "Delete";
            this.btnDeleteRoute.UseVisualStyleBackColor = true;
            this.btnDeleteRoute.Click += new System.EventHandler(this.btnDeleteRoute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(613, 664);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Location = new System.Drawing.Point(31, 291);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.RowHeadersWidth = 51;
            this.dgvRoutes.RowTemplate.Height = 24;
            this.dgvRoutes.Size = new System.Drawing.Size(657, 355);
            this.dgvRoutes.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.tbDistance_TextChanged);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(713, 699);
            this.Controls.Add(this.dgvRoutes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteRoute);
            this.Controls.Add(this.btnUpdateRoute);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.tbOrigin);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbDistance);
            this.Name = "RouteForm";
            this.Text = "Manage Routes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnUpdateRoute;
        private System.Windows.Forms.Button btnDeleteRoute;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}