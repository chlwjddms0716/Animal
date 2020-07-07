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
using AnimalShelterManagementSystem.WinForm.UserForms;

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class UserMenu : DevExpress.XtraEditors.XtraForm
    {
        private int userId;
        public UserMenu()
        {
            InitializeComponent();
            userId = 2;
        }

        public UserMenu(int UserId) 
        {
            InitializeComponent();
            userId = UserId;
        }

        private void btnEditUserInformation_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditUserInformation editUserInformation = new EditUserInformation(userId);
            editUserInformation.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnLossReport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LossReportForm lossReport = new LossReportForm(userId);
            lossReport.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnAdoption_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AdoptionRequest adopt = new AdoptionRequest(userId);
            adopt.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnFindReport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FindingReportForm findingReportForm = new FindingReportForm();
            findingReportForm.ShowDialog();
            Cursor = Cursors.Arrow;
        }
    }
}