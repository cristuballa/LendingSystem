namespace LendingSystem.UI
{
    partial class LoanUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanUi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmountOfLoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTermsOfPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBorrower = new System.Windows.Forms.TextBox();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.cmdChange = new System.Windows.Forms.Button();
            this.cboCalendarRate = new System.Windows.Forms.ComboBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbNewPayment = new System.Windows.Forms.ToolStripButton();
            this.tsbNewCharge = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbNewPayment,
            this.tsbNewCharge});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 28);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 53;
            this.label10.Text = "Loan ID";
            // 
            // txtLoanId
            // 
            this.txtLoanId.Enabled = false;
            this.txtLoanId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanId.Location = new System.Drawing.Point(178, 57);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.Size = new System.Drawing.Size(334, 29);
            this.txtLoanId.TabIndex = 52;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(178, 121);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(334, 29);
            this.dtpStartDate.TabIndex = 46;
            this.dtpStartDate.Value = new System.DateTime(2017, 6, 23, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "Principal";
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfLoan.Location = new System.Drawing.Point(179, 221);
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(334, 29);
            this.txtAmountOfLoan.TabIndex = 44;
            this.txtAmountOfLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountOfLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfLoan_KeyPress);
            this.txtAmountOfLoan.Leave += new System.EventHandler(this.txtAmountOfLoan_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Reference";
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(178, 352);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(334, 29);
            this.txtReference.TabIndex = 42;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(178, 288);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(334, 58);
            this.txtRemark.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Remark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Interest Rate ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Terms Of Payment";
            // 
            // txtTermsOfPayment
            // 
            this.txtTermsOfPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermsOfPayment.Location = new System.Drawing.Point(178, 155);
            this.txtTermsOfPayment.Name = "txtTermsOfPayment";
            this.txtTermsOfPayment.Size = new System.Drawing.Size(334, 29);
            this.txtTermsOfPayment.TabIndex = 33;
            this.txtTermsOfPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTermsOfPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTermsOfPayment_KeyPress);
            this.txtTermsOfPayment.Leave += new System.EventHandler(this.txtTermsOfPayment_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Date Start";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(178, 187);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(165, 29);
            this.txtInterestRate.TabIndex = 31;
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            this.txtInterestRate.Leave += new System.EventHandler(this.txtInterestRate_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Borrower";
            // 
            // txtBorrower
            // 
            this.txtBorrower.Enabled = false;
            this.txtBorrower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrower.Location = new System.Drawing.Point(238, 89);
            this.txtBorrower.Name = "txtBorrower";
            this.txtBorrower.Size = new System.Drawing.Size(274, 29);
            this.txtBorrower.TabIndex = 60;
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.Enabled = false;
            this.txtBorrowerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowerId.Location = new System.Drawing.Point(178, 89);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.Size = new System.Drawing.Size(61, 29);
            this.txtBorrowerId.TabIndex = 61;
            // 
            // cmdChange
            // 
            this.cmdChange.Location = new System.Drawing.Point(513, 88);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(28, 28);
            this.cmdChange.TabIndex = 62;
            this.cmdChange.Text = "...";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // cboCalendarRate
            // 
            this.cboCalendarRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalendarRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCalendarRate.FormattingEnabled = true;
            this.cboCalendarRate.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cboCalendarRate.Location = new System.Drawing.Point(340, 187);
            this.cboCalendarRate.Name = "cboCalendarRate";
            this.cboCalendarRate.Size = new System.Drawing.Size(172, 29);
            this.cboCalendarRate.TabIndex = 63;
            this.cboCalendarRate.SelectedIndexChanged += new System.EventHandler(this.cboCalendarRate_SelectedIndexChanged);
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(16, 255);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(41, 21);
            this.lblDue.TabIndex = 65;
            this.lblDue.Text = "Due";
            this.lblDue.Visible = false;
            // 
            // txtDue
            // 
            this.txtDue.Enabled = false;
            this.txtDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDue.Location = new System.Drawing.Point(178, 253);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(334, 29);
            this.txtDue.TabIndex = 64;
            this.txtDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDue.Visible = false;
            this.txtDue.TextChanged += new System.EventHandler(this.txtDue_TextChanged);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(51, 25);
            this.tsbSave.Text = "Save ";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbNewPayment
            // 
            this.tsbNewPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewPayment.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPayment.Image")));
            this.tsbNewPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPayment.Name = "tsbNewPayment";
            this.tsbNewPayment.Size = new System.Drawing.Size(110, 25);
            this.tsbNewPayment.Text = "New Payment";
            this.tsbNewPayment.Click += new System.EventHandler(this.tsbNewPayment_Click);
            // 
            // tsbNewCharge
            // 
            this.tsbNewCharge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewCharge.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCharge.Image")));
            this.tsbNewCharge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCharge.Name = "tsbNewCharge";
            this.tsbNewCharge.Size = new System.Drawing.Size(100, 25);
            this.tsbNewCharge.Text = "New Charge";
            this.tsbNewCharge.Click += new System.EventHandler(this.tsbNewCharge_Click);
            // 
            // LoanUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 438);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.cboCalendarRate);
            this.Controls.Add(this.cmdChange);
            this.Controls.Add(this.txtBorrowerId);
            this.Controls.Add(this.txtBorrower);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLoanId);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAmountOfLoan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTermsOfPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterestRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoanUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmountOfLoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTermsOfPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterestRate;

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBorrower;
        public System.Windows.Forms.TextBox txtBorrowerId;
        private System.Windows.Forms.Button cmdChange;
        private System.Windows.Forms.ComboBox cboCalendarRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNewPayment;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.ToolStripButton tsbNewCharge;
    }
}