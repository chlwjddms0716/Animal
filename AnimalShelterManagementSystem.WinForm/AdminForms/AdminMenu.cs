using AnimalShelterManagementSystem.WinForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class AdminMenu : DevExpress.XtraEditors.XtraForm
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UserListForm userManagement = new UserListForm();
            userManagement.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnShelter_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ShelterListForm shelterListForm = new ShelterListForm();
            shelterListForm.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnAdoption_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AdoptionListForm adoptionManagement = new AdoptionListForm();
            adoptionManagement.ShowDialog();
            Cursor = Cursors.Arrow;

        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HomelessAnimalListForm homelessAnimalListForm = new HomelessAnimalListForm();
            homelessAnimalListForm.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnFindReportManagement_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FindingManagementForm findingManagementForm = new FindingManagementForm();
            findingManagementForm.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnLossReportManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
