namespace WattsALoan1
{
    partial class WattsALoan
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
            this.btnPayments = new System.Windows.Forms.Button();
            this.lblPayments = new System.Windows.Forms.Label();
            this.btnAllocations = new System.Windows.Forms.Button();
            this.lblAllocations = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(31, 43);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(38, 36);
            this.btnPayments.TabIndex = 0;
            this.btnPayments.Text = "...";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayments.Location = new System.Drawing.Point(85, 43);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(226, 36);
            this.lblPayments.TabIndex = 1;
            this.lblPayments.Text = "Loan Payments";
            this.lblPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnAllocations
            // 
            this.btnAllocations.Location = new System.Drawing.Point(31, 90);
            this.btnAllocations.Name = "btnAllocations";
            this.btnAllocations.Size = new System.Drawing.Size(38, 36);
            this.btnAllocations.TabIndex = 2;
            this.btnAllocations.Text = "...";
            this.btnAllocations.UseVisualStyleBackColor = true;
            this.btnAllocations.Click += new System.EventHandler(this.btnAllocations_Click);
            // 
            // lblAllocations
            // 
            this.lblAllocations.AutoSize = true;
            this.lblAllocations.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocations.Location = new System.Drawing.Point(85, 90);
            this.lblAllocations.Name = "lblAllocations";
            this.lblAllocations.Size = new System.Drawing.Size(244, 36);
            this.lblAllocations.TabIndex = 3;
            this.lblAllocations.Text = "\tLoan Allocations";
            this.lblAllocations.Click += new System.EventHandler(this.btnAllocations_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(31, 143);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(38, 36);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "...";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(85, 143);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(161, 36);
            this.lblCustomers.TabIndex = 5;
            this.lblCustomers.Text = "Customers";
            this.lblCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(31, 198);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(38, 36);
            this.btnEmployees.TabIndex = 6;
            this.btnEmployees.Text = "...";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(85, 198);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(166, 36);
            this.lblEmployees.TabIndex = 7;
            this.lblEmployees.Text = "Employees";
            this.lblEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(31, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(298, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WattsALoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 328);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.lblAllocations);
            this.Controls.Add(this.btnAllocations);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.btnPayments);
            this.Name = "WattsALoan";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Button btnAllocations;
        private System.Windows.Forms.Label lblAllocations;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button btnClose;
    }
}

