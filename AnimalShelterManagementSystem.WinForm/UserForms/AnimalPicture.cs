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
using System.IO;

namespace AnimalShelterManagementSystem.WinForm.UserForms
{
    public partial class AnimalPicture : DevExpress.XtraEditors.XtraForm
    {
        public AnimalPicture(HomelessAnimal homelessAnimal)
        {
            InitializeComponent();
            this.Text = homelessAnimal.Name;
            if (homelessAnimal.Picture != null && homelessAnimal.Picture.Length > 0)
            {
                pcePicture.Image = byteArrayToImage(homelessAnimal.Picture);

            }
            //pcePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;

            //txePictureLink.Text = _homelessAnimal.PictureLink;

        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
    }
    }
