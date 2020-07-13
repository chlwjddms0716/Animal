using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.Models;
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
    public partial class FindingReportListForm : DevExpress.XtraEditors.XtraForm
    {
        private int SpeciesCode;
        public FindingReportListForm()
        {
            InitializeComponent();
        }
        private void FindingManagementForm_Load(object sender, EventArgs e)
        {
            dteFoundDateTo.DateTime = DateTime.Today;
            dteFoundDateFrom.DateTime = DateTime.MinValue;
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            findingReportBindingSource.DataSource = DataRepository.FindingReport.Search(SpeciesCode, dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime, txbPlace.Text);
    
        }
      
        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSpecies.SelectedItem != null)
                SpeciesCode = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
          
            else
                SpeciesCode = 0;

            findingReportBindingSource.DataSource = DataRepository.FindingReport.Search(SpeciesCode, dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime, txbPlace.Text);

        }

        private void dteFoundDateFrom_EditValueChanged(object sender, EventArgs e)
        {
            findingReportBindingSource.DataSource = DataRepository.FindingReport.Search(SpeciesCode, dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime, txbPlace.Text);

        }

        private void dteFoundDateTo_EditValueChanged(object sender, EventArgs e)
        {
            findingReportBindingSource.DataSource = DataRepository.FindingReport.Search(SpeciesCode, dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime, txbPlace.Text);

        }

        private void txbPlace_TextChanged(object sender, EventArgs e)
        {
            findingReportBindingSource.DataSource = DataRepository.FindingReport.Search(SpeciesCode, dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime, txbPlace.Text);

        }

        private void LoadEditForm(FindingReport findingReport)
        {
            Cursor = Cursors.WaitCursor;
            FindingForm findingForm = new FindingForm(findingReport);
            findingForm.ShowDialog();
            Cursor = Cursors.Arrow;
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FindingForm findingForm = new FindingForm();
            findingForm.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            FindingReport findingReport = findingReportBindingSource.Current as FindingReport;

            if (Helpers.Helpers.SureToDelete() == false)
                return;
            if (findingReport == null)
                return;

            DataRepository.FindingReport.Delete(findingReport);

            findingReportBindingSource.Remove(findingReport);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (findingReportBindingSource.Current is null)
                MessageBox.Show("수정할 유저를 선택해주세요");
            else
                LoadEditForm(findingReportBindingSource.Current as FindingReport);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            findingReportBindingSource.DataSource = DataRepository.FindingReport.Search(SpeciesCode, dteFoundDateFrom.DateTime, dteFoundDateTo.DateTime, txbPlace.Text);

        }

        private void btnFindingReport_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
