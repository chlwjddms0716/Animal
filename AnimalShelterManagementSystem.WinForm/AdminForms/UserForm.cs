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
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        User user = new User();
        public UserForm()
        {
            InitializeComponent();
            
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            user.UserId = DataRepository.User.GetMaxId() + 1;
            boxUserId.Text = user.UserId.ToString();
            boxUserId.Enabled = false;

        }
        public UserForm(User user)  
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

         string Checkinput()
        {
            string checkinput = "";
            if (String.Equals(boxPassword.Text, "") == true)
                checkinput += "비밀번호, ";
            if (String.Equals(boxPhoneNumber.Text, "") == true)
                checkinput += "전화번호, ";
            if (String.Equals(boxAddress.Text, "") == true)
                checkinput += "주소, ";

            return checkinput;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {  
            string test = Checkinput();
            if (string.Equals(Checkinput(), "") == true)
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
                return;
            }
          
            MessageBox.Show($"{Checkinput().Remove(Checkinput().Length-2)}을(를) 입력해주세요.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRepository.User.Delete(user.UserId);
            Close();
            return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string checkinput = "";
            if (String.Equals(boxId.Text, "") == true)
                checkinput += "아이디, ";
            else
            {
                if (DataRepository.User.GetbyId(boxId.Text) != null)
                { 
                    MessageBox.Show($"중복된 아이디입니다. 다른 아이디를 입력해주세요.");
                    return;

                }
            }
            if (String.Equals(boxName.Text, "") == true)
                checkinput += "이름, ";
            checkinput += Checkinput();

            if (string.Equals(Checkinput(), "") == true)
            {
                user.Id = boxId.Text;
                user.Name = boxName.Text;
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
                DataRepository.User.Insert(user);
                MessageBox.Show("새로운 유저가 추가되었습니다.");
                Close();
            }
            MessageBox.Show($"{Checkinput().Remove(Checkinput().Length - 2)}을(를) 입력해주세요.");
        }
    }
}
