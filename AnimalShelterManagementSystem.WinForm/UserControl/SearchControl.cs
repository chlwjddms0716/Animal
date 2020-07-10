using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalShelterManagementSystem.Data;
using DevExpress.XtraEditors.Repository;
using AnimalShelterManagementSystem.Models;
using DevExpress.XtraEditors.Filtering.Templates;

namespace AnimalShelterManagementSystem.WinForm.UserControls
{
    
    public partial class SearchControl : DevExpress.XtraEditors.XtraUserControl
    {
        
        private int GenderCode = 0;
        private int speciesCode;
        private int animalShelterId;
        private DateTime foundDateFrom;
        private DateTime foundDateTo;
        public SearchControl()
        {
            InitializeComponent();


        }

        public void GetValues()
        {
            foreach (string gender in Genders.GetNames(typeof(Genders)))
            {
                Console.WriteLine(gender);
            }


        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            //int? animalShelterlId = null;
            //  try
            // {
            //   animalShelterlId = Convert.ToInt32(luAnimalshelter.Text);
            // }
            //catch
            // {
            //
            // }
            // finally
            //  {
            //      if (animalShelterlId == null || animalShelterlId.Value < 1)
            //          animalShelterlId = 2;
            //  }



            OnLoadButtonClicked((int)lueAnimalShelterId.EditValue, (SpeciesType)cbbSpecies.SelectedValue, (int)rdgGender.EditValue
       , dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime);

    




            Cursor = Cursors.Arrow;

        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsAnimalShelter.DataSource = DataRepository.AnimalShelter.GetAll();
            cbbSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
          

            dteFoundDateTo.DateTime = DateTime.Today;
        }

        #region LoadButtonClicked event things for C# 3.0
        public event EventHandler<LoadButtonClickedEventArgs> LoadButtonClicked;

        protected virtual void OnLoadButtonClicked(LoadButtonClickedEventArgs e)
        {
            if (LoadButtonClicked != null)
                LoadButtonClicked(this, e);
        }

        private LoadButtonClickedEventArgs OnLoadButtonClicked(int animalShelterId, SpeciesType speciesCode, int gender, DateTime foundDateFrom, DateTime foundDateTo)
        {
            LoadButtonClickedEventArgs args = new LoadButtonClickedEventArgs(animalShelterId, speciesCode, gender, foundDateFrom, foundDateTo);
            OnLoadButtonClicked(args);

            return args;
        }

        private LoadButtonClickedEventArgs OnLoadButtonClickedForOut()
        {
            LoadButtonClickedEventArgs args = new LoadButtonClickedEventArgs();
            OnLoadButtonClicked(args);

            return args;
        }

        public class LoadButtonClickedEventArgs : EventArgs
        {
            public int AnimalShelterId { get; set; }
            public SpeciesType SpeciesCode { get; set; }
            public int Gender { get; set; }
            public DateTime FoundDateFrom { get; set; }
            public DateTime FoundDateTo { get; set; }

            public LoadButtonClickedEventArgs()
            {
            }

            public LoadButtonClickedEventArgs(int animalShelterId, SpeciesType speciesCode, int gender, DateTime foundDateFrom, DateTime foundDateTo)
            {
                AnimalShelterId = animalShelterId;
                SpeciesCode = speciesCode;
                Gender = gender;
                FoundDateFrom = foundDateFrom;
                FoundDateTo = foundDateTo;
            }
        }

        #endregion



        private void rdgGender_SelectedIndexChanged(object sender, EventArgs e)
        {

            GenderCode = (int)rdgGender.EditValue;
            //List<HomelessAnimal> homelessAnimals = new List<HomelessAnimal>();

            //List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithHomelessAnimal(animalShelterId, speciesCode, GenderCode, foundDateFrom, foundDateTo);



        }
    }
}