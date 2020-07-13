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

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(EditUserInformation))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            EditUserInformation editUserInformation = new EditUserInformation();
            editUserInformation.MdiParent = this;
            editUserInformation.WindowState = FormWindowState.Maximized;
            editUserInformation.Show();
        }

        private void btnLoss_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(LossReportForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            LossReportForm lossReportForm = new LossReportForm();
            lossReportForm.MdiParent = this;
            lossReportForm.WindowState = FormWindowState.Maximized;
            lossReportForm.Show();
        }

        private void btnAdoption_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(AdoptionRequest))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            AdoptionRequest adoptionRequest = new AdoptionRequest();
            adoptionRequest.MdiParent = this;
            adoptionRequest.WindowState = FormWindowState.Maximized;
            adoptionRequest.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(FindingReportForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            FindingReportForm findingReportForm = new FindingReportForm();
            findingReportForm.MdiParent = this;
            findingReportForm.WindowState = FormWindowState.Maximized;
            findingReportForm.Show();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            AnimalImage form = new AnimalImage();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
