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

            if (String.Equals(tebUserId.Text, "") == true)
            {
                MessageBox.Show("유저아이디를 입력해주세요");
            }
            /*
            adoption.UserId = userId;
            DataRepository.Adoption.Insert(adoption);
            HomelessAnimal homelessAnimal = new HomelessAnimal();
            homelessAnimal = DataRepository.HomelessAnimal.Get(adoption.HomelessAnimalId);
            homelessAnimal.IsAdopted = true;
            DataRepository.HomelessAnimal.Update(homelessAnimal);

            userId = DataRepository.HomelessAnimal.GetMaxId() + 1;
            userId.Species = Convert.ToInt32(cbbSpecies.SelectedValue);
            _homelessAnimal.Age = Convert.ToInt32(txeAge.Text);
            _homelessAnimal.Species = Convert.ToInt32(cbbSpecies.SelectedValue);
            _homelessAnimal.Feature = txeFeature.Text;
            _homelessAnimal.Gender = Convert.ToInt32(cbbGender.SelectedValue);
            _homelessAnimal.PhysicalCondition = Convert.ToInt32(cbbPSC.SelectedValue);
            _homelessAnimal.LatestFindingReport = dteLatestFindingReport.DateTime.Date;
            _homelessAnimal.PictureLink = txePictureLink.Text;
            _homelessAnimal.AnimalShelterId = Convert.ToInt32(cbbAnimalShelter.SelectedValue);
           
             */

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
