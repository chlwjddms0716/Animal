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


        public HomelessAnimalForm()
        {
            InitializeComponent();

        }

        public HomelessAnimalForm(HomelessAnimal homelessAnimal) : this()
        {
            _homelessAnimal = homelessAnimal;
        }




        private void WriteToEntity() //DB에 쓰는거
        {
            //콤보박스에서 선택된 값이 _album.ArtistId로 보낸다.
            string checkinput = "";
            if (string.Equals(checkinput, "") == true)
            {
              _homelessAnimal.HomelessAnimalId = DataRepository.HomelessAnimal.GetMaxId() + 1;
                _homelessAnimal.Name = txeName.Text;
                _homelessAnimal.Age = Convert.ToInt32(txeAge.Text);
                
                _homelessAnimal.Feature = txeFeature.Text;
                _homelessAnimal.LatestFindingReport = dteDate.DateTime.Date;
                _homelessAnimal.PictureLink = txePictureLink.Text;


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

            cbbSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            txeHomelessAnimalId.Text = Convert.ToString(_homelessAnimal.HomelessAnimalId);
            homelessAnimalBindingSource.DataSource = DataRepository.HomelessAnimal.GetAll();


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
