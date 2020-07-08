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
    public partial class ShelterListForm : Form
    {
        public ShelterListForm()
        {
            InitializeComponent();
        }

        private void Shelter_Load(object sender, EventArgs e)
        {
            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.GetAll();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int shelterId = (int)(lkuShelterName.EditValue);
            List<AnimalShelter> animalShelters = DataRepository.AnimalShelter.GetbyShelterId(shelterId);
            animalShelterBindingSource.DataSource = animalShelters;
        }

        private void txeAddress_EditValueChanged(object sender, EventArgs e)
        {
            string Address = txeAddress.Text;
            List<AnimalShelter> animalShelters = DataRepository.AnimalShelter.SearchWithAddress(Address);
            animalShelterBindingSource.DataSource = animalShelters;
        }

        private void 추가IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcuteInsert();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExcuteInsert();
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcuteClose();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExcuteClose();
        }


        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ExcuteHelp();
        }
        private void 정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcuteHelp();
        }
        private void 도움말HToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcuteHelp();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ExecuteDelete();
        }
        private void 삭제DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteDelete();
        }

        private void ExcuteHelp()
        {
            Process.Start("https://kimgwajang.tistory.com/guestbook");
        }
        private void ExcuteClose()
        {
            Close();
        }

        private void ExcuteInsert()
        {
            AnimalShelter animalShelter = new AnimalShelter();

            animalShelter.Name = string.Empty;
            animalShelter.Address = string.Empty;
            animalShelter.PhoneNumber = string.Empty;
            animalShelter.ManagerName = string.Empty;

            animalShelter.AnimalShelterId = DataRepository.AnimalShelter.GetMaxId();

            ShelterForm shelter = new ShelterForm(animalShelter);
            shelter.ShowDialog();
        }


        private void ExecuteDelete()
        {
            AnimalShelter animalShelter = animalShelterBindingSource.Current as AnimalShelter;

            if (animalShelter == null)
                return;


            DataRepository.HomelessAnimal.Delete(animalShelter.AnimalShelterId);

            animalShelterBindingSource.Remove(animalShelter);
        }

    }
}
