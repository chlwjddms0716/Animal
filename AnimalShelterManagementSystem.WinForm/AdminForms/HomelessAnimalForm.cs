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
using AnimalShelterManagementSystem.Models;

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
                _homelessAnimal.Feature = txeFeature.Text;
                _homelessAnimal.LatestFindingReport = dteLatestFindingReport.DateTime.Date;
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
            string checkinput = "";
            if (cbbSpecies.Text == null)
            {
                checkinput += "종을 선택해주세요.\n";
            }
            if (cbbGender.Text == null)
            {
                checkinput += "성별을 선택해주세요.\n";
            }
            if (cbbPSC.Text == null)
            {
                checkinput += "건강상태를 선택해주세요.\n";
            }
            if (String.Equals(txeName.Text, "") == true)
            {
                checkinput += "이름을 입력해주세요.\n";
            }
            if (String.Equals(txeAge.Text, "") == true)
            {
                checkinput += "나이를 입력해주세요.\n";
            }
            if (String.Equals(txeFeature.Text, "") == true)
            {
                checkinput += "특징을 입력해주세요.\n";
            }
            if (String.Equals(txePictureLink.Text, "") == true)
            {
                checkinput += "사진링크를 입력해주세요.\n";
            }
            if (dteLatestFindingReport.EditValue == null)
            {
                checkinput += "날짜를 선택해주세요.\n";
            }
            if (string.Equals(checkinput, "") == true)
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
            MessageBox.Show(checkinput);
        }

        private void HomelessAnimalForm_Load(object sender, EventArgs e)
        {

           // txeHomelessAnimalId.Text = Convert.ToString(_homelessAnimal.HomelessAnimalId + 10);
            homelessAnimalBindingSource.DataSource = DataRepository.HomelessAnimal.GetAll();
            cbbGender.DataSource = Enum.GetValues(typeof(Genders));
            cbbSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            cbbPSC.DataSource = Enum.GetValues(typeof(PhysicalConditionType));
            dteLatestFindingReport.DateTime = DateTime.Now;
            
            ReadFromEntity();
        }

        private void ReadFromEntity()
        {

            txeHomelessAnimalId.Text = Convert.ToString(_homelessAnimal.HomelessAnimalId + 1);

            txeName.Text = _homelessAnimal.Name;

    
            txeFeature.Text = _homelessAnimal.Feature;
            dteLatestFindingReport.Text = Convert.ToString(_homelessAnimal.LatestFindingReport);
            txePictureLink.Text = _homelessAnimal.PictureLink;





        }
    }

}
