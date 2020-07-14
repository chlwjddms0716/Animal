﻿
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
using AnimalShelterManagementSystem.WinForm.UserForms;

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class AdoptionRequest : DevExpress.XtraEditors.XtraForm
    {
        private int userId;
        Adoption adoption = new Adoption();
        private int SpeciesCode;
        private int GenderCode = 0;
        AnimalPicture animalPicture;
        public AdoptionRequest()
        {
            InitializeComponent();
        }

        public AdoptionRequest(int UserId) : this()
        {
            userId = UserId;
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
        }


        private void AdoptionRequest_Load_1(object sender, EventArgs e)
        {

            List<HomelessAnimal> homelessAnimals = new List<HomelessAnimal>();
            foreach (SpeciesType speciesType in (SpeciesType[])Enum.GetValues(typeof(SpeciesType)))
                homelessAnimals.AddRange(DataRepository.HomelessAnimal.SearchWithAnimals((int)speciesType, 0));
            homelessAnimalBindingSource.DataSource = homelessAnimals;
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            cbxSpecies.SelectedItem = null;

        }

        private void btnAdoptionRequest_Click(object sender, EventArgs e)
        {
            adoption.UserId = userId;
            adoption.AdoptionDate = DateTime.Today;

            try
            {
                DataRepository.Adoption.Insert(adoption);
                HomelessAnimal homelessAnimal = new HomelessAnimal();
                homelessAnimal = DataRepository.HomelessAnimal.Get(adoption.HomelessAnimalId);
                homelessAnimal.AdoptionStatus = 1;
                DataRepository.HomelessAnimal.Update(homelessAnimal);
                MessageBox.Show("입양 신청 되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("입양할 동물을 선택해주세요");
                return;
            }

            Close();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            GenderCode = (int)rdgSex.EditValue;
            if (cbxSpecies.SelectedItem != null)
            {
                SpeciesCode = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
                List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithAnimals(SpeciesCode, GenderCode);
                homelessAnimalBindingSource.DataSource = homelessAnimals;
                MessageBox.Show("사진을 크게 보려면 동물을 클릭해주세요.");
            }
        }

        private void grcAnimalList_DoubleClick(object sender, EventArgs e)
        {
            HomelessAnimal homelessAnimal = homelessAnimalBindingSource.Current as HomelessAnimal;
            if (homelessAnimal == null)
                return;

            adoption.HomelessAnimalId = homelessAnimal.HomelessAnimalId;
            MessageBox.Show($"{homelessAnimal.Name}을 선택하셨습니다.");
        }

        private void grcAnimalList_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AnimalPicture>().Count() > 0)
                Application.OpenForms.OfType<AnimalPicture>().First().Close();

            animalPicture = new AnimalPicture(homelessAnimalBindingSource.Current as HomelessAnimal);
            animalPicture.ShowDialog();
        }
    }
}
