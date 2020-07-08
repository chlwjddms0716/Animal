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
        public SearchControl()
        {
            InitializeComponent();


        }

        public void GetValues()
        {
            foreach(string gender in Genders.GetNames(typeof(Genders)))
            {
                Console.WriteLine(gender);
            }


        }
      

        private void btnLoad_Click(object sender, EventArgs e)
        {

            OnLoadButtonClicked(
                  luAnimalshelter.EditValue == null ? (int?)null : (int)luAnimalshelter.EditValue,
              lueSpecies.EditValue == null ? (SpeciesType?)null : (SpeciesType)(int)lueSpecies.EditValue,
                rdgGender.EditValue == null ? (Genders?)null : (Genders)(int)rdgGender.EditValue,
                 dteFoundDateFrom.EditValue == null ? (DateTime?)null : (DateTime)dteFoundDateFrom.EditValue,
                dteFoundDateTo.EditValue == null ? (DateTime?)null : (DateTime)dteFoundDateTo.EditValue);




            Cursor = Cursors.Arrow;

        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsAnimalShelter.DataSource = DataRepository.AnimalShelter.GetAll();
            bdsSpecies.DataSource = Species.Load();
            dteFoundDateTo.DateTime = DateTime.Now;

           







        }



        #region LoadButtonClicked event things for C# 3.0
        public event EventHandler<LoadButtonClickedEventArgs> LoadButtonClicked;

        protected virtual void OnLoadButtonClicked(LoadButtonClickedEventArgs e)
        {
            if (LoadButtonClicked != null)
                LoadButtonClicked(this, e);
        }

        private LoadButtonClickedEventArgs OnLoadButtonClicked(int? animalShelterId, SpeciesType? speciesCode, Genders? gender, DateTime? foundDateFrom, DateTime? foundDateTo)
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
            public int? AnimalShelterId { get; set; }
            public SpeciesType? SpeciesCode { get; set; }
            public Genders? Gender { get; set; }
            public DateTime? FoundDateFrom { get; set; }
            public DateTime? FoundDateTo { get; set; }

            public LoadButtonClickedEventArgs()
            {
            }

            public LoadButtonClickedEventArgs(int? animalShelterId, SpeciesType? speciesCode, Genders? gender, DateTime? foundDateFrom, DateTime? foundDateTo)
            {
                AnimalShelterId = animalShelterId;
                SpeciesCode = speciesCode;
                Gender = gender;
                FoundDateFrom = foundDateFrom;
                FoundDateTo = foundDateTo;
            }
        }
        #endregion
    }
}
