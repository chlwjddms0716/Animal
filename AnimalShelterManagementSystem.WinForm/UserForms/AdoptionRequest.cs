
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
using DevExpress.XtraEditors.Controls;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Data.
    Entity.Core.Metadata.Edm;

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class AdoptionRequest : Form
    {
        private int userId;
        Adoption adoption = new Adoption();
        private int SpeciesCode;
        private int GenderCode = 0;
        public AdoptionRequest()
        {
            InitializeComponent();
        }

        public AdoptionRequest(int UserId) : this()
        {
            userId = UserId;
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
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
                homelessAnimals.AddRange(DataRepository.HomelessAnimal.SearchWithAnimals((int)speciesType, 0));
            homelessAnimalBindingSource.DataSource = homelessAnimals;
            cbxSpecies.SelectedItem = null;







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

        private void grvHomelessAnimalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSpecies.SelectedItem != null)
            {
                SpeciesCode = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
                List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithAnimals(SpeciesCode, GenderCode);
                homelessAnimalBindingSource.DataSource = homelessAnimals;
            }
        }

        private void rdgSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenderCode = (int)rdgSex.EditValue;
            List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithAnimals(SpeciesCode, GenderCode);
            homelessAnimalBindingSource.DataSource = homelessAnimals;
        }
    }
}
