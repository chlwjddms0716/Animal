using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.WinForm.AdminForms;
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
            //
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
