using AnimalShelterManagementSystem.Data;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraExport.Helpers;
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
    public partial class ShelterForm : Form
    {
        private AnimalShelter _animalShelter = new AnimalShelter();


        public ShelterForm()
        {
            InitializeComponent();

        }

        public ShelterForm(AnimalShelter animalShelter) : this()
        {
            _animalShelter = animalShelter;
        }

        private void ReadFromEntity()
        {
            txeName.EditValue = _animalShelter.Name.ToString();
            txeAddress.EditValue = _animalShelter.Address.ToString();
            txeManager.EditValue = _animalShelter.ManagerName.ToString();
            txePhoneNumber.EditValue = _animalShelter.PhoneNumber.ToString();
            txeShelterId.EditValue = _animalShelter.AnimalShelterId;
        }

        private void WriteToEntity()
        {
            txeShelterId.EditValue = _animalShelter.AnimalShelterId;

            _animalShelter.Name = txeName.Text;
            _animalShelter.Address = txeAddress.Text;
            _animalShelter.ManagerName = txeManager.Text;
            _animalShelter.PhoneNumber = txePhoneNumber.Text;
            _animalShelter.AnimalShelterId = _animalShelter.AnimalShelterId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            WriteToEntity();

            string checkinput = "";
            if (String.Equals(txeName.Text, "") == true)
                checkinput += "이름, ";
            if (String.Equals(txeAddress.Text, "") == true)
                checkinput += "주소, ";
            if (String.Equals(txeManager.Text, "") == true)
                checkinput += "담당자이름, ";
            if (String.Equals(txePhoneNumber.Text, "") == true)
                checkinput += "전화번호";

            if (string.Equals(checkinput, "") == true)
            {
                try
                {
                    if (_animalShelter.AnimalShelterId == DataRepository.AnimalShelter.GetMaxId() + 1)
                    {
                        DataRepository.AnimalShelter.Insert(_animalShelter);
                        MessageBox.Show("추가되었습니다");
                    }
                    else
                        DataRepository.AnimalShelter.Update(_animalShelter);
                    MessageBox.Show("수정되었습니다");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show(checkinput+"을(를) 입력해주세요.");
            }
            Close();
        }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

        private void ShelterForm_Load(object sender, EventArgs e)
        {
            ReadFromEntity();
        } 
    }
    }

