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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UserManagement userManagement = new UserManagement();
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
            AdoptionManagement adoptionManagement = new AdoptionManagement();
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
    }
}
