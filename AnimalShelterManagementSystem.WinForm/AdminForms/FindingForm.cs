       using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.Models;
using AnimalShelterManagementSystem.WinForm.Forms;
using AnimalShelterManagementSystem.WinForm.UserForms;
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

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class FindingForm : DevExpress.XtraEditors.XtraForm
    {
        private FindingReport findingReport;
        private bool WasInShelter;
        private bool split;

        public FindingForm()
        {
            InitializeComponent();
            findingReport = new FindingReport();

        }

        public FindingForm(FindingReport findingReport)
        {
            InitializeComponent();
            this.findingReport = findingReport;
            cbxSpecies.SelectedItem = findingReport.Species;
            dteDate.DateTime = findingReport.Date;
            txbPlace.Text = findingReport.Place;
            rdgIsInShelter.EditValue = findingReport.IsInShelter? 1 : 0;
            WasInShelter = findingReport.IsInShelter;
        }

        private void InShelter()
        {
            HomelessAnimal homelessAnimal = new HomelessAnimal();
            homelessAnimal.Species = findingReport.Species;
            homelessAnimal.HomelessAnimalId = DataRepository.HomelessAnimal.GetMaxId() + 1;
            HomelessAnimalForm homelessAnimalForm = new HomelessAnimalForm(homelessAnimal);
            homelessAnimalForm.ShowDialog();

            FindingReportRecord findingReportRecord = new FindingReportRecord(); 
        }

        private void Add()
        {
            WasInShelter = true;
            findingReport.FindingReportId = DataRepository.FindingReport.GetMaxId() + 1;
            findingReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
            findingReport.Date = dteDate.DateTime;
            findingReport.Place = txbPlace.Text;
            findingReport.IsInShelter = Convert.ToBoolean(rdgIsInShelter.EditValue);
            findingReport.Picture = ConvertImageToBinary(Image.FromFile(txePictureLink.Text));
            if (findingReport.IsInShelter == true)
            {
                //InShelter();
            
            }
            DataRepository.FindingReport.Insert(findingReport);
            LoadHomelessAnimal();
            Close();
            return;


        }

        private void Edit()
        {
            findingReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
            findingReport.Date = dteDate.DateTime;
            findingReport.Place = txbPlace.Text;
            findingReport.IsInShelter = Convert.ToBoolean(rdgIsInShelter.EditValue);
            DataRepository.FindingReport.Update(findingReport);
            LoadHomelessAnimal();
            Close();
            return;

        }

        private void FindingForm_Load(object sender, EventArgs e)
        {
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
        }

        private void LoadHomelessAnimal()
        {
            if (findingReport.IsInShelter == true && WasInShelter == false)
            {
                HomelessAnimalForm homelessAnimalForm = new HomelessAnimalForm(findingReport);
                homelessAnimalForm.ShowDialog();
            }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (findingReport.FindingReportId == DataRepository.FindingReport.GetMaxId() + 1)
            {
                Add();
            }
            else
            {
                Edit();
            }

            Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PictureSaveForm pictureSaveForm = new PictureSaveForm(findingReport, split);
            pictureSaveForm.ShowDialog();
            //MessageBox.Show(PictureSaveForm.Address);
            txePictureLink.Text = PictureSaveForm.Address;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
}
