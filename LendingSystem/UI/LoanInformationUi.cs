using System;
using System.Drawing;
using System.Windows.Forms;
using LendingSystem.Persistence;

namespace LendingSystem.UI
{
    public partial class LoanInformationUi : Form
    {

         public LoanInformationUi()
        {
            InitializeComponent();
            BorrowerList(txtFind.Text);
        }

        private void BorrowerList(string keyword)
        {

            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {

                dgvBorrowers.Columns.Clear();
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N2";

                var loans = unitOfWork.Borrowers.GetBorrowersList(keyword);
                dgvBorrowers.AutoGenerateColumns = false;
                

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();

                column1.DataPropertyName = "BorrowerId";
                column1.Name = "Id";
                column1.FillWeight = 15; 
                column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                dgvBorrowers.Columns.Add(column1);


                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "FirstName";
                column2.Name = "Borrower";
                column2.FillWeight = 65; 
                column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvBorrowers.Columns.Add(column2);

                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "Balance";
                column3.Name = "Balance";
                column3.FillWeight =30;
                column3.DefaultCellStyle = style;
                column3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvBorrowers.Columns.Add(column3);


                dgvBorrowers.GridColor = Color.Ivory;
                dgvBorrowers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvBorrowers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBorrowers.DataSource = loans;

               // dgvBorrowers.Rows.Add("", "Total:", 0);

            } 

        }



        private void tsbNewBorrower_Click(object sender, EventArgs e)
        {
            try
            {
                var borrower = new BorrowerUI();
                borrower.Show();
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tsbNewLoan_Click(object sender, EventArgs e)
        {
            try
            {
                var loan = new LoanUi();
                Int64 id = Convert.ToInt64(dgvBorrowers.SelectedRows[0].Cells["Id"].Value.ToString()); 
                loan.txtBorrowerId.Text = id.ToString();
                loan.txtBorrower.Text = dgvBorrowers.SelectedRows[0].Cells["Borrower"].Value.ToString(); 
                loan.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowerList(txtFind.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void dgvLoans_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Int64 id = Convert.ToInt64(dgvLoans.SelectedRows[0].Cells["Loan Id"].Value.ToString());
            var loan=new LoanUi();
            loan.GetLoan(id);
            loan.Show();
        }


        private void txtEditBorrower_Click(object sender, EventArgs e)
        {

        }


        private void LoanListShow(Int64 id)
        {

            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
                dgvLoans.DataSource = null;
                dgvLoans.AutoGenerateColumns = false;

                dgvLoans.Columns.Clear();
                dgvLoans.Rows.Clear();
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N2";
                DataGridViewCellStyle style2 = new DataGridViewCellStyle();
                style2.Format = "P2";
                var loans = unitOfWork.Loans.GetBorrowerLoanList(id);
                
                dgvLoans.DataSource = loans;


                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "LoanId";
                column1.Name = "Loan Id";
                column1.FillWeight = 10;
                column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLoans.Columns.Add(column1);


                //DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                //column2.DataPropertyName = "FullName";
                //column2.Name = "Name";
                //column2.FillWeight = 20;
                //column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                //dgvLoans.Columns.Add(column2);


                DataGridViewColumn column8 = new DataGridViewTextBoxColumn();
                column8.DataPropertyName = "DateStart";
                column8.Name = "Date Start";
                column8.FillWeight = 15;
                column8.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLoans.Columns.Add(column8);


                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "LoanAmount";
                column3.Name = "Principal";
                column3.FillWeight = 15;
;
                column3.DefaultCellStyle = style;
                column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                dgvLoans.Columns.Add(column3);


                DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                column4.DataPropertyName = "TermsOfPayment";
                column4.Name = "Terms";
                column4.FillWeight = 10;
                column4.DefaultCellStyle = style;
                column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                dgvLoans.Columns.Add(column4);


                DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
                column5.DataPropertyName = "InterestRate";
                column5.Name = "% Rate";
                column5.FillWeight = 10;
                column5.DefaultCellStyle = style;
                column5.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                dgvLoans.Columns.Add(column5);

                DataGridViewColumn column9 = new DataGridViewTextBoxColumn();
                column9.DataPropertyName = "Amortization";
                column9.Name = "Amortization";
                column9.FillWeight = 15;
                column9.DefaultCellStyle = style;
                column9.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLoans.Columns.Add(column9);


                DataGridViewColumn column6 = new DataGridViewTextBoxColumn();
                column6.DataPropertyName = "CalendarRate";
                column6.Name = "Calendar Rate";
                column6.FillWeight = 15;
                column6.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLoans.Columns.Add(column6);


                DataGridViewColumn column7 = new DataGridViewTextBoxColumn();
                column7.DataPropertyName = "Remark";
                column7.Name = "Remark";
                column7.FillWeight = 25;
                column7.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLoans.Columns.Add(column7);

                DataGridViewColumn column10 = new DataGridViewTextBoxColumn();
                column10.DataPropertyName = "Balance";
                column10.Name = "Balance";
                column10.FillWeight = 15;
                column10.DefaultCellStyle = style;
                column10.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLoans.Columns.Add(column10);

                dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLoans.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLoans.Refresh();

            }
        }

        private void PaymentListShow(Int64 id)
        {

            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
                dgvLedger.DataSource = null;
                dgvLedger.Columns.Clear();

                var payments = unitOfWork.LoanPayments.GetLedger(id);
                dgvLedger.AutoGenerateColumns = false;
                dgvLedger.DataSource = payments;

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();

                column1.DataPropertyName = "LoanPaymentId";
                column1.Name = "Id";
                column1.FillWeight = 8;
                column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column1);

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "DatePost";
                column2.Name = "Date Post";
                column2.FillWeight = 15;
                column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column2);



                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "Reference";
                column3.Name = "Reference";
                column3.FillWeight = 20;
                column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column3);

                DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                column4.DataPropertyName = "Remark";
                column4.Name = "Remark";
                column4.FillWeight  = 30;
                column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column4);

    
                DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
                column5.DataPropertyName = "AmountPaid";
                column5.Name = "Amount Paid";
                column5.FillWeight = 15;
                column5.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                dgvLedger.Columns.Add(column5);

