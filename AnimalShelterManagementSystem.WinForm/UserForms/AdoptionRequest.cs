
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AnimalShelterManagementSystem.Data;
using DevExpress.XtraLayout.Helpers;
using AnimalShelterManagementSystem.Models;

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class AdoptionRequest : Form
    {
        private int userId;
        Adoption adoption = new Adoption();
        private int SpeciesCode;
        private bool isMale = false;
        private bool isFemale = false;
        public AdoptionRequest()
        {
            InitializeComponent();
        }

        public AdoptionRequest(int UserId) : this()
        {
            userId = UserId;
        }


        private void drbSpeciesSelection_Click(object sender, EventArgs e)
        {

        }

        private void AdoptionRequest_Load(object sender, EventArgs e)
        {
           
        }

        private void AdoptionRequest_Load_1(object sender, EventArgs e)
        {
 
            List<HomelessAnimal> homelessAnimals = new List<HomelessAnimal>();
            foreach (SpeciesType speciesType in (SpeciesType[])Enum.GetValues(typeof(SpeciesType)))
                homelessAnimals.AddRange(DataRepository.HomelessAnimal.SearchWithAnimals((int)speciesType, false, false));                
            homelessAnimalBindingSource.DataSource = homelessAnimals;
        }

        private void btnAdoptionRequest_Click(object sender, EventArgs e)
        {
            adoption.UserId = userId;
            adoption.AdoptionDate = DateTime.Now;
            try
            {
                DataRepository.Adoption.Insert(adoption);
                HomelessAnimal homelessAnimal = new HomelessAnimal();
                homelessAnimal = DataRepository.HomelessAnimal.Get(adoption.HomelessAnimalId);
                homelessAnimal.IsAdopted = true;
                DataRepository.HomelessAnimal.Update(homelessAnimal);
                MessageBox.Show("입양 신청 되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void grvHomelessAnimalList_DoubleClick(object sender, EventArgs e)
        {
            HomelessAnimal homelessAnimal = homelessAnimalBindingSource.Current as HomelessAnimal;
            if (homelessAnimal == null)
                return;

            adoption.HomelessAnimalId = homelessAnimal.HomelessAnimalId;
            MessageBox.Show($"{homelessAnimal.Name}을 선택하셨습니다.");
        }

        private void lkuSpecies_EditValueChanged(object sender, EventArgs e)
        {

            List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithAnimals(SpeciesCode, isMale, isFemale);
            homelessAnimalBindingSource.DataSource = homelessAnimals;
        }

        private void chbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMale.Checked)
                isMale = true;
            else
                isMale = false;
            List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithAnimals(SpeciesCode, isMale, isFemale);
            homelessAnimalBindingSource.DataSource = homelessAnimals;
        }

        private void chbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFemale.Checked)
                isFemale = true;
            else
                isFemale = false;
            List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithAnimals(SpeciesCode, isMale, isFemale);
            homelessAnimalBindingSource.DataSource = homelessAnimals;
        }

        private void grvHomelessAnimalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
