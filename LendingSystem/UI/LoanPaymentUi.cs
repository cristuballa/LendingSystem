using System;
using System.Windows.Forms;
using LendingSystem.Core.Domain;
using LendingSystem.Persistence;

namespace LendingSystem.UI
{
    public partial class LoanPaymentUi : Form
    {
        public LoanPaymentUi()
        {
            InitializeComponent();
            dtpDatePost.Value = DateTime.Now;


        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Int64 result;

            if (Int64.TryParse(txtLoanPaymentId.Text, out result))
                Update(Convert.ToInt64(txtLoanPaymentId.Text));
            else
                Save();
        }

        private void Save()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var payment = new LoanPayment
                    {
                        LoanId  =Convert.ToInt64(txtLoanId.Text),
                        DatePost =dtpDatePost.Value,
                        AmountPaid = Convert.ToDecimal(txtAmountPaid.Text),
                        Reference=txtReference.Text, 
                        Remark  = txtRemark.Text,
                    };
                    unitOfWork.LoanPayments.Add(payment);
                    unitOfWork.Complete();
                    txtLoanPaymentId.Text = payment.LoanPaymentId.ToString();
                    MessageBox.Show("Save Successfull");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Update(Int64 paymentId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var payment = unitOfWork.LoanPayments.Get(paymentId);
                    payment.LoanId = Convert.ToInt64(txtLoanId.Text);
                    payment.DatePost = dtpDatePost.Value;
                    payment.AmountPaid = Convert.ToDecimal(txtAmountPaid.Text);
                    payment.Reference = txtReference.Text;
                    payment.Remark = txtRemark.Text;
                    unitOfWork.Complete();
                    MessageBox.Show("Update Successfull");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetPayment(Int64 paymentId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var payment = unitOfWork.LoanPayments.Get(paymentId);
                    txtLoanPaymentId.Text = payment.LoanPaymentId.ToString();
                    txtLoanId.Text = payment.LoanId.ToString();
                    dtpDatePost.Value = payment.DatePost;
                    txtAmountPaid.Text= payment.AmountPaid.ToString();
                    txtReference.Text = payment.Reference;
                    txtRemark.Text = payment.Remark;


                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    double result;
                    if (double.TryParse(txtAmountPaid.Text, out result))
                    {
                        txtAmountPaid.Text = String.Format(culture, "{0:N2}", result);
                       // txtAmountPaid.Select(txtAmountPaid.Text.Length, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }



        private void txtAmountPaid_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double result;
                if (double.TryParse(txtAmountPaid.Text, out result))
                {
                    txtAmountPaid.Text = String.Format(culture, "{0:N2}", result);
                }

            }
        }





    }
}