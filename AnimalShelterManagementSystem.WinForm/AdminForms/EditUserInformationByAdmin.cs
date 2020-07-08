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
    public partial class EditUserInformationByAdmin : Form
    {
        User user;
        public EditUserInformationByAdmin(User user)  
        {
            InitializeComponent();
            this.user = user;
            boxPassword.Text = user.Password;
            boxPhoneNumber.Text = user.PhoneNumber;
            boxAddress.Text = user.Address;
            rdgAdmin.EditValue = user.IsAdministrator ? 1 : 0;
            rdgBlacklist.EditValue = user.IsBlacklist ? 1 : 0;
            boxBlacklistReason.Text = user.BlacklistReason;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            user.Password = boxPassword.Text;
            user.PhoneNumber = boxPhoneNumber.Text;
            user.Address = boxAddress.Text;
            user.IsAdministrator = Convert.ToBoolean(rdgAdmin.EditValue);
            user.IsBlacklist = Convert.ToBoolean(rdgBlacklist.EditValue);
            if (user.IsBlacklist == false)
            {
                user.BlacklistReason = "";//Todo : insert Null
            }
            else 
            {
                user.BlacklistReason = boxBlacklistReason.Text;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRepository.User.Delete(user.UserId);
            Close();
        }
    }
}
