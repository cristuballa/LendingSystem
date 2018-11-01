using System;
using System.Windows.Forms;
using LendingSystem.Persistence;

namespace LendingSystem.UI
{
    public partial class BorrowerListUi : Form
    {
        public readonly  LoanUi loanUi;
        public BorrowerListUi(LoanUi form)
        {
            InitializeComponent();
            loanUi = form;
        }

        private void BorrowerListUi_Load(object sender, EventArgs e)
        {
            using(var unitOfWork= new UnitOfWork(new LendingContext()))
            {
                var borrower= unitOfWork.Borrowers.GetAll();
                cboBorrowerList.DataSource =borrower;
                cboBorrowerList.DisplayMember = "FullName";
                cboBorrowerList.ValueMember = "BorrowerId";
            }
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            loanUi.txtBorrower.Text = cboBorrowerList.Text;
            loanUi.txtBorrowerId.Text =cboBorrowerList.SelectedValue.ToString();
            this.Close();
        }
    }
}
