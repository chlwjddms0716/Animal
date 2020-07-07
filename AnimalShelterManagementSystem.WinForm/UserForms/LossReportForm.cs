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

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class LossReportForm : Form
    {
        private int userId;
        public LossReportForm()
        {
            InitializeComponent();
        }

        public LossReportForm(int UserId) : this()
        {
            userId = UserId;
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
            cbxSpecies.SelectedItem = null;
            //cbxSpecies.SelectedIndex = "종을 선택해주세요.";
        }

        private void LossRequest_Load(object sender, EventArgs e)
        {

        }

        private void btnLossRequest_Click(object sender, EventArgs e)
        {
            string checkinput = "";
            if (String.Equals(txbPlace.Name, "") == true)
            {
                checkinput += "이름, ";
            }
            if (cbxSpecies.Text == null)
            {
                checkinput += "종, ";
            }
            if (dteDate.EditValue == null)
            {
                checkinput += "날짜, ";
            }
            if (String.Equals(txbPlace.Text, "") == true)
            {
                checkinput += "장소, ";
            }
            if (String.Equals(txbPictureLink.Text, "사진링크를 입력해주세요.") == true)
            {
                checkinput += "사진 링크";
            }

            if (string.Equals(checkinput, "") == true || String.Equals(checkinput, "사진 링크") == true)
            {
                LossReport lossReport = new LossReport();
                lossReport.Place = txbPlace.Text;
                lossReport.LossReportId = DataRepository.LossReport.GetMaxId() + 1;
                lossReport.Date = dteDate.DateTime.Date;
                lossReport.AnimalName = tbxName.Text;
                lossReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
                lossReport.PictureLink = txbPictureLink.Text;

                DataRepository.LossReport.Insert(lossReport);
                if (String.Equals(txbPictureLink.Text, "") == true)
                    MessageBox.Show("사진 링크를 입력하지 않으셨습니다.\n");
                MessageBox.Show("신고되었습니다.");
                Close();
            }
            MessageBox.Show($"{checkinput}을(를) 입력해주세요");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
