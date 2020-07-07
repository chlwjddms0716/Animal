using AnimalShelterManagementSystem.Data;
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

        }

        private void btnFindingReport_Click(object sender, EventArgs e)
        {
            string checkinput = "";
            if (lkuSpecies.EditValue == null)
            {
                checkinput += "종을 선택해주세요.\n";
            }
            if (String.Equals(txbPlace.Text,"") == true )
            {
                checkinput += "장소를 입력해주세요.\n";
            }
            if (dteDate.EditValue == null)
            {
                checkinput += "날짜를 선택해주세요.\n";
            }

            if (string.Equals(checkinput, "") == true)
            {
                FindingReport findingReport = new FindingReport();
                findingReport.Place = txbPlace.Text;
                findingReport.FindingReportId = DataRepository.FindingReport.GetMaxId() + 1;
                findingReport.Date = dteDate.DateTime.Date;
                DataRepository.FindingReport.Insert(findingReport);

                MessageBox.Show("신고되었습니다.");
                Close();
            }
            MessageBox.Show(checkinput);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


