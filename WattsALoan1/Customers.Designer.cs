namespace WattsALoan1
{
    partial class Customers
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
            this.dsCustomers = new System.Data.DataSet();
            this.tblCustomer = new System.Data.DataTable();
            this.colAccountNumber = new System.Data.DataColumn();
            this.colFirstName = new System.Data.DataColumn();
            this.colLastName = new System.Data.DataColumn();
            this.colEmailAddress = new System.Data.DataColumn();
            this.colPhoneNumber = new System.Data.DataColumn();
            this.colCustomerDetails = new System.Data.DataColumn();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCustomers
            // 
            this.dsCustomers.DataSetName = "Customers";
            this.dsCustomers.Tables.AddRange(new System.Data.DataTable[] {
            this.tblCustomer});
            // 
            // tblCustomer
            // 
            this.tblCustomer.Columns.AddRange(new System.Data.DataColumn[] {
            this.colAccountNumber,
            this.colFirstName,
            this.colLastName,
            this.colEmailAddress,
            this.colPhoneNumber,
            this.colCustomerDetails});
            this.tblCustomer.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "AccountNumber"}, false)});
            this.tblCustomer.TableName = "Customer";
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.AllowDBNull = false;
            this.colAccountNumber.ColumnName = "AccountNumber";
            // 
            // colFirstName
            // 
            this.colFirstName.ColumnName = "FirstName";
            // 
            // colLastName
            // 
            this.colLastName.AllowDBNull = false;
            this.colLastName.ColumnName = "LastName";
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.ColumnName = "EmailAddress";
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.ColumnName = "PhoneNumber";
            // 
            // colCustomerDetails
            // 
            this.colCustomerDetails.ColumnName = "CustomerDetails";
            this.colCustomerDetails.Expression = "AccountNumber + \': \' + FirstName + \' \' + LastName";
            this.colCustomerDetails.ReadOnly = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.customerDetailsDataGridViewTextBoxColumn});
            this.dgvCustomers.DataMember = "Customer";
            this.dgvCustomers.DataSource = this.dsCustomers;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(593, 257);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(530, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account #";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.Width = 65;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 65;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone #";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 90;
            // 
            // customerDetailsDataGridViewTextBoxColumn
            // 
            this.customerDetailsDataGridViewTextBoxColumn.DataPropertyName = "CustomerDetails";
            this.customerDetailsDataGridViewTextBoxColumn.HeaderText = "Customer Details";
            this.customerDetailsDataGridViewTextBoxColumn.Name = "customerDetailsDataGridViewTextBoxColumn";
            this.customerDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDetailsDataGridViewTextBoxColumn.Width = 150;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 307);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Customers";
            this.Text = "Watts a Loan - Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customers_FormClosing);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsCustomers;
        private System.Data.DataTable tblCustomer;
        private System.Data.DataColumn colAccountNumber;
        private System.Data.DataColumn colFirstName;
        private System.Data.DataColumn colLastName;
        private System.Data.DataColumn colEmailAddress;
        private System.Data.DataColumn colPhoneNumber;
        private System.Data.DataColumn colCustomerDetails;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}