using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.Models;
using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.UserForms
{
    public partial class FindingReportForm : Form
    {
        public FindingReportForm()
        {
            InitializeComponent();
        }

        private void FindingReportForm_Load(object sender, EventArgs e)
        {
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            cbxSpecies.SelectedItem = null;
        }

        private void btnFindingReport_Click(object sender, EventArgs e)
        {
            string checkinput = "";
            if (cbxSpecies.Text == null)
            {
                checkinput += "종, ";
            }
            if (String.Equals(txbPlace.Text,"") == true )
            {
                checkinput += "장소, ";
            }
            if (dteDate.EditValue == null)
            {
                checkinput += "날짜, ";
            }

            if (string.Equals(checkinput, "") == true)
            {
                FindingReport findingReport = new FindingReport();
                findingReport.Place = txbPlace.Text;
                findingReport.FindingReportId = DataRepository.FindingReport.GetMaxId() + 1;
                findingReport.Date = dteDate.DateTime.Date;
                findingReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
                DataRepository.FindingReport.Insert(findingReport);

                MessageBox.Show("신고되었습니다.");
                Close();
            }
            MessageBox.Show(checkinput + "를(을) 입력해주세요.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


