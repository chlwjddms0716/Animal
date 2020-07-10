using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AnimalShelterManagementSystem.Models;
using AnimalShelterManagementSystem.Data;

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class LossReportListForm : DevExpress.XtraEditors.XtraForm
    {
        public LossReportListForm()
        {
            InitializeComponent();
        }

        private void LossReportListForm_Load(object sender, EventArgs e)
        {
            List<LossReport> lossReports = new List<LossReport>();
            lossReports = DataRepository.LossReport.GetAll();
            lossReportBindingSource.DataSource = lossReports;
        }

        private void txeAnimalName_EditValueChanged(object sender, EventArgs e)
        {
            string AnimalName = txeAnimalName.Text;
            List<LossReport> lossReports = DataRepository.LossReport.GetbyAnimalName(AnimalName);
            animalShelterBindingSource.DataSource = animalShelters;
        }
    }
}