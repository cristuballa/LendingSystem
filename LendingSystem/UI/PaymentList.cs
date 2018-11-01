using LendingSystem.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LendingSystem.UI
{
    public partial class PaymentList : Form
    {
        public PaymentList()
        {

            InitializeComponent();

            DateTime now = DateTime.Now;
            dtpDateFrom.Value = new DateTime(now.Year, now.Month, 1);
            dtpDateTo.Value = now;
            PaymentListShow(dtpDateFrom.Value, dtpDateTo.Value);

        }


        private void PaymentListShow(DateTime DateFrom, DateTime DateTo)
        {

            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
                dgvPayments.DataSource = null;
                dgvPayments.Columns.Clear();

                var payments = unitOfWork.LoanPayments.PaymentListByPeriod(DateFrom, DateTo);

                dgvPayments.AutoGenerateColumns = false;
                dgvPayments.DataSource = payments;

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N2";

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();

                column1.DataPropertyName = "LoanPaymentId";
                column1.Name = "Id";
                column1.FillWeight = 8;
                column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvPayments.Columns.Add(column1);


                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "DatePost";
                column2.Name = "Date Post";
                column2.FillWeight = 15;
                column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvPayments.Columns.Add(column2);

                DataGridViewColumn column6 = new DataGridViewTextBoxColumn();
                column6.DataPropertyName = "Borrower";
                column6.Name = "Borrower";
                column6.FillWeight = 20;
                column6.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvPayments.Columns.Add(column6);

                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "Reference";
                column3.Name = "Reference";
                column3.FillWeight = 20;
                column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvPayments.Columns.Add(column3);

                DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                column4.DataPropertyName = "Remark";
                column4.Name = "Remark";
                column4.FillWeight = 30;
                column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvPayments.Columns.Add(column4);


                DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
                column5.DataPropertyName = "AmountPaid";
                column5.Name = "Amount Paid";
                column5.FillWeight = 15;
                column5.DefaultCellStyle = style;
                column5.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                column5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPayments.Columns.Add(column5);

                dgvPayments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPayments.Refresh();


            }
        }


        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentListShow(dtpDateFrom.Value, dtpDateTo.Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                

        }

        private void dgvPayments_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                Int64 id = Convert.ToInt64(dgvPayments.SelectedRows[0].Cells["Id"].Value.ToString());
                var payment = new LoanPaymentUi();
                payment.GetPayment(id);
                payment.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            try
            {
              
                var c = new ReportViewer();
                c.PaymentListPrint(dtpDateFrom.Value ,dtpDateTo.Value, true);
                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