                dgvLedger.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLedger.Refresh();


            }
        }


        private void LedgerShow(Int64 id)
        {

            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
                dgvLedger.DataSource = null;
                dgvLedger.Columns.Clear();

                var payments = unitOfWork.Ledgers.GetLoanLedger(id);
                dgvLedger.AutoGenerateColumns = false;
                dgvLedger.DataSource = payments;

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N2";

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();

                column1.DataPropertyName = "Id";
                column1.Name = "No";
                column1.FillWeight = 8;
                column1.Visible = false;
                column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column1);

                DataGridViewColumn column9 = new DataGridViewTextBoxColumn();
                column9.DataPropertyName = "rId";
                column9.Name = "Ref No.";
                column9.FillWeight = 8;
                column9.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column9);

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "DatePost";
                column2.Name = "Date Post";
                column2.FillWeight = 18;
                column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column2);

                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "Reference";
                column3.Name = "Reference";
                column3.FillWeight = 20;
                column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column3);

                DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                column4.DataPropertyName = "Remark";
                column4.Name = "Remark";
                column4.FillWeight = 30;
                column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.Columns.Add(column4);

                DataGridViewColumn column8 = new DataGridViewTextBoxColumn();
                column8.DataPropertyName = "TransType";
                column8.Name = "Type";
                column8.FillWeight = 15;
                column8.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvLedger.Columns.Add(column8);


                DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
                column5.DataPropertyName = "Debit";
                column5.Name = "Increase";
                column5.FillWeight = 15;
                column5.DefaultCellStyle = style;
                column5.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLedger.Columns.Add(column5);

                DataGridViewColumn column6 = new DataGridViewTextBoxColumn();
                column6.DataPropertyName = "Credit";
                column6.Name = "Decrease";
                column6.FillWeight = 15;
                column6.DefaultCellStyle = style;
                column6.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLedger.Columns.Add(column6);


                DataGridViewColumn column7 = new DataGridViewTextBoxColumn();
                column7.DataPropertyName = "Balance";
                column7.Name = "Balance";
                column7.FillWeight = 20;
                column7.DefaultCellStyle = style;
                column7.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                column7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLedger.Columns.Add(column7);



                dgvLedger.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLedger.Refresh();


            }
        }

        private void dgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoans.SelectedRows.Count>0)
            {
                Int64 id1 = Convert.ToInt64(dgvLoans.SelectedRows[0].Cells["Loan Id"].Value.ToString());
                LedgerShow(id1);

            }

        }

        private void tsbNewPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var payment = new LoanPaymentUi();
                Int64 id = Convert.ToInt64(dgvLoans.SelectedRows[0].Cells["Loan Id"].Value.ToString());
                payment.txtLoanId.Text = id.ToString();
                payment.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvLedger_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           
            if(dgvLedger.SelectedRows[0].Cells["Type"].Value.ToString()=="Loan")
            {

                Int64 id = Convert.ToInt64(dgvLedger.SelectedRows[0].Cells["Ref No."].Value.ToString());
                var loan = new LoanUi();
                loan.GetLoan(id);
                loan.Show();
            }

            if (dgvLedger.SelectedRows[0].Cells["Type"].Value.ToString() == "Payment")
            {

                Int64 id = Convert.ToInt64(dgvLedger.SelectedRows[0].Cells["Ref No."].Value.ToString());
                var payment = new LoanPaymentUi();
                payment.GetPayment(id);
                payment.Show();
            }
            if (dgvLedger.SelectedRows[0].Cells["Type"].Value.ToString() == "Charges")
            {
                Int64 id = Convert.ToInt64(dgvLedger.SelectedRows[0].Cells["Ref No."].Value.ToString());
                var charges = new LoanChargeUi();
                charges.GetCharge(id);
                charges.Show();

            }



        }

        private void dgvBorrowers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((e.RowIndex%2)>0)
                dgvBorrowers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Ivory;
            else
                dgvBorrowers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkSeaGreen;

        }

        private void dgvLoans_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((e.RowIndex % 2) > 0)
                dgvLoans.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            else
                dgvLoans.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;

        }

        private void dgvLedger_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((e.RowIndex % 2) > 0)
                dgvLedger.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            else
                dgvLedger.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;  
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            BorrowerList(txtFind.Text);
        }

        private void dgvBorrowers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (dgvBorrowers.SelectedRows.Count > 0)
                {
                    Int64 id = Convert.ToInt64(dgvBorrowers.SelectedRows[0].Cells["Id"].Value.ToString());
                    LoanListShow(id);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvBorrowers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var borrower = new BorrowerUI();
                Int64 id = Convert.ToInt64(dgvBorrowers.SelectedRows[0].Cells["Id"].Value.ToString());
                borrower.GetBorrower(id);
                borrower.Show();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void tsbNewCharge_Click(object sender, EventArgs e)
        {
            try
            {
                var charge = new LoanChargeUi();
                Int64 id = Convert.ToInt64(dgvLoans.SelectedRows[0].Cells["Loan Id"].Value.ToString());
                charge.txtLoanId.Text = id.ToString();
                charge.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Enter))
                BorrowerList(txtFind.Text);

        }


        private void dgvLedger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         

            if (dgvLedger.Columns[e.ColumnIndex].DataPropertyName == "Debit")
            {
                Double value = Convert.ToDouble(e.Value);

                if (value == 0)
                {
                    e.Value = string.Empty;
                    e.FormattingApplied = true;
                }


            }

            if (dgvLedger.Columns[e.ColumnIndex].DataPropertyName == "Credit")
            {
                Double value = Convert.ToDouble(e.Value);
                if (value == 0)
                {
                    e.Value = string.Empty;
                    e.FormattingApplied = true;
                }
            }
        }



        private void tsmScheduleOfPayment_Click(object sender, EventArgs e)
        {
          
            try
            {
               var id = Convert.ToInt64(dgvLoans.SelectedRows[0].Cells["Loan Id"].Value.ToString());
               var c = new ReportViewer();
                    c.ScheduleOfPayment(id, true);
                    c.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tsmLedger_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt64(dgvLoans.SelectedRows[0].Cells["Loan Id"].Value.ToString());
                var c = new ReportViewer();

                c.LedgerPrint(id, true);
                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void tsmAgingByOffice_Click(object sender, EventArgs e)
        {
            try
            {

                var c = new ReportViewer();

                c.AgingOfReceivableByOffice(true);

                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tsmAgingOfReceivable_Click(object sender, EventArgs e)
        {
            try
            {

                var c = new ReportViewer();

                c.AgingOfReceivable(DateTime.Today, true);

                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tsmTodaysCollectible_Click(object sender, EventArgs e)
        {
            try
            {

                var c = new ReportViewer();

                c.AgingOfReceivableToday( true);

                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tsbPayments_Click(object sender, EventArgs e)
        {

           try
           {

               var p = new PaymentList();
               p.Show();

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message.ToString());
           }

        }

        private void dgvLedger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






    }


}
