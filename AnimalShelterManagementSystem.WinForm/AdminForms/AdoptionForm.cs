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
    public partial class AdoptionForm : Form
    {
        private Adoption _adoption;
        private Adoption original = new Adoption();
        private int checkinsert;

        public AdoptionForm()
        {
            InitializeComponent();
        }

        public AdoptionForm(Adoption adoption, int checkinsert) : this()
        {
            _adoption = adoption;
            this.checkinsert = checkinsert;
        }

        private void ReadFromEntity()
        {
            txeAnimalName.Text = _adoption.AnimalName;
            txeUserId.Text = _adoption.userLoginId;
            rdgAdoptionStatus.EditValue = _adoption.AdoptionStatus;
        }

        private void WriteToEntity()
        {
            _adoption.AdoptionDate = DateTime.Today;
            //_adoption.AnimalName = txeAnimalName.Text;
            _adoption.HomelessAnimalId = (int)lkuAnimalId.EditValue;
            //_adoption.userLoginId = txeUserId.Text;
            _adoption.UserId = DataRepository.User.GetbyId(txeUserId.Text).UserId;
            //_adoption.AdoptionStatus = (AdoptionStatusType)rdgAdoptionStatus.EditValue;

        }

        string CheckInput()
        {
            string checkinput = "";
            if (String.Equals(txeAnimalName.Text, "") == true)
                checkinput += "동물이름, ";
            if (String.Equals(txeUserId.Text, "") == true)
                checkinput += "유저Id, ";
            if (lkuAnimalId.EditValue is null)
                checkinput += "동물Id, ";
            if (rdgAdoptionStatus.EditValue is null)
                checkinput += "입양상태,";

            return checkinput;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteToEntity();
            CheckInput();

            if (string.Equals(CheckInput(), "") == true)
            {
                if ((DataRepository.Adoption.Get(_adoption.UserId, _adoption.HomelessAnimalId) == null))
                {
                    try
                    {
                        if (checkinsert == 1)
                        {
                            DataRepository.Adoption.Insert(_adoption);
                            MessageBox.Show("추가되었습니다");
                        }
                        else
                        {
                            DataRepository.Adoption.Update(_adoption);
                            MessageBox.Show("수정되었습니다");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if ((_adoption.UserId == original.UserId) && (_adoption.HomelessAnimalId == original.HomelessAnimalId) == true)
                {
                    DataRepository.Adoption.Update(_adoption);
                    MessageBox.Show("수정되었습니다");
                }
                else
                    MessageBox.Show("입양된 기록이 있는 유저&유기동물 기록입니다. 다시 확인해주세요.");

            }
            else
            {
                MessageBox.Show(CheckInput().Remove(CheckInput().Length - 1) + "을(를) 입력해주세요.");
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdoptionForm_Load(object sender, EventArgs e)
        {

            if (checkinsert == 0)
            {
                ReadFromEntity();
                original = _adoption;
            }
            else
            {
                _adoption = new Adoption();

            }
        }

        private void txeAnimalName_EditValueChanged(object sender, EventArgs e)
        {
            string AnimalName = txeAnimalName.Text;
            List<HomelessAnimal> homelessAnimal = DataRepository.HomelessAnimal.GetByAnimalName(AnimalName);
            homelessAnimalBindingSource.DataSource = homelessAnimal;
        }
    }
}
