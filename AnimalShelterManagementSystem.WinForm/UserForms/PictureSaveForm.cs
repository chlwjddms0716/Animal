using DevExpress.Utils.DPI;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraPrinting.BarCode.Native;
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
    public partial class PictureSaveForm : Form
    {
        private HomelessAnimal homelessAnimal;
        private FindingReport findingReport;
        private LossReport
        public static string Address { get; set; }
        private int check;
         public PictureSaveForm()
        {
            InitializeComponent();
        }

        public PictureSaveForm(HomelessAnimal _homelessAnimal) : this()
        {
            check = 1;
            homelessAnimal = _homelessAnimal;
        }


        public PictureSaveForm(FindingReport _findingReport) : this()
        {
            check = 2;
            findingReport = _findingReport;
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                peBox.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
                peBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                Address = xtraOpenFileDialog1.FileName;
                return;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(check==1 )
                homelessAnimal.Picture = ConvertImageToBinary(peBox.Image);
            else if(check==2)
                findingReport.Picture = ConvertImageToBinary(peBox.Image);

            MessageBox.Show("사진 등록이 완료되었습니다.");
            Close();
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

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

       
        
        
    }
}
