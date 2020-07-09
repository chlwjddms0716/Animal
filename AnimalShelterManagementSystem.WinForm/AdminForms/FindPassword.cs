using AnimalShelterManagementSystem.Data;
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
    public partial class FindPassword : DevExpress.XtraEditors.XtraForm
    {
        private int CheckNumber = 8888;
        private User user = new User();
        public FindPassword()
        {
            InitializeComponent();
        }

        private void btnSendNumber_Click(object sender, EventArgs e)
        {
            user = DataRepository.User.GetbyId(txeId.Text);
            if (user is null)
            {
                MessageBox.Show("아이디를 다시 확인해주세요");
            }
            else
            {
                if (string.Equals(txePhoneNumber.Text, user.PhoneNumber) == true)
                {
                    MessageBox.Show("인증번호가 전송되었습니다.");
                }
                else
                    MessageBox.Show("전화번호를 다시 확인해주세요");
            }

        }

        private void btnFindPassword_Click(object sender, EventArgs e)
        {
            if(string.Equals(txeNumber.Text,CheckNumber.ToString())==true)
                MessageBox.Show($"비밀번호는 {user.Password}입니다.");
            else
                MessageBox.Show("인증번호를 다시 확인해주세요.");
        }
    }
}
