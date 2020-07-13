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

    public partial class UserListForm : DevExpress.XtraEditors.XtraForm
    {
        private int AdminCode = 2;
        private int BlacklistCode = 2;
        List<User> UserList = new List<User>();
        List<User> FilteredByName = new List<User>();
        List<User> FilteredById = new List<User>();    
        List<User> FilteredByAdmin = new List<User>();
        List<User> FilteredByBlacklist = new List<User>();
      
        public UserListForm()
        {
            InitializeComponent();
        }
       
        private void UserManagement_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DataRepository.User.Search(txbName.Text, txbId.Text, (int)rdgAdmin.EditValue, (int)rdgBlacklist.EditValue);

        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DataRepository.User.Search(txbName.Text, txbId.Text, (int)rdgAdmin.EditValue, (int)rdgBlacklist.EditValue);
        }
        private void txbId_TextChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DataRepository.User.Search(txbName.Text, txbId.Text, (int)rdgAdmin.EditValue, (int)rdgBlacklist.EditValue);
        }
        private void rdgAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DataRepository.User.Search(txbName.Text, txbId.Text, (int)rdgAdmin.EditValue, (int)rdgBlacklist.EditValue);
        }

        private void rdgBlacklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DataRepository.User.Search(txbName.Text, txbId.Text, (int)rdgAdmin.EditValue, (int)rdgBlacklist.EditValue);
        }

        private void grvUserList_DoubleClick(object sender, EventArgs e)
        {
            LoadEditForm(userBindingSource.Current as User);
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UserForm editUserInformationByAdmin = new UserForm();
            editUserInformationByAdmin.ShowDialog();
            Cursor = Cursors.Arrow;
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current is null)
                MessageBox.Show("삭제할 유저를 선택해주세요");
            else
                LoadEditForm(userBindingSource.Current as User);
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current is null)
                MessageBox.Show("수정할 유저를 선택해주세요");
            else
                LoadEditForm(userBindingSource.Current as User);
        }
        private void LoadEditForm(User user)
        {
            Cursor = Cursors.WaitCursor;
            UserForm editUserInformationByAdmin = new UserForm(user);
            editUserInformationByAdmin.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DataRepository.User.Search(txbName.Text, txbId.Text, (int)rdgAdmin.EditValue, (int)rdgBlacklist.EditValue);
        }
    }
}
