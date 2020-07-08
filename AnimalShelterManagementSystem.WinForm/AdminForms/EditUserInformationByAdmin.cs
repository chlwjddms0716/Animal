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
        public EditUserInformationByAdmin()
        {
            InitializeComponent();
            
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            user = new User();
            user.UserId = DataRepository.User.GetMaxId() + 1;
            boxUserId.Text = user.UserId.ToString();
            boxUserId.Enabled = false;

        }
        public EditUserInformationByAdmin(User user)  
        {
            InitializeComponent();
            
            btnAdd.Enabled = false;
            this.user = user;
            boxUserId.Text = user.UserId.ToString();
            boxUserId.Enabled = false;
            boxName.Text = user.Name;
            boxName.Enabled = false;
            boxId.Text = user.Id;
            boxId.Enabled = false;
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
            DataRepository.User.Update(user);
            MessageBox.Show("수정되었습니다");
            Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRepository.User.Delete(user.UserId);
            Close();
        }
    }
}
