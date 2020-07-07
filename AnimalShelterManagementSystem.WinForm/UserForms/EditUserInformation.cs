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

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class EditUserInformation : Form
    {
        private int userId;
        private User user;
        public EditUserInformation()
        {
            InitializeComponent();
        }

        public EditUserInformation(int UserId) : this()
        {
            userId = UserId;
            
            this.user = DataRepository.User.Get(UserId);
            boxId.Text = user.Id;
            boxName.Text = user.Name;
            boxPhoneNumber.Text = user.PhoneNumber;
            boxAddress.Text = user.Address;
        }

        private void EditUserInformation_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
        
        }


        private void textEdit11_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {
            if (String.Equals(boxPassword.Text, boxPasswordCheck.Text) == true )
            {
                user.PhoneNumber = boxPhoneNumber.Text;
                user.Address = boxAddress.Text;
                user.Password = boxPassword.Text;
                DataRepository.User.Update(user);
                MessageBox.Show("유저 정보가 수정되었습니다.");
                Close();
            }
            else
            {
                MessageBox.Show("비밀번호를 다시 확인하세요");
            }
        }
    }
}
