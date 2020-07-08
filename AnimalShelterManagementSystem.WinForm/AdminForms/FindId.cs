using AnimalShelterManagementSystem.Data;
using DevExpress.XtraPrinting.Export.Pdf;
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
    public partial class FindId : Form
    {
        public FindId()
        {
            InitializeComponent();
        }

        private void btnFindId_Click(object sender, EventArgs e)
        {
            bool check = false;
            List<User> user = DataRepository.User.GetbyName(txeName.Text);
            foreach (User userr in user)
            { 
                if(string.Equals(userr.PhoneNumber,txePhoneNumber.Text)==true)
                {
                    check = true;
                    //string userId = userr.Id;
                    //for(int i =0; i< userId.Length;i++)
                    //{
                    //    if (i % 3 == 1)
                    //        userId[i] = '*';
                    //}
                     
                    MessageBox.Show($"아이디는 {userr.Id}입니다.");
                }
            }
            if (check == false)
                MessageBox.Show("아이디나 전화번호를 다시 확인해주세요");
             
        }
    }
}
