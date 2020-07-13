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
        List<FindingReport> findingReports;
        List<FindingReport> filterBySpecies;
        List<FindingReport> filterByDate;
        List<FindingReport> filterByPlace;
        private int SpeciesCode;
        public FindingReportListForm()
        {
            InitializeComponent();
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            findingReports = DataRepository.FindingReport.GetAll();
            foreach (FindingReport findingReport in findingReports)
                    findingReport.SpeciesName = ((SpeciesType)findingReport.Species).ToString();
            findingReportBindingSource.DataSource = findingReports;
            dteFoundDateTo.DateTime = DateTime.Today;
            dteFoundDateFrom.DateTime = DateTime.MinValue;
        }

        private void querybySpecies()
        {
            if (SpeciesCode == 0)
                filterBySpecies = findingReports;
            else
                filterBySpecies = findingReports.Where(x => x.Species == SpeciesCode).ToList();
        }
        private void querybyDate()
        {
            querybySpecies();
            if (dteFoundDateTo.DateTime < dteFoundDateFrom.DateTime)
            {
                MessageBox.Show("날짜를 다시 골라주세요.");
                filterByDate = filterBySpecies;
                return;
            }
            else
                filterByDate = filterBySpecies.Where(x => x.Date >= dteFoundDateFrom.DateTime && x.Date <= dteFoundDateTo.DateTime).ToList();
        }
        private void querybyPlace()
        {
            querybyDate();
            if (String.Equals(txbPlace.Text, "") == false)
                filterByPlace = findingReports.Where(x => x.Place.Contains(txbPlace.Text) == true).ToList();
            else
                filterByPlace = filterByDate;
            findingReportBindingSource.DataSource = filterByPlace;
        }

        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSpecies.SelectedItem != null)
                SpeciesCode = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
            else
                SpeciesCode = 0;
            querybyPlace();
        }

        private void dteFoundDateFrom_EditValueChanged(object sender, EventArgs e)
        {
            querybyPlace();
        }

        private void dteFoundDateTo_EditValueChanged(object sender, EventArgs e)
        {
            querybyPlace();
        }

        private void txbPlace_TextChanged(object sender, EventArgs e)
        {
            querybyPlace();
        }

        //private void LoadEditForm(FindingReport findingReport)
        //{
        //    Cursor = Cursors.WaitCursor;
        //    FindingForm findingForm = new FindingForm(findingReport);
        //    findingForm.ShowDialog();
        //    Cursor = Cursors.Arrow;
        //}
        //private void tsbAdd_Click(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;
        //    FindingForm findingForm = new FindingForm();
        //    findingForm.ShowDialog();
        //    Cursor = Cursors.Arrow;
        //}

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (findingReportBindingSource.Current is null)
                MessageBox.Show("삭제할 유저를 선택해주세요");
            //else 
            //    LoadEditForm(findingReportBindingSource.Current as FindingReport);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (findingReportBindingSource.Current is null)
                MessageBox.Show("수정할 유저를 선택해주세요");
            //else
            //    LoadEditForm(findingReportBindingSource.Current as FindingReport);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            findingReports = DataRepository.FindingReport.GetAll();
            foreach (FindingReport findingReport in findingReports)
                findingReport.SpeciesName = ((SpeciesType)findingReport.Species).ToString();
            findingReportBindingSource.DataSource = findingReports;
            querybyPlace();
        }

        private void btnFindingReport_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
