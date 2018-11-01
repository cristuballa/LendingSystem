using System;

using System.Windows.Forms;
using LendingSystem.Core.Domain;
using LendingSystem.Persistence;

namespace LendingSystem.UI
{
    public partial class LoanChargeUi : Form
    {
        public LoanChargeUi()
        {
            InitializeComponent();

            dtpDatePost.Value = DateTime.Now ;

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

            Int64 result;

            if (Int64.TryParse(txtLoanChargeId.Text, out result))
                Update(Convert.ToInt64(txtLoanChargeId.Text));
            else
                Save();
        }

        private void Save()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var charge = new LoanCharge
                    {
                        LoanId = Convert.ToInt64(txtLoanId.Text),
                        DatePost = dtpDatePost.Value,
                        Amount = Convert.ToSingle(txtAmountCharge.Text),
                        Reference = txtReference.Text,
                        Remark = txtRemark.Text,
                    };
                    unitOfWork.LoanCharges.Add(charge);
                    unitOfWork.Complete();
                    txtLoanChargeId.Text = charge.LoanChargeId.ToString();
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
                    var charge = unitOfWork.LoanCharges.Get(paymentId);
                    charge.LoanId = Convert.ToInt64(txtLoanId.Text);
                    charge.DatePost = dtpDatePost.Value;
                    charge.Amount = Convert.ToSingle(txtAmountCharge.Text);
                    charge.Reference = txtReference.Text;
                    charge.Remark = txtRemark.Text;
                    unitOfWork.Complete();
                    MessageBox.Show("Update Successfull");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetCharge(Int64 chargeId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var charge = unitOfWork.LoanCharges.Get(chargeId);
                    txtLoanChargeId.Text = charge.LoanChargeId.ToString();
                    txtLoanId.Text = charge.LoanId.ToString();
                    dtpDatePost.Value = charge.DatePost;
                    txtAmountCharge.Text = charge.Amount.ToString();
                    txtReference.Text = charge.Reference;
                    txtRemark.Text = charge.Remark;


                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    double result;
                    if (double.TryParse(txtAmountCharge.Text, out result))
                    {
                        txtAmountCharge.Text = String.Format(culture, "{0:N2}", result);
                        // txtAmountPaid.Select(txtAmountPaid.Text.Length, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAmountCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtAmountCharge_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmountCharge.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double result;
                if (double.TryParse(txtAmountCharge.Text, out result))
                {
                    txtAmountCharge.Text = String.Format(culture, "{0:N2}", result);
                }

            }
        }



    }
}
