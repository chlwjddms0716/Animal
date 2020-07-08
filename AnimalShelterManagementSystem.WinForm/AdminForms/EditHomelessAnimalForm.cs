using AnimalShelterManagementSystem.Data;
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

    public partial class EditHomelessAnimalForm : Form
    {
  
        private HomelessAnimal homelessAnimal;

        public EditHomelessAnimalForm()
        {
            InitializeComponent();
        }


        public EditHomelessAnimalForm(int HomelessAnimalId) : this()
        {
            homelessAnimalId = HomelessAnimalId;

            this.homelessAnimal = DataRepository.HomelessAnimalId.Get(HomelsessAnimalId);

            .HomelessAnimalId = DataRepository.HomelessAnimal.GetMaxId() + 1;
            txeName.Text = homelessAnimal.Name;
            txeAge.Text = Convert.ToString(homelessAnimal.Age);
            cbbSpecies.SelectedValue = homelessAnimal.Species;
            txeFeature.Text = homelessAnimal.Feature;
            cbbGender.SelectedValue = homelessAnimal.Gender;
            cbbPSC.SelectedValue = homelessAnimal.PhysicalCondition;
            dteLatestFindingReport.Text = Convert.ToString(homelessAnimal.LatestFindingReport);
            txePictureLink.Text = homelessAnimal.PictureLink;
            cbbAnimalShelter.SelectedValue = homelessAnimal.AnimalShelterId;



        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            string checkinput = "";
            if (string.Equals(checkinput, "") == true)
            {
                HomelessAnimal homelessAnimal = new HomelessAnimal();
                homelessAnimal.HomelessAnimalId = Convert.ToInt32(cbbHomelessAnimalId.SelectedValue);
                homelessAnimal.Name = txeName.Text;
                homelessAnimal.Age = Convert.ToInt32(txeAge.Text);
                homelessAnimal.Species = Convert.ToInt32(cbbSpecies.SelectedValue);
                homelessAnimal.Feature = txeFeature.Text;
                homelessAnimal.Gender = Convert.ToInt32(cbbGender.SelectedValue);
                homelessAnimal.PhysicalCondition = Convert.ToInt32(cbbPSC.SelectedValue);
                homelessAnimal.LatestFindingReport = dteLatestFindingReport.DateTime.Date;
                homelessAnimal.PictureLink = txePictureLink.Text;
                homelessAnimal.AnimalShelterId = Convert.ToInt32(cbbAnimalShelter.SelectedValue);
                MessageBox.Show("유기유실동물의 정보가 수정되었습니다.");
                Close();

                DataRepository.HomelessAnimal.Update(homelessAnimal);
            }

        }
    }
}

