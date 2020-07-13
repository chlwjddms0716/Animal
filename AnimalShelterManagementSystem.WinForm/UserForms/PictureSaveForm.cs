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
    public partial class PictureSaveForm : DevExpress.XtraEditors.XtraForm
    {
        private HomelessAnimal homelessAnimal;
        public static string Address { get; set; }
         public PictureSaveForm()
        {
            InitializeComponent();
        }

        public PictureSaveForm(HomelessAnimal _homelessAnimal) : this()
        {
            homelessAnimal = _homelessAnimal;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                peBox.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
                Address = xtraOpenFileDialog1.FileName;
                return;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            homelessAnimal.Picture = ConvertImageToBinary(peBox.Image);
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
