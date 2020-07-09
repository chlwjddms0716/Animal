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
    public partial class AdoptionManagement : Form
    {
        List<Adoption> adoptionList = new List<Adoption>();
        List<Adoption> FilteredById;
        List<Adoption> FilteredByAdoptionStatus;
        private string Id;
        private int currentStatus;
        Adoption adoption = new Adoption();

        public AdoptionManagement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void querybyId()
        {
            if (String.Equals(txeId.Text, "") == false)
                FilteredById = adoptionList.Where(x => x.userLoginId.Contains(txeId.Text) == true).ToList();
            else
                FilteredById = adoptionList;
        }
        private void querybyAdoptionStatus()
        {
            querybyId();
            if (currentStatus != 2)
                FilteredByAdoptionStatus = FilteredById.Where(x => x.AdoptionStatus == (AdoptionStatusType)currentStatus).ToList();
            else
                FilteredByAdoptionStatus = FilteredById;
            homelessAnimalBindingSource.DataSource = FilteredByAdoptionStatus;
        }

        private void AdoptionManagement_Load(object sender, EventArgs e)
        {
            adoptionList = DataRepository.Adoption.GetEvery();
            querybyAdoptionStatus();
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

            if (adoption == null)
                return;


            DataRepository.Adoption.Delete(adoption);

            adoptionBindingSource.Remove(adoption);
        }

        private void ExecuteEdit()
        {
            Adoption adoption = adoptionBindingSource.Current as Adoption;

            if(adoption == null)
                return;

            AdoptionForm form = new AdoptionForm(adoption, 0);
            form.ShowDialog();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            adoptionList = DataRepository.Adoption.GetEvery();
            querybyAdoptionStatus();
        }

        private void txeId_TextChanged(object sender, EventArgs e)
        {
            Id = txeId.Text;
            querybyAdoptionStatus();
        }

        private void rdgAdoptionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStatus = (int)rdgAdoptionStatus.EditValue;
            querybyAdoptionStatus();
        }
    }
}
