using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.WinForm.AdminForms;
using AnimalShelterManagementSystem.WinForm.UserForms;
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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.Equals(txeId.Text, "") == true)
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }
            else
            {
                if (DataRepository.User.GetbyId(txeId.Text) != null)
                {
                    User user = DataRepository.User.GetbyId(txeId.Text);
                    if (user.Password == txePassword.Text)
                    {
                        if (user.IsAdministrator == true)
                        {
                            AdminMenu adminMenu = new AdminMenu();
                            adminMenu.ShowDialog();
                            Close();
                        }
                        else
                        {
                            UserMenu userMenu = new UserMenu(user.UserId);
                            userMenu.ShowDialog();
                            Close();
                        }
                    }
                    else
                        MessageBox.Show("잘못된 비밀번호입니다.");
                }
                else
                {
                    MessageBox.Show("존재하지 않는 아이디입니다.");
                    return;
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }


        private void btnFindId_Click(object sender, EventArgs e)
        {
            FindId findId = new FindId();
            findId.ShowDialog();
        }

        private void btnFindPassword_Click(object sender, EventArgs e)
        {
            FindPassword findPassword = new FindPassword();
            findPassword.ShowDialog();
        }
    }
}
