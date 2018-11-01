using System;
using System.Globalization;
using System.Windows.Forms;
using LendingSystem.Core.Domain;
using LendingSystem.Persistence;

namespace LendingSystem.UI
{
    public partial class LoanUi : Form
    {
        public LoanUi()
        {
            InitializeComponent();
            cboCalendarRate.SelectedIndex = (int)CalendarRate.Monthly;
            dtpStartDate.Value = DateTime.Now;

        }




        private void Save()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                { 
                    var loan = new Loan
                    {
                        BorrowerId = Convert.ToInt64(txtBorrowerId.Text),
                        DateStart =dtpStartDate.Value,
                        TermsOfPayment = float.Parse(txtTermsOfPayment.Text, CultureInfo.InvariantCulture.NumberFormat),
                        InterestRate =float.Parse(txtInterestRate.Text, CultureInfo.InvariantCulture.NumberFormat),
                        CalendarRate  =(CalendarRate)cboCalendarRate.SelectedIndex,
                        LoanAmount = float.Parse(txtAmountOfLoan.Text, CultureInfo.InvariantCulture.NumberFormat),
                        Remark = txtRemark.Text,
                        Reference = txtReference.Text
                    };
            
                    unitOfWork.Loans.Add(loan);
                    unitOfWork.Complete();
                    txtLoanId.Text = loan.LoanId.ToString();
                    MessageBox.Show("Save Successfull");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Update(Int64 loanId)
        {
            try
            {              
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var loan = unitOfWork.Loans.Get(loanId);
                    
                    loan.BorrowerId = Convert.ToInt64(txtBorrowerId.Text);
                    loan.DateStart = dtpStartDate.Value;
                    loan.TermsOfPayment = float.Parse(txtTermsOfPayment.Text, CultureInfo.InvariantCulture.NumberFormat); 
                    loan.InterestRate = float.Parse(txtInterestRate.Text, CultureInfo.InvariantCulture.NumberFormat);
                    loan.CalendarRate = (CalendarRate)cboCalendarRate.SelectedIndex;
                    loan.LoanAmount = float.Parse(txtAmountOfLoan.Text, CultureInfo.InvariantCulture.NumberFormat);
                    loan.Remark = txtRemark.Text;
                    loan.Reference = txtReference.Text;
                    unitOfWork.Complete();
                    MessageBox.Show("Update Successfull");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void GetLoan(Int64 loanId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var loan = unitOfWork.Loans.Get(loanId);
                    var borrower = unitOfWork.Borrowers.Get(loan.BorrowerId);
                  
                    txtLoanId.Text=loan.LoanId.ToString() ;
                    txtBorrowerId.Text=loan.BorrowerId.ToString();
                    txtBorrower.Text = borrower.FullName;
                    dtpStartDate.Value=loan.DateStart ;
                    txtTermsOfPayment.Text=loan.TermsOfPayment.ToString() ;
                    txtInterestRate.Text= loan.InterestRate.ToString() ;
                    cboCalendarRate.SelectedIndex  =(int)loan.CalendarRate;
                    txtAmountOfLoan.Text=loan.LoanAmount.ToString();
                    txtRemark.Text=loan.Remark;
                    txtReference.Text=loan.Reference;

                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    double result;
                    if (double.TryParse(txtAmountOfLoan.Text, out result))
                    {
                        txtAmountOfLoan.Text = String.Format(culture, "{0:N2}", result);
                        // txtAmountPaid.Select(txtAmountPaid.Text.Length, 0);
                    }
                    if (double.TryParse(txtTermsOfPayment.Text, out result))
                    {
                        txtTermsOfPayment.Text = String.Format(culture, "{0:N2}", result);
                    }
                    if (double.TryParse(txtInterestRate.Text, out result))
                    {
                        txtInterestRate.Text = String.Format(culture, "{0:N2}", result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Int64 result;

            if (Int64.TryParse(txtLoanId.Text, out result))
                Update(Convert.ToInt64(txtLoanId.Text));
            else
                Save();
        }

        private void cmdChange_Click(object sender, EventArgs e)
        {
            var borrowerList = new BorrowerListUi(this);
            borrowerList.Show();
        }



        private void tsbNewPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var payment = new LoanPaymentUi();
                payment.txtLoanId.Text = txtLoanId.Text;
                payment.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }



        private void txtTermsOfPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtAmountOfLoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;


        }

        private void cboCalendarRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDue.Text = cboCalendarRate.Text + " Due";

        }

        private void txtAmountOfLoan_Leave(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(txtAmountOfLoan.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double result;
               if (double.TryParse(txtAmountOfLoan.Text,out result))
                {
                   // double valueBefore = double.Parse(txtAmountOfLoan.Text, System.Globalization.NumberStyles.AllowThousands);
                    txtAmountOfLoan.Text = String.Format(culture, "{0:N2}", result);
                    txtAmountOfLoan.Select(txtAmountOfLoan.Text.Length, 0);
                }

            }
        }

   
        private void txtTermsOfPayment_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTermsOfPayment.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double result;
                if (double.TryParse(txtTermsOfPayment.Text, out result))
                {
                    txtTermsOfPayment.Text = String.Format(culture, "{0:N2}", result);
                    txtTermsOfPayment.Select(txtTermsOfPayment.Text.Length, 0);
                }

            }
        }


        private void txtInterestRate_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInterestRate.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double result;
                if (double.TryParse(txtInterestRate.Text, out result))
                {
                    txtInterestRate.Text = String.Format(culture, "{0:N2}", result);
                    txtInterestRate.Select(txtInterestRate.Text.Length, 0);
                }

            }
        }


        private void txtDue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDue.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double result;
                if (double.TryParse(txtDue.Text, out result))
                {
                    txtDue.Text = String.Format(culture, "{0:N2}", result);
                    txtDue.Select(txtDue.Text.Length, 0);
                }

            }
        }

        private void tsbNewCharge_Click(object sender, EventArgs e)
        {
            try
            {
                var charge = new LoanChargeUi();
               charge.txtLoanId.Text = txtLoanId.Text;
                charge.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            } 
        }




    }
}
