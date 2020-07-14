using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AnimalShelterManagementSystem.Models;
using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.WinForm.UserForms;
using System.IO;
using System.Drawing.Imaging;

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class LossReportAdminForm : DevExpress.XtraEditors.XtraForm
    {
        private LossReport _lossReport = new LossReport();

        public LossReportAdminForm()
        {
            InitializeComponent();
        }

        public LossReportAdminForm(LossReport lossReport) : this()
        {
            _lossReport = lossReport;
        }


        private void ReadFromEntity()
        {
            txeId.EditValue = _lossReport.userLoginId;
            txeAnimalName.EditValue = _lossReport.AnimalName;
            cbxSpecies.SelectedItem = _lossReport.SpeciesName;
            dteDate.EditValue = _lossReport.Date;
            txePlace.EditValue = _lossReport.Place;
            txePictureLink.EditValue = _lossReport.Picture;
        }

        private void WriteToEntity()
        {
            
            _lossReport.userLoginId = txeId.Text;
            _lossReport.AnimalName = txeAnimalName.Text;
            _lossReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
            _lossReport.Date = dteDate.DateTime.Date;
            _lossReport.Place = txePlace.Text;
           // _lossReport.Picture = txePictureLink.Text;
            _lossReport.LossReportId = _lossReport.LossReportId;
            _lossReport.UserId = DataRepository.User.GetbyId(txeId.Text).UserId;
            _lossReport.Picture = ConvertImageToBinary(Image.FromFile(txePictureLink.Text));

        }

        string CheckInput()
        {
            string checkinput = "";
            if (String.Equals(txeId.Text, "") == true)
                checkinput += "Id, ";
            if (String.Equals(txeAnimalName.Text, "") == true)
                checkinput += "이름, ";
            if (String.Equals(cbxSpecies.Text, "") == true)
                checkinput += "종, ";
            if (dteDate.EditValue == null)
                checkinput += "날짜, ";
            if (String.Equals(txePlace.Text, "") == true)
                checkinput += "장소, ";
            if (String.Equals(txePictureLink.Text, "") == true)
                checkinput += "사진 링크, ";

            return checkinput;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            if (string.Equals(CheckInput(), "") == true)
            {
                try
                {
                    if (_lossReport.LossReportId == DataRepository.LossReport.GetMaxId() + 1)
                    {
                        DataRepository.LossReport.Insert(_lossReport);
                        MessageBox.Show("추가되었습니다");
                    }
                    else
                    {
                        DataRepository.LossReport.Update(_lossReport);
                        MessageBox.Show("수정되었습니다");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show($"{CheckInput().Remove(CheckInput().Length - 2)}을(를) 입력해주세요.");
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LossReportAdminForm_Load(object sender, EventArgs e)
        {
             cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            ReadFromEntity();
        }

        private void btnPictureLink_Click(object sender, EventArgs e)
        {
            PictureSaveForm pictureSaveForm = new PictureSaveForm(_lossReport);
            pictureSaveForm.ShowDialog();
            //MessageBox.Show(PictureSaveForm.Address);
            txePictureLink.Text = PictureSaveForm.Address;
        }

        private byte[] ConvertImageToBinary(Image image)
        {

            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (ImageFormat.Jpeg.Equals(image.RawFormat))
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                }
                else if (ImageFormat.Png.Equals(image.RawFormat))
                {
                    image.Save(memoryStream, ImageFormat.Png);
                }
                else if (ImageFormat.Gif.Equals(image.RawFormat))
                {
                    image.Save(memoryStream, ImageFormat.Gif);
                }

                return memoryStream.ToArray();

            }


        }

    }
}