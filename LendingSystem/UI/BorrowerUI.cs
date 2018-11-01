using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using LendingSystem.Core.Domain;
using LendingSystem.Persistence;

namespace LendingSystem.UI
{
    public partial class BorrowerUI : Form
    {
        public BorrowerUI()
        {
            InitializeComponent();
            ShowOfficesTocboOffice();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Int64 result;

            if (Int64.TryParse(txtBorrowerId.Text, out result))
                Update(Convert.ToInt64(txtBorrowerId.Text));
            else
                Save();
        }

        private void Save()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var toolbox = new Toobox();
                    var borrower = new Borrower
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Address =txtAddress.Text,
                        BirthDate = dtpBirthDate.Value,
                        ContactInfo = txtContactInfo.Text,
                        Designation = txtDesignation.Text,
                        Gender = cboGender.Text,
                        MonthlyIncome = Convert.ToDecimal(txtMonthlyIncome.Text),
                        OfficeId=(int)cboOffice.SelectedValue,
                        Photo = toolbox.ImageToByte(picPhoto.Image),
                        Status=chkStatus.Checked 
                    };
                    unitOfWork.Borrowers.Add(borrower);
                    unitOfWork.Complete();
                    txtBorrowerId.Text =borrower.BorrowerId.ToString();
                    MessageBox.Show("Save Successfull");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Update(Int64 borrowerId)
        {
            try
            {
                var toolbox = new Toobox();
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                    { 
                       var borrower= unitOfWork.Borrowers.Get(borrowerId);
                        borrower.FirstName = txtFirstName.Text;
                        borrower.LastName = txtLastName.Text;
                        borrower.Address = txtAddress.Text;
                        borrower.BirthDate = dtpBirthDate.Value;
                        borrower.ContactInfo = txtContactInfo.Text;
                        borrower.Designation = txtDesignation.Text;
                        borrower.Gender = cboGender.Text;
                        borrower.MonthlyIncome = Convert.ToDecimal(txtMonthlyIncome.Text);
                        borrower.OfficeId = (int) cboOffice.SelectedValue;
                        borrower.Photo = toolbox.ImageToByte(picPhoto.Image);
                        borrower.Status = chkStatus.Checked;
                        unitOfWork.Complete();
                        MessageBox.Show("Update Successfull");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void GetBorrower(Int64 borrowerId)
        {
            try
            {

            var toolbox = new Toobox();

            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
                var borrower = unitOfWork.Borrowers.Get(borrowerId);

                txtBorrowerId.Text =borrower.BorrowerId.ToString();
                txtFirstName.Text = borrower.FirstName;
                txtLastName.Text = borrower.LastName;
                txtAddress.Text = borrower.Address;

                dtpBirthDate.Value = borrower.BirthDate;
                txtContactInfo.Text = borrower.ContactInfo;
                txtDesignation.Text = borrower.Designation;
                cboGender.Text = borrower.Gender;
                txtMonthlyIncome.Text = borrower.MonthlyIncome.ToString();
                cboOffice.SelectedValue = borrower.OfficeId;
                picPhoto.Image =toolbox.ByteToImage(borrower.Photo);
                chkStatus.Checked = borrower.Status;
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {

            var offices=new OfficeUi();
            offices.Show();
            ShowOfficesTocboOffice();
        }

        private void ShowOfficesTocboOffice()
        {
            try
            {

            using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                var offices=unitOfWork.Offices.GetAll();
                     
                        cboOffice.DataSource = offices;
                        cboOffice.DisplayMember = "Name";
                        cboOffice.ValueMember = "OfficeId";
                }
            }
            catch(Exception)
            {
                throw new NotImplementedException() ;
            }
        }


        private void txtMonthlyIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void tsbCamera_Click(object sender, EventArgs e)
        {
            var camera = new CameraUi(this);
            if (!camera.Visible)
                camera.Show();
            else
                camera.BringToFront();
        }

        private void txtBorrowerId_TextChanged(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
               //var l= unitOfWork.Borrowers.Get(Convert.ToInt64(txtBorrowerId.Text));
               // dataGridView1.DataSource = l.Loans;

            }
        }

        private void tsbNewLoan_Click(object sender, EventArgs e)
        {
            try
            {
                var loan = new LoanUi();
                Int64 id = Convert.ToInt64(txtBorrowerId.Text);
                loan.txtBorrowerId.Text = id.ToString();
                loan.txtBorrower.Text = txtFirstName.Text + " "+ txtLastName.Text;
                loan.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void txtMonthlyIncome_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
