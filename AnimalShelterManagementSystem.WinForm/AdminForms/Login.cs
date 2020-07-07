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
            Cursor = Cursors.WaitCursor;
            User user = DataRepository.User.GetbyId(txeId.Text);

            if (user is null)
                MessageBox.Show("존재하지 않는 아이디입니다.");
            else
            {
                if (String.Equals(txePassword.Text, user.Password))
                {
                    if (user.IsAdministrator is true)
                    {
                        MessageBox.Show("관리자 구현중");
                    }
                    else
                    {
                        UserMenu userMenu = new UserMenu(user.UserId);
                        userMenu.ShowDialog();
                        Cursor = Cursors.Arrow;
                        Close();
                    }
                }
                else
                    MessageBox.Show("비밀번호가 틀렸습니다.");
            }


            Cursor = Cursors.Arrow;

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
