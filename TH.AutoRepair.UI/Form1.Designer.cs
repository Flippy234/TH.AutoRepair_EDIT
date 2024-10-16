namespace TH.AutoRepair.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.Location = new System.Drawing.Point(118, 171);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(141, 53);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(12, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(159, 18);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 33);
            this.txtFirstName.TabIndex = 2;
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 25;
            this.lstCustomers.Location = new System.Drawing.Point(276, 13);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(147, 304);
            this.lstCustomers.TabIndex = 3;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.Location = new System.Drawing.Point(159, 111);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 33);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 111);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(140, 25);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(159, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 33);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(13, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 25);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModel.Location = new System.Drawing.Point(609, 64);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 33);
            this.txtModel.TabIndex = 15;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(463, 64);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(66, 25);
            this.lblModel.TabIndex = 14;
            this.lblModel.Text = "Model";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.Location = new System.Drawing.Point(609, 111);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 33);
            this.txtYear.TabIndex = 13;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(463, 111);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(48, 25);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year";
            // 
            // lstVehicles
            // 
            this.lstVehicles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.ItemHeight = 25;
            this.lstVehicles.Location = new System.Drawing.Point(726, 13);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(147, 304);
            this.lstVehicles.TabIndex = 11;
            this.lstVehicles.SelectedIndexChanged += new System.EventHandler(this.lstVehicles_SelectedIndexChanged);
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMake.Location = new System.Drawing.Point(609, 18);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 33);
            this.txtMake.TabIndex = 10;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMake.Location = new System.Drawing.Point(462, 21);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(58, 25);
            this.lblMake.TabIndex = 9;
            this.lblMake.Text = "Make";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddVehicle.Location = new System.Drawing.Point(568, 171);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(141, 53);
            this.btnAddVehicle.TabIndex = 8;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 394);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lstVehicles);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddCustomer;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private ListBox lstCustomers;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtModel;
        private Label lblModel;
        private TextBox txtYear;
        private Label lblYear;
        private ListBox lstVehicles;
        private TextBox txtMake;
        private Label lblMake;
        private Button btnAddVehicle;
    }
}