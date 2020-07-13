using AnimalShelterManagementSystem.WinForm.Forms;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class AdminMenu : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(UserListForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    //frm.Focus();
                    return;
                }
            }

            UserListForm userManagement = new UserListForm();
            userManagement.MdiParent = this;
            userManagement.WindowState = FormWindowState.Maximized;
            userManagement.Show();
            
        }

        private void btnAdoption_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(AdoptionListForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    //frm.Focus();
                    return;
                }
            }

            AdoptionListForm adoptionManagement = new AdoptionListForm();
            adoptionManagement.MdiParent = this;
            adoptionManagement.WindowState = FormWindowState.Maximized;
            adoptionManagement.Show();
        }

        private void btnShelter_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ShelterListForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    //frm.Focus();
                    return;
                }
            }

            ShelterListForm shelterListForm = new ShelterListForm();
            shelterListForm.MdiParent = this;
            shelterListForm.WindowState = FormWindowState.Maximized;
            shelterListForm.Show();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(HomelessAnimalListForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    //frm.Focus();
                    return;
                }
            }

            HomelessAnimalListForm homelessAnimalListForm = new HomelessAnimalListForm();
            homelessAnimalListForm.MdiParent = this;
            homelessAnimalListForm.WindowState = FormWindowState.Maximized;
            homelessAnimalListForm.Show();
        }

        private void btnFindReport_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(FindingReportListForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    //frm.Focus();
                    return;
                }
            }

            FindingReportListForm findingManagementForm = new FindingReportListForm();
            findingManagementForm.MdiParent = this;
            findingManagementForm.WindowState = FormWindowState.Maximized;
            findingManagementForm.Show();

        }

        private void btnLossReport_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(LossReportListForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    //frm.Focus();
                    return;
                }
            }

            LossReportListForm lossReportListForm = new LossReportListForm();
            lossReportListForm.MdiParent = this;
            lossReportListForm.WindowState = FormWindowState.Maximized;
            lossReportListForm.Show();
        }



    }
}
    