using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LendingSystem.Core.Domain;
using LendingSystem.Persistence;

namespace LendingSystem.UI
{
    public partial class OfficeUi : Form
    {
        public OfficeUi()
        {
            InitializeComponent();
        }
        private void OfficeUi_Load(object sender, EventArgs e)
        {
            OfficesShow();

        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
                unitOfWork.Offices.Add(new Office{Name =txtOffice.Text});
                unitOfWork.Complete();
                OfficesShow();
            }
        }

        private void OfficesShow()
        {
            try
            {
                dgvOffices.AutoGenerateColumns = true;
                dgvOffices.AutoSize = true;
                
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var offices = unitOfWork.Offices.GetAll();
                    dgvOffices.DataSource = offices;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void cmdRemove_Click(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new LendingContext()))
            {
                var id = Convert.ToInt16(txtOfficeId.Text);

                var office = unitOfWork.Offices.Get(id);
                office.IsDeleted = 1;
             
                unitOfWork.Complete();
                OfficesShow();
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            txtOfficeId.Text = "";
            txtOffice.Text = "";

        }


        private void dgvOffices_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgvOffices.SelectedRows.Count > 0)
                {
                    txtOfficeId.Text = dgvOffices.SelectedRows[0].Cells["OfficeId"].Value.ToString();
                    txtOffice.Text = dgvOffices.SelectedRows[0].Cells["Name"].Value.ToString();                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new LendingContext()))
                {
                    var id = Convert.ToInt16(txtOfficeId.Text);
                    var office = unitOfWork.Offices.Get(id);
                    office.Name = txtOffice.Text;
                    unitOfWork.Complete();
                    OfficesShow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOffices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  
 
    }
}
