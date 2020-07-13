using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.Models;
using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.UserForms
{
    public partial class FindingReportForm : DevExpress.XtraEditors.XtraForm
    {
        private FindingReport _findingReport;



        public FindingReportForm()
        {
            InitializeComponent();
            _findingReport = new FindingReport();

        }


        public FindingReportForm(FindingReport findingReport) : this()
        {
            _findingReport = findingReport;

        }


        private void FindingReportForm_Load(object sender, EventArgs e)
        {
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            cbxSpecies.SelectedItem = null;
        }



        string CheckInput()
        {
            string checkinput = "";
            if (cbxSpecies.Text == null)
            {
                checkinput += "종, ";
            }
            if (String.Equals(txbPlace.Text, "") == true)
            {
                checkinput += "장소, ";
            }
            if (dteDate.EditValue == null)
            {
                checkinput += "날짜, ";
            }

            return checkinput;
        }
        private void btnFindingReport_Click(object sender, EventArgs e)
        {

            if (string.Equals(CheckInput(), "") == true)
            {
                FindingReport findingReport = new FindingReport();
                findingReport.Place = txbPlace.Text;
                findingReport.FindingReportId = DataRepository.FindingReport.GetMaxId() + 1;
                findingReport.Date = dteDate.DateTime.Date;
                findingReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
                findingReport.Picture = ConvertImageToBinary(Image.FromFile(txePictureLink.Text));

                DataRepository.FindingReport.Insert(findingReport);

                MessageBox.Show("신고되었습니다.");

                Close();
                return;
            }
            MessageBox.Show($"{CheckInput().Remove(CheckInput().Length - 2)}을(를) 입력해주세요.");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPictureLink_Click(object sender, EventArgs e)
        {
            PictureSaveForm pictureSaveForm = new PictureSaveForm(_findingReport);
            pictureSaveForm.ShowDialog();
            //MessageBox.Show(PictureSaveForm.Address);
            txePictureLink.Text = PictureSaveForm.Address;
        }
    }
}


