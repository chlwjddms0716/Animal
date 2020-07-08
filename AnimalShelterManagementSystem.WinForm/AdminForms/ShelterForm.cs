using AnimalShelterManagementSystem.Data;
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
            _animalShelter.Name = txeName.Text;
            _animalShelter.Address = txeAddress.Text;
            _animalShelter.ManagerName = txeManager.Text;
            _animalShelter.PhoneNumber = txePhoneNumber.Text;
            _animalShelter.AnimalShelterId = _animalShelter.AnimalShelterId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            try
            {
                if (_animalShelter.AnimalShelterId == 0)
                    DataRepository.AnimalShelter.Insert(_animalShelter);
                else
                    DataRepository.AnimalShelter.Update(_animalShelter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
