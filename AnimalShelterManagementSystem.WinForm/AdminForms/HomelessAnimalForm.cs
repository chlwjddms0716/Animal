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
using DevExpress.ClipboardSource.SpreadsheetML;

namespace AnimalShelterManagementSystem.WinForm.Forms
{
    public partial class HomelessAnimalForm : DevExpress.XtraEditors.XtraForm
    {
        private HomelessAnimal _homelessAnimal;
        private bool IsProtected = false;
        private FindingReport findingReport;

        public HomelessAnimalForm()
        {
            InitializeComponent();

        }

        public HomelessAnimalForm(HomelessAnimal homelessAnimal) : this()
        {
            _homelessAnimal = homelessAnimal;
        }

        public HomelessAnimalForm(FindingReport findingReport) : this()
        {
            _homelessAnimal = new HomelessAnimal();
            this.findingReport = findingReport;
            _homelessAnimal.HomelessAnimalId = DataRepository.HomelessAnimal.GetMaxId() + 1;
            _homelessAnimal.Species = findingReport.Species;
            _homelessAnimal.SpeciesName = findingReport.SpeciesName;
            IsProtected = true;
        
        }

        //안녕


        private void WriteToEntity() //DB에 쓰는거
        {
            //콤보박스에서 선택된 값이 _album.ArtistId로 보낸다.
            string checkinput = "";
            if (string.Equals(checkinput, "") == true)
            {
               
                _homelessAnimal.Name = txeName.Text;
                _homelessAnimal.Age = Convert.ToInt32(txeAge.Text);
                _homelessAnimal.Species = Convert.ToInt32(cbbSpecies.SelectedValue);
                _homelessAnimal.Feature = txeFeature.Text;
                _homelessAnimal.Gender = Convert.ToInt32(cbbGender.SelectedValue);
                _homelessAnimal.PhysicalCondition = Convert.ToInt32(cbbPSC.SelectedValue);
                _homelessAnimal.LatestFindingReport = dteLatestFindingReport.DateTime.Date;
                _homelessAnimal.PictureLink = txePictureLink.Text;
                _homelessAnimal.AnimalShelterId = Convert.ToInt32(cbbAnimalShelter.SelectedValue);

               

                MessageBox.Show("저장되었습니다.");

                Close();
            }
        }
      
        string CheckInput()
        {
            string checkinput = "";
            if (cbbSpecies.Text == null)
            {
                checkinput += "종, ";
            }
            if (cbbGender.Text == null)
            {
                checkinput += "성별,";
            }
            if (cbbPSC.Text == null)
            {
                checkinput += "건강상태, ";
            }
            if (String.Equals(txeName.Text, "") == true)
            {
                checkinput += "이름, ";
            }
            if (String.Equals(txeAge.Text, "") == true)
            {
                checkinput += "나이, ";
            }
            if (String.Equals(txeFeature.Text, "") == true)
            {
                checkinput += "특징, ";
            }
            if (String.Equals(txePictureLink.Text, "") == true)
            {
                checkinput += "사진링크, ";
            }
            if (dteLatestFindingReport.EditValue == null)
            {
                checkinput += "날짜, ";
            }
            return checkinput;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            if (string.Equals(CheckInput(), "") == true)
            {
               

                try
                {
                    if (IsProtected == true)
                    {
                        DataRepository.HomelessAnimal.Insert(_homelessAnimal);
                        FindingReportRecord findingReportRecord = new FindingReportRecord();
                        findingReportRecord.AnimalShelterId = _homelessAnimal.AnimalShelterId;
                        findingReportRecord.HomelessAnimalId = _homelessAnimal.HomelessAnimalId;
                        findingReportRecord.FindingReportId = findingReport.FindingReportId;
                        findingReportRecord.ProtectionStartDate = DateTime.Today;
                        DataRepository.FindingReportRecord.Insert(findingReportRecord);
                        IsProtected = false;
                    }
                    if (_homelessAnimal.HomelessAnimalId == DataRepository.HomelessAnimal.GetMaxId() + 1) //Id의 디폴트가0이라 0이면 db에 insert함
                        DataRepository.HomelessAnimal.Insert(_homelessAnimal);

                       

                    else
                        DataRepository.HomelessAnimal.Update(_homelessAnimal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Close();

                return;

            }
            MessageBox.Show($"{CheckInput().Remove(CheckInput().Length - 2)}을(를) 입력해주세요.");
        }

        private void HomelessAnimalForm_Load(object sender, EventArgs e)
        {

           // txeHomelessAnimalId.Text = Convert.ToString(_homelessAnimal.HomelessAnimalId + 10);
            homelessAnimalBindingSource.DataSource = DataRepository.HomelessAnimal.GetAll();
            cbbGender.DataSource = Enum.GetValues(typeof(Genders));
            cbbSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            cbbPSC.DataSource = Enum.GetValues(typeof(PhysicalConditionType));
            dteLatestFindingReport.DateTime = DateTime.Today;
            animalShelterBindingSource.DataSource = DataRepository.AnimalShelter.GetAll();
            ReadFromEntity();
        }

        private void ReadFromEntity()
        {

            txeHomelessAnimalId.Text = Convert.ToString(_homelessAnimal.HomelessAnimalId);
            txeName.Text = _homelessAnimal.Name;
            txeAge.Text = Convert.ToString(_homelessAnimal.Age);
            txeFeature.Text = _homelessAnimal.Feature;
            dteLatestFindingReport.Text = Convert.ToString(_homelessAnimal.LatestFindingReport);
            txePictureLink.Text = _homelessAnimal.PictureLink;

        }

       

        private void txeAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }


          
        }
    }

}
