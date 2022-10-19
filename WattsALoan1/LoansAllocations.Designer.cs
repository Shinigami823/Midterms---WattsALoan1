namespace WattsALoan1
{
    partial class LoansAllocations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsLoansAllocations = new System.Data.DataSet();
            this.tblLoan = new System.Data.DataTable();
            this.colDateAllocated = new System.Data.DataColumn();
            this.colLoanNumber = new System.Data.DataColumn();
            this.colPreparedBy = new System.Data.DataColumn();
            this.colPreparedFor = new System.Data.DataColumn();
            this.colPrincipal = new System.Data.DataColumn();
            this.colInterestRate = new System.Data.DataColumn();
            this.colPeriods = new System.Data.DataColumn();
            this.colInterestEarned = new System.Data.DataColumn();
            this.colFutureValue = new System.Data.DataColumn();
            this.colMonthlyPayment = new System.Data.DataColumn();
            this.dsEmployees = new System.Data.DataSet();
            this.tblEmployee = new System.Data.DataTable();
            this.colEmployeeNumber = new System.Data.DataColumn();
            this.colFirstName = new System.Data.DataColumn();
            this.colLastName = new System.Data.DataColumn();
            this.colTitle = new System.Data.DataColumn();
            this.colHourlySalary = new System.Data.DataColumn();
            this.colEmployeeDetails = new System.Data.DataColumn();
            this.dsCustomers = new System.Data.DataSet();
            this.tblCustomer = new System.Data.DataTable();
            this.colAccountNumber = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.colEmailAddress = new System.Data.DataColumn();
            this.colPhoneNumber = new System.Data.DataColumn();
            this.colCustomerDetails = new System.Data.DataColumn();
            this.dvgLoanAllocations = new System.Windows.Forms.DataGridView();
            this.loanNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAllocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.principalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestEarnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futureValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoansAllocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLoanAllocations)).BeginInit();
            this.SuspendLayout();
            // 
            // dsLoansAllocations
            // 
            this.dsLoansAllocations.DataSetName = "LoansAllocations";
            this.dsLoansAllocations.Tables.AddRange(new System.Data.DataTable[] {
            this.tblLoan});
            // 
            // tblLoan
            // 
            this.tblLoan.Columns.AddRange(new System.Data.DataColumn[] {
            this.colDateAllocated,
            this.colLoanNumber,
            this.colPreparedBy,
            this.colPreparedFor,
            this.colPrincipal,
            this.colInterestRate,
            this.colPeriods,
            this.colInterestEarned,
            this.colFutureValue,
            this.colMonthlyPayment});
            this.tblLoan.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "LoanNumber"}, false)});
            this.tblLoan.TableName = "Loan";
            // 
            // colDateAllocated
            // 
            this.colDateAllocated.AllowDBNull = false;
            this.colDateAllocated.ColumnName = "DateAllocated";
            this.colDateAllocated.DataType = typeof(System.DateTime);
            // 
            // colLoanNumber
            // 
            this.colLoanNumber.AllowDBNull = false;
            this.colLoanNumber.ColumnName = "LoanNumber";
            this.colLoanNumber.DataType = typeof(int);
            // 
            // colPreparedBy
            // 
            this.colPreparedBy.ColumnName = "PreparedBy";
            // 
            // colPreparedFor
            // 
            this.colPreparedFor.ColumnName = "PreparedFor";
            // 
            // colPrincipal
            // 
            this.colPrincipal.ColumnName = "Principal";
            this.colPrincipal.DataType = typeof(double);
            // 
            // colInterestRate
            // 
            this.colInterestRate.ColumnName = "InterestRate";
            this.colInterestRate.DataType = typeof(double);
            this.colInterestRate.DefaultValue = 8.75D;
            this.colInterestRate.ReadOnly = true;
            // 
            // colPeriods
            // 
            this.colPeriods.ColumnName = "Periods";
            this.colPeriods.DataType = typeof(double);
            this.colPeriods.DefaultValue = 36D;
            // 
            // colInterestEarned
            // 
            this.colInterestEarned.ColumnName = "InterestEarned";
            this.colInterestEarned.DataType = typeof(double);
            this.colInterestEarned.Expression = "Principal * (InterestRate / 100) * (Periods / 12)";
            this.colInterestEarned.ReadOnly = true;
            // 
            // colFutureValue
            // 
            this.colFutureValue.ColumnName = "FutureValue";
            this.colFutureValue.DataType = typeof(double);
            this.colFutureValue.Expression = "Principal + InterestEarned";
            this.colFutureValue.ReadOnly = true;
            // 
            // colMonthlyPayment
            // 
            this.colMonthlyPayment.ColumnName = "MonthlyPayment";
            this.colMonthlyPayment.DataType = typeof(double);
            this.colMonthlyPayment.Expression = "FutureValue / Periods";
            this.colMonthlyPayment.ReadOnly = true;
            // 
            // dsEmployees
            // 
            this.dsEmployees.DataSetName = "Employees";
            this.dsEmployees.Tables.AddRange(new System.Data.DataTable[] {
            this.tblEmployee});
            // 
            // tblEmployee
            // 
            this.tblEmployee.Columns.AddRange(new System.Data.DataColumn[] {
            this.colEmployeeNumber,
            this.colFirstName,
            this.colLastName,
            this.colTitle,
            this.colHourlySalary,
            this.colEmployeeDetails});
            this.tblEmployee.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "EmployeeNumber"}, false)});
            this.tblEmployee.TableName = "Employee";
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.AllowDBNull = false;
            this.colEmployeeNumber.ColumnName = "EmployeeNumber";
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
            // colTitle
            // 
            this.colTitle.ColumnName = "Title";
            // 
            // colHourlySalary
            // 
            this.colHourlySalary.ColumnName = "HourlySalary";
            this.colHourlySalary.DataType = typeof(double);
            this.colHourlySalary.DefaultValue = 8.75D;
            // 
            // colEmployeeDetails
            // 
            this.colEmployeeDetails.ColumnName = "EmployeeDetails";
            this.colEmployeeDetails.Expression = "EmployeeNumber + \': \' +FirstName + \' \' + LastName";
            this.colEmployeeDetails.ReadOnly = true;
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
            this.dataColumn1,
            this.dataColumn2,
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
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "FirstName";
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.ColumnName = "LastName";
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
            // dvgLoanAllocations
            // 
            this.dvgLoanAllocations.AutoGenerateColumns = false;
            this.dvgLoanAllocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLoanAllocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanNumberDataGridViewTextBoxColumn,
            this.dateAllocatedDataGridViewTextBoxColumn,
            this.preparedByDataGridViewTextBoxColumn,
            this.principalDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn,
            this.periodsDataGridViewTextBoxColumn,
            this.interestEarnedDataGridViewTextBoxColumn,
            this.futureValueDataGridViewTextBoxColumn,
            this.monthlyPaymentDataGridViewTextBoxColumn});
            this.dvgLoanAllocations.DataMember = "Loan";
            this.dvgLoanAllocations.DataSource = this.dsLoansAllocations;
            this.dvgLoanAllocations.Location = new System.Drawing.Point(12, 12);
            this.dvgLoanAllocations.Name = "dvgLoanAllocations";
            this.dvgLoanAllocations.Size = new System.Drawing.Size(952, 319);
            this.dvgLoanAllocations.TabIndex = 0;
            // 
            // loanNumberDataGridViewTextBoxColumn
            // 
            this.loanNumberDataGridViewTextBoxColumn.DataPropertyName = "LoanNumber";
            this.loanNumberDataGridViewTextBoxColumn.HeaderText = "Loan #";
            this.loanNumberDataGridViewTextBoxColumn.Name = "loanNumberDataGridViewTextBoxColumn";
            this.loanNumberDataGridViewTextBoxColumn.Width = 60;
            // 
            // dateAllocatedDataGridViewTextBoxColumn
            // 
            this.dateAllocatedDataGridViewTextBoxColumn.DataPropertyName = "DateAllocated";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateAllocatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateAllocatedDataGridViewTextBoxColumn.HeaderText = "Date Allocated";
            this.dateAllocatedDataGridViewTextBoxColumn.Name = "dateAllocatedDataGridViewTextBoxColumn";
            this.dateAllocatedDataGridViewTextBoxColumn.Width = 85;
            // 
            // preparedByDataGridViewTextBoxColumn
            // 
            this.preparedByDataGridViewTextBoxColumn.DataPropertyName = "PreparedBy";
            this.preparedByDataGridViewTextBoxColumn.DataSource = this.dsEmployees;
            this.preparedByDataGridViewTextBoxColumn.DisplayMember = "Employee.EmployeeDetails";
            this.preparedByDataGridViewTextBoxColumn.HeaderText = "Prepared By";
            this.preparedByDataGridViewTextBoxColumn.Name = "preparedByDataGridViewTextBoxColumn";
            this.preparedByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.preparedByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.preparedByDataGridViewTextBoxColumn.Width = 165;
            // 
            // principalDataGridViewTextBoxColumn
            // 
            this.principalDataGridViewTextBoxColumn.DataPropertyName = "Principal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.principalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.principalDataGridViewTextBoxColumn.HeaderText = "Principal";
            this.principalDataGridViewTextBoxColumn.Name = "principalDataGridViewTextBoxColumn";
            this.principalDataGridViewTextBoxColumn.Width = 65;
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.interestRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.interestRateDataGridViewTextBoxColumn.HeaderText = "Rate (%)";
            this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            this.interestRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestRateDataGridViewTextBoxColumn.Width = 55;
            // 
            // periodsDataGridViewTextBoxColumn
            // 
            this.periodsDataGridViewTextBoxColumn.DataPropertyName = "Periods";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.periodsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.periodsDataGridViewTextBoxColumn.HeaderText = "Prd (Months)";
            this.periodsDataGridViewTextBoxColumn.Name = "periodsDataGridViewTextBoxColumn";
            this.periodsDataGridViewTextBoxColumn.Width = 75;
            // 
            // interestEarnedDataGridViewTextBoxColumn
            // 
            this.interestEarnedDataGridViewTextBoxColumn.DataPropertyName = "InterestEarned";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.interestEarnedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.interestEarnedDataGridViewTextBoxColumn.HeaderText = "Interest Earned";
            this.interestEarnedDataGridViewTextBoxColumn.Name = "interestEarnedDataGridViewTextBoxColumn";
            this.interestEarnedDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestEarnedDataGridViewTextBoxColumn.Width = 85;
            // 
            // futureValueDataGridViewTextBoxColumn
            // 
            this.futureValueDataGridViewTextBoxColumn.DataPropertyName = "FutureValue";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.futureValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.futureValueDataGridViewTextBoxColumn.HeaderText = "Future Value";
            this.futureValueDataGridViewTextBoxColumn.Name = "futureValueDataGridViewTextBoxColumn";
            this.futureValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.futureValueDataGridViewTextBoxColumn.Width = 75;
            // 
            // monthlyPaymentDataGridViewTextBoxColumn
            // 
            this.monthlyPaymentDataGridViewTextBoxColumn.DataPropertyName = "MonthlyPayment";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.monthlyPaymentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.monthlyPaymentDataGridViewTextBoxColumn.HeaderText = "Pmt/Month";
            this.monthlyPaymentDataGridViewTextBoxColumn.Name = "monthlyPaymentDataGridViewTextBoxColumn";
            this.monthlyPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthlyPaymentDataGridViewTextBoxColumn.Width = 70;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(889, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoansAllocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvgLoanAllocations);
            this.Name = "LoansAllocations";
            this.Text = "Watts A Loan - LoansAllocations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoansAllocations_FormClosing);
            this.Load += new System.EventHandler(this.LoansAllocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLoansAllocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLoanAllocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsLoansAllocations;
        private System.Data.DataTable tblLoan;
        private System.Data.DataColumn colDateAllocated;
        private System.Data.DataColumn colLoanNumber;
        private System.Data.DataColumn colPreparedBy;
        private System.Data.DataColumn colPreparedFor;
        private System.Data.DataColumn colPrincipal;
        private System.Data.DataColumn colInterestRate;
        private System.Data.DataColumn colPeriods;
        private System.Data.DataColumn colInterestEarned;
        private System.Data.DataColumn colFutureValue;
        private System.Data.DataColumn colMonthlyPayment;
        private System.Data.DataSet dsEmployees;
        private System.Data.DataTable tblEmployee;
        private System.Data.DataColumn colEmployeeNumber;
        private System.Data.DataColumn colFirstName;
        private System.Data.DataColumn colLastName;
        private System.Data.DataColumn colTitle;
        private System.Data.DataColumn colHourlySalary;
        private System.Data.DataColumn colEmployeeDetails;
        private System.Data.DataSet dsCustomers;
        private System.Data.DataTable tblCustomer;
        private System.Data.DataColumn colAccountNumber;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn colEmailAddress;
        private System.Data.DataColumn colPhoneNumber;
        private System.Data.DataColumn colCustomerDetails;
        private System.Windows.Forms.DataGridView dvgLoanAllocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAllocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn preparedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn preparedForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestEarnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn futureValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}