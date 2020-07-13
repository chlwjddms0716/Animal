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

namespace AnimalShelterManagementSystem.WinForm.UserControls
{
    public partial class SearchControl : DevExpress.XtraEditors.XtraUserControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

      

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int? animalShelterlId = null;
            try
            {
                animalShelterlId = Convert.ToInt32(luAnimalshelter.Text);
            }
            catch
            {

            }
            finally
            {
                if (animalShelterlId == null || animalShelterlId.Value < 1)
                    animalShelterlId = 1;
            }

            OnLoadButtonClicked(luAnimalshelter.SelectedText, luSpecies.SelectedText, luIsmale.SelectedText
                , dtaFindingReportDate.DateTime, dtaLastestFindingReportDate.DateTime);

            
            Cursor = Cursors.Arrow;

        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            homelessAnimalBindingSource.DataSource = DataRepository.HomelessAnimal.GetAll();
            speciesBindingSource.DataSource = DataRepository.Species.GetAll();
            sexBindingSource.DataSource = DataRepository.Sex.GetAll();
            animalShelterBindingSource1.DataSource = DataRepository.AnimalShelter.GetAll();
        }

        #region LoadButtonClicked event things for C# 3.0
        public event EventHandler<LoadButtonClickedEventArgs> LoadButtonClicked;

        protected virtual void OnLoadButtonClicked(LoadButtonClickedEventArgs e)
        {
            if (LoadButtonClicked != null)
                LoadButtonClicked(this, e);
        }

        private LoadButtonClickedEventArgs OnLoadButtonClicked(string animalshelter, string species, string sex, DateTime findingDate, DateTime latestDate)
        {
            LoadButtonClickedEventArgs args = new LoadButtonClickedEventArgs(animalshelter, species, sex, findingDate, latestDate);
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
            public string Animalshelter { get; set; }
            public string Species { get; set; }
            public string Sex { get; set; }
            public DateTime FindingDate { get; set; }
            public DateTime LatestDate { get; set; }

            public LoadButtonClickedEventArgs()
            {
            }

            public LoadButtonClickedEventArgs(string animalshelter, string species, string sex, DateTime findingDate, DateTime latestDate)
            {
                Animalshelter = animalshelter;
                Species = species;
                Sex = sex;
                FindingDate = findingDate;
                LatestDate = latestDate;
            }
        }
        #endregion



    }
}
