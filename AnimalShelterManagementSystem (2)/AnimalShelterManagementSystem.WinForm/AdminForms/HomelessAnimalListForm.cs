using AnimalShelterManagementSystem.Data;

using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraExport.Xls;
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
    public partial class HomelessAnimalListForm : Form
    {
        public HomelessAnimalListForm()
        {
            InitializeComponent();
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
            HomelessAnimal homelessAnimal = new HomelessAnimal();

            homelessAnimal.Name = string.Empty;
            homelessAnimal.Age = 0;
            homelessAnimal.SexId = 0;
            homelessAnimal.Feature = "";
            homelessAnimal.LatestFindingReport = System.DateTime.Now;
            homelessAnimal.PictureLink = string.Empty;
            homelessAnimal.PhysicalConditionCode = 0;
            homelessAnimal.SpeciesCode = 0;

            homelessAnimal.HomelessAnimalId = DataRepository.HomelessAnimal.GetMaxId();

            HomelessAnimalForm form = new HomelessAnimalForm(homelessAnimal);
            form.ShowDialog();


        }


        private void ExecuteDelete()
        {
            HomelessAnimal homelessAnimal = homelessAnimalBindingSource.Current as HomelessAnimal;

            if (homelessAnimal == null)
                return;


            DataRepository.HomelessAnimal.Delete(homelessAnimal);

            homelessAnimalBindingSource.Remove(homelessAnimal);
        }

    }
}
