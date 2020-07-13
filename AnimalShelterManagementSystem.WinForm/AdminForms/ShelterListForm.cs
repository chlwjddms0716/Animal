using AnimalShelterManagementSystem.Data;
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
    public partial class ShelterListForm : DevExpress.XtraEditors.XtraForm
    {

        public ShelterListForm()
        {
            InitializeComponent();
        }

        private void Shelter_Load(object sender, EventArgs e)
        {
            AnimalShelterName.DataSource = DataRepository.AnimalShelter.GetAll();
            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.Search(txeAddress.Text, 0);
        }
        private void lkuShelterName_EditValueChanged(object sender, EventArgs e)
        {
            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.Search(txeAddress.Text, (int)(lkuShelterName.EditValue));
        }

        private void txeAddress_EditValueChanged(object sender, EventArgs e)
        {
            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.Search(txeAddress.Text, (int)(lkuShelterName.EditValue));
        }

        private void ExcuteInsert()
        {
            AnimalShelter animalShelter = new AnimalShelter();

            animalShelter.Name = string.Empty;
            animalShelter.Address = string.Empty;
            animalShelter.PhoneNumber = string.Empty;
            animalShelter.ManagerName = string.Empty;

            animalShelter.AnimalShelterId = DataRepository.AnimalShelter.GetMaxId() + 1;

            ShelterForm shelter = new ShelterForm(animalShelter);
            shelter.ShowDialog();
        }

        private void ExecuteDelete()
        {
            AnimalShelter animalShelter = animalShelterBindingSource.Current as AnimalShelter;

            if (Helpers.Helpers.SureToDelete() == false)
                return;
            if (animalShelter == null)
                return;



            DataRepository.AnimalShelter.Delete(animalShelter);

            animalShelterBindingSource.Remove(animalShelter);
        }

        private void ExecuteEdit()
        {
            AnimalShelter animalShelter = animalShelterBindingSource.Current as AnimalShelter;

            if (animalShelter == null)
                return;

            ShelterForm shelter = new ShelterForm(animalShelter);
            shelter.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.Search(txeAddress.Text, (int)(lkuShelterName.EditValue));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ExecuteEdit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.Search(txeAddress.Text, (int)(lkuShelterName.EditValue));
        }
    }
}
