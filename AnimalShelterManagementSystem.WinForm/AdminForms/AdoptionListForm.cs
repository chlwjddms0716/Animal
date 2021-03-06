﻿using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class AdoptionListForm : DevExpress.XtraEditors.XtraForm
    {

        Adoption adoption = new Adoption();

        public AdoptionListForm()
        {
            InitializeComponent();
        }

        private void AdoptionManagement_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            LoadAdoptions();
        }

        private void LoadAdoptions()
        {
            adoptionBindingSource.DataSource = DataRepository.Adoption.Search(txeId.Text, (int)rdgAdoptionStatus.EditValue);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ExcuteInsert();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            ExecuteDelete();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ExecuteEdit();
        }

        private void ExcuteInsert()
        {
            AdoptionForm form = new AdoptionForm(adoption, 1);
            form.ShowDialog();
        }

        private void ExecuteDelete()
        {
            Adoption adoption = adoptionBindingSource.Current as Adoption;


            if (Helpers.Helpers.SureToDelete() == false)
                return;
            if (adoption == null)
                return;


            DataRepository.Adoption.Delete(adoption);

            adoptionBindingSource.Remove(adoption);
        }
        
        private void ExecuteEdit()
        {
            Adoption adoption = adoptionBindingSource.Current as Adoption;

            if (adoption == null)
                return;

            AdoptionForm form = new AdoptionForm(adoption, 0);
            form.ShowDialog();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            adoptionBindingSource.DataSource = DataRepository.Adoption.Search(txeId.Text, (int)rdgAdoptionStatus.EditValue);
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://kimgwajang.tistory.com/guestbook");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            adoptionBindingSource.DataSource = DataRepository.Adoption.Search(txeId.Text, (int)rdgAdoptionStatus.EditValue);
        }

        private void grcAdoptionList_DoubleClick(object sender, EventArgs e)
        {
            ExecuteEdit();
        }
    }
}
