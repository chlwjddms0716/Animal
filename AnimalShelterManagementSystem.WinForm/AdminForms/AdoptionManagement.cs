using AnimalShelterManagementSystem.Data;
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
    public partial class AdoptionManagement : Form
    {
        List<Adoption> adoptionList = new List<Adoption>();
        private int userId;
        Adoption adoption = new Adoption();

        public AdoptionManagement()
        {
            InitializeComponent();
        }

        public AdoptionManagement(int UserId) : this()
        {
            userId = UserId;
        }

        private void btnAdoptionManagement_Click(object sender, EventArgs e)
        {
            //List<HomelessAnimal> animals = DataRepository.Adoption.GetAnimalsByUserName(txeUserName.Text);

            //homelessAnimalBindingSource.DataSource = animals;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdoptionManagement_Load(object sender, EventArgs e)
        {
            homelessAnimalBindingSource.DataSource = DataRepository.Adoption.GetAll();
        }
    }
}
