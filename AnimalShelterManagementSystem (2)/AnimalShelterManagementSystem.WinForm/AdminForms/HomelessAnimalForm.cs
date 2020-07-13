using AnimalShelterManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AnimalShelterManagementSystem.WinForm.Forms
{
    public partial class HomelessAnimalForm : Form
    {
        private HomelessAnimal _homelessAnimal = new HomelessAnimal();
        private Species _species= new Species();
        private PhysicalCondition _physicalCondition = new PhysicalCondition();
        private Sex _sex = new Sex();


        public HomelessAnimalForm()
        {
            InitializeComponent();

        }

        public HomelessAnimalForm(HomelessAnimal homelessAnimal) : this()
        {
            _homelessAnimal = homelessAnimal;
        }

        public HomelessAnimalForm(Sex sex)
        {
            _sex = sex;
        }


        public HomelessAnimalForm(PhysicalCondition physicalCondition) : this()
        {
            _physicalCondition = physicalCondition;
        }

        public HomelessAnimalForm(Species species) : this()
        {
            _species = species;
        }

     


        private void WriteToEntity() //DB에 쓰는거
        {
            //콤보박스에서 선택된 값이 _album.ArtistId로 보낸다.
            string checkinput = "";
            if (string.Equals(checkinput, "") == true)
            {
                _homelessAnimal.HomelessAnimalId = DataRepository.HomelessAnimal.GetMaxId() + 1;
                _homelessAnimal.SexId = DataRepository.Sex.GetBy(lueIsMale.Text);
                _homelessAnimal.Feature = txeFeature.Text;
                _homelessAnimal.LatestFindingReport = dteDate.DateTime.Date;
                _homelessAnimal.PictureLink = txePictureLink.Text;
                _homelessAnimal.PhysicalConditionCode = DataRepository.PhysicalCondition.GetBy(luePSC.Text);
                _homelessAnimal.SpeciesCode = DataRepository.Species.GetBy(lueSpeciesCode.Text);
                //MessageBox.Show("저장되었습니다.");

                Close();
            }
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
       

            try
            {
                WriteToEntity();
                if (_homelessAnimal.HomelessAnimalId == 0) //Id의 디폴트가0이라 0이면 db에 insert함
                    DataRepository.HomelessAnimal.Insert(_homelessAnimal);
                
                else
                    DataRepository.HomelessAnimal.Update(_homelessAnimal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void HomelessAnimalForm_Load(object sender, EventArgs e)
        {

            lueSpeciesCode.Text = Convert.ToString(_homelessAnimal.SpeciesCode);
            txeHomelessAnimalId.Text = Convert.ToString(_homelessAnimal.HomelessAnimalId);

            homelessAnimalBindingSource.DataSource = DataRepository.HomelessAnimal.GetAll();
            speciesBindingSource.DataSource = DataRepository.Species.GetAll();
            physicalConditionBindingSource.DataSource = DataRepository.PhysicalCondition.GetAll();
            sexBindingSource.DataSource = DataRepository.Sex.GetAll();

            ReadFromEntity();
        }

        private void ReadFromEntity()
        {

            txeHomelessAnimalId.Text = Convert.ToString(_homelessAnimal.HomelessAnimalId + 1);

            txeName.Text = _homelessAnimal.Name;

    
            txeFeature.Text = _homelessAnimal.Feature;
            dteDate.Text = Convert.ToString(_homelessAnimal.LatestFindingReport);
            txePictureLink.Text = _homelessAnimal.PictureLink;





        }
    }

}
