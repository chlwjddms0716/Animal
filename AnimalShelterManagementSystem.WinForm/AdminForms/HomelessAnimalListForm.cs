using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.WinForm.AdminForms;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraExport.Xls;
using DevExpress.XtraPrinting.Native;
using AnimalShelterManagementSystem.WinForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.Forms
{
    public partial class HomelessAnimalListForm : DevExpress.XtraEditors.XtraForm
    {
        private int homelessAnimalId;

        public HomelessAnimalListForm()
        {
            InitializeComponent();
        }

        public HomelessAnimalListForm(int HomelessAnimalId)
        {
            InitializeComponent();
            homelessAnimalId = HomelessAnimalId;
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

            Cursor = Cursors.WaitCursor;
            HomelessAnimal homelessAnimal = new HomelessAnimal();
            homelessAnimal.HomelessAnimalId = DataRepository.HomelessAnimal.GetMaxId() + 1;
            homelessAnimal.Name = string.Empty;
            homelessAnimal.Age = 0;
            homelessAnimal.Feature = "";
            homelessAnimal.LatestFindingReport = System.DateTime.Today;
            homelessAnimal.PictureLink = string.Empty;


            HomelessAnimalForm form = new HomelessAnimalForm(homelessAnimal);
            form.ShowDialog();
            Cursor = Cursors.Arrow;


        }

        private void ExcuteUpdate()
        {
            HomelessAnimal homelessAnimal = homelessAnimalBindingSource.Current as HomelessAnimal;

            if (homelessAnimal == null)
                return;

            HomelessAnimalForm form = new HomelessAnimalForm(homelessAnimal);

            form.ShowDialog();


        }




        private void ExecuteDelete()
        {
            HomelessAnimal homelessAnimal = homelessAnimalBindingSource.Current as HomelessAnimal;

            if (homelessAnimal == null)
                return;
            if (Helpers.Helpers.SureToDelete() == false)
                return;


            DataRepository.HomelessAnimal.Delete(homelessAnimal);

            homelessAnimalBindingSource.Remove(homelessAnimal);
        }

       

        private void 수정UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcuteUpdate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ExcuteUpdate();
        }

        private void searchControl1_LoadButtonClicked_1(object sender, UserControls.SearchControl.LoadButtonClickedEventArgs e)
        {
            List<HomelessAnimal> homelessAnimals = DataRepository.HomelessAnimal.SearchWithHomelessAnimal(e.AnimalShelterId, (int)e.SpeciesCode, e.Gender, e.FoundDateFrom, e.FoundDateTo);
            //List<AnimalShelter> AnimalShelters = DataRepository.AnimalShelter.GetbyShelterId(e.AnimalShelterId);
            

            homelessAnimalBindingSource.DataSource = homelessAnimals;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ExcuteUpdate();
        }

        private void HomelessAnimalListForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}