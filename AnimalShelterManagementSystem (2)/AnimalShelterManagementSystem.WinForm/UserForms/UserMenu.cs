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

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class UserMenu : DevExpress.XtraEditors.XtraForm
    {
        private int userId;
        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }
        private void LoadAdoptionForm(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AdoptionRequest adoptionRequest = new AdoptionRequest(userId);
            adoptionRequest.Show();
            Cursor = Cursors.Arrow;
        }

        private void LoadEditUserInformationForm(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //      EditUserInformation editUserInformation = new EditUserInformation(UserId);
            EditUserInformation editUserInformation = new EditUserInformation(2);
            editUserInformation.Show();
            Cursor = Cursors.Arrow;
        }

        private void LoadLossReportForm(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //      EditUserInformation editUserInformation = new EditUserInformation(UserId);
            LossReport lossReport = new LossReport(2);
            lossReport.Show();
            Cursor = Cursors.Arrow;
        }

        private void btnAdoption_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //      EditUserInformation editUserInformation = new EditUserInformation(UserId);
            AdoptionRequest adopt = new AdoptionRequest();
            adopt.Show();
            Cursor = Cursors.Arrow;
        }

        private void btnFindReport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //      EditUserInformation editUserInformation = new EditUserInformation(UserId);
            Cursor = Cursors.Arrow;
        }
    }
}