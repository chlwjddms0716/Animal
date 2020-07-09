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
            List<HomelessAnimal> animals = DataRepository.Adoption.GetAnimalsByUserName(txeUserName.Text);

            homelessAnimalBindingSource.DataSource = animals;


            //if (String.Equals(tebUserId.Text, "") == true)
            //{
            //    MessageBox.Show("유저아이디를 입력해주세요");
            //}
            /*
            adoption.UserId = userId;
            DataRepository.Adoption.Insert(adoption);
            HomelessAnimal homelessAnimal = new HomelessAnimal();
            homelessAnimal = DataRepository.HomelessAnimal.Get(adoption.HomelessAnimalId);
            homelessAnimal.IsAdopted = true;
            DataRepository.HomelessAnimal.Update(homelessAnimal);

            userId = DataRepository.HomelessAnimal.GetMaxId() + 1;
            userId.Species = Convert.ToInt32(cbbSpecies.SelectedValue);
            _homelessAnimal.Age = Convert.ToInt32(txeAge.Text);
            _homelessAnimal.Species = Convert.ToInt32(cbbSpecies.SelectedValue);
            _homelessAnimal.Feature = txeFeature.Text;
            _homelessAnimal.Gender = Convert.ToInt32(cbbGender.SelectedValue);
            _homelessAnimal.PhysicalCondition = Convert.ToInt32(cbbPSC.SelectedValue);
            _homelessAnimal.LatestFindingReport = dteLatestFindingReport.DateTime.Date;
            _homelessAnimal.PictureLink = txePictureLink.Text;
            _homelessAnimal.AnimalShelterId = Convert.ToInt32(cbbAnimalShelter.SelectedValue);
           
             */

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
