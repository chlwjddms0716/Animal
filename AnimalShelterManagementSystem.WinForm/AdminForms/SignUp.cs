using AnimalShelterManagementSystem.Data;
using DevExpress.Utils.Automation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.Forms
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {
        bool checkduplicate = false;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.Equals(txeId.Text, "") is true)
                MessageBox.Show("아이디를 입력해주세요.");
            else
            {
                if (DataRepository.User.GetbyId(txeId.Text) is null)
                {
                    MessageBox.Show("사용가능한 아이디입니다.");
                    checkduplicate = true;
                }
                else
                    MessageBox.Show("이미 존재하는 아이디입니다.");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string checkinput = "";
            if (String.Equals(txeId.Text, "") == true)
            {
                checkinput += "아이디, ";
            }
            if (String.Equals(txePassword.Text, "") == true)
            {
                checkinput += "비밀번호, ";
            }
            if (String.Equals(txeName.Text, "") == true)
            {
                checkinput += "이름, ";
            }
            if (String.Equals(txePhoneNumber.Text, "") == true)
            {
                checkinput += "휴대폰 번호, ";
            }
            if (String.Equals(txeAddress.Text, "") == true)
            {
                checkinput += "주소";
            }

            if (string.Equals(checkinput, "") == true)
            {
                if (checkduplicate is true)
                {
                    User user = new User();
                    user.Address = txeAddress.Text;
                    user.Id = txeId.Text;
                    user.Password = txePassword.Text;
                    user.Name = txeName.Text;
                    user.PhoneNumber = txePhoneNumber.Text;
                    user.UserId = DataRepository.User.GetMaxId() + 1;
                    DataRepository.User.Insert(user);
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    Close();
                    return;
                }
                else
                {
                    MessageBox.Show("중복된 아이디입니다.");
                }
            }
            MessageBox.Show($"{checkinput}을(를) 입력해주세요");
        }
    }
}
