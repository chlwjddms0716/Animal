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
using System.Diagnostics;

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class LossReportListForm : DevExpress.XtraEditors.XtraForm
    {
        public LossReportListForm()
        {
            InitializeComponent();
        }

      

        private void txeAnimalName_EditValueChanged(object sender, EventArgs e)
        {
            lossReportBindingSource.DataSource = DataRepository.LossReport.Search(txeUserId.Text, txeAnimalName.Text);
        }

        private void txeUserId_EditValueChanged(object sender, EventArgs e)
        {
            lossReportBindingSource.DataSource = DataRepository.LossReport.Search(txeUserId.Text, txeAnimalName.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExcuteInsert()
        {
            LossReport lossReport = new LossReport();

            lossReport.LossReportId = DataRepository.LossReport.GetMaxId() + 1;

            LossReportAdminForm form = new LossReportAdminForm(lossReport);
            form.ShowDialog();
        }

        private void ExecuteDelete()
        {
            LossReport lossReport = lossReportBindingSource.Current as LossReport;

            if (Helpers.Helpers.SureToDelete() == false)
                return;
            if (lossReport == null)
                return;

            DataRepository.LossReport.Delete(lossReport);
            lossReportBindingSource.Remove(lossReport);
        }

        private void ExecuteEdit()
        {
            LossReport lossReport = lossReportBindingSource.Current as LossReport;

            if (lossReport == null)
                return;

            LossReportAdminForm form = new LossReportAdminForm(lossReport);
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txeAnimalName.Text != string.Empty)
            {
                //Todo:
            }
            else
            {
                lossReportBindingSource.DataSource = DataRepository.LossReport.Search(txeUserId.Text, txeAnimalName.Text);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://kimgwajang.tistory.com/guestbook");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ExcuteInsert();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ExecuteEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExecuteDelete();
        }


        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            ExecuteEdit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lossReportBindingSource.DataSource = DataRepository.LossReport.Search(txeUserId.Text, txeAnimalName.Text);
        }

        private void grcLossList_DoubleClick(object sender, EventArgs e)
        {
            ExecuteEdit();
        }
    }
}