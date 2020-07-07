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

            OnLoadButtonClicked((int)luAnimalshelter.EditValue, (int)luSpecies.EditValue, (Genders)rdgSex.EditValue
                , dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime);

            
            Cursor = Cursors.Arrow;

        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.GetAll();
        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, DevExpress.XtraEditors.ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }

        #region LoadButtonClicked event things for C# 3.0
        public event EventHandler<LoadButtonClickedEventArgs> LoadButtonClicked;

        protected virtual void OnLoadButtonClicked(LoadButtonClickedEventArgs e)
        {
            if (LoadButtonClicked != null)
                LoadButtonClicked(this, e);
        }

        private LoadButtonClickedEventArgs OnLoadButtonClicked(int animalShelterId, int speciesCode, Genders gender, DateTime foundDateFrom, DateTime foundDateTo)
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
            public int SpeciesCode { get; set; }
            public Genders Gender { get; set; }
            public DateTime FoundDateFrom { get; set; }
            public DateTime FoundDateTo { get; set; }

            public LoadButtonClickedEventArgs()
            {
            }

            public LoadButtonClickedEventArgs(int animalShelterId, int speciesCode, Genders gender, DateTime foundDateFrom, DateTime foundDateTo)
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
