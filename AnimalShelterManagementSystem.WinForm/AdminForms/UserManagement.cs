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
   
    public partial class UserManagement : Form
    { 
        private int AdminCode = 2;
        private int BlacklistCode = 2;
        List<User> UserList = new List<User>();
        List<User> FilteredByName = new List<User>();
        List<User> FilteredById = new List<User>();    
        List<User> FilteredByAdmin = new List<User>();
        List<User> FilteredByBlacklist = new List<User>();
      
        public UserManagement()
        {
            InitializeComponent();
        }
        private void querybyName()
        {
            if (String.Equals(txbName.Text, "") == false)
                FilteredByName = UserList.Where(x => x.Name.Contains(txbName.Text) == true).ToList();
            else
                FilteredByName = UserList;
        }
        private void querybyId()
        {
            querybyName();
            if (String.Equals(txbId.Text, "") == false)
                FilteredById = FilteredByName.Where(x => x.Id.Contains(txbId.Text) == true).ToList();

            else
                FilteredById = FilteredByName;
        }
        private void querybyAdmin()
        {
            querybyId();
            if (AdminCode != 2)
                FilteredByAdmin = FilteredById.Where(x => x.IsAdministrator == Convert.ToBoolean(AdminCode)).ToList();
            else
                FilteredByAdmin = FilteredById;
        }
        private void querybyBlacklist()
        {
            querybyAdmin();
            if (BlacklistCode != 2)
                FilteredByBlacklist = FilteredByAdmin.Where(x => x.IsBlacklist == Convert.ToBoolean(BlacklistCode)).ToList();
            else
                FilteredByBlacklist = FilteredByAdmin;
            userBindingSource.DataSource = FilteredByBlacklist;
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserList = DataRepository.User.GetAll();
            userBindingSource.DataSource = UserList;
            
        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            querybyBlacklist();
        }
        private void txbId_TextChanged(object sender, EventArgs e)
        {
            querybyBlacklist();
        }
        private void rdgAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminCode = (int)rdgAdmin.EditValue;
            querybyBlacklist();
        }

        private void rdgBlacklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            BlacklistCode = (int)rdgBlacklist.EditValue;
            querybyBlacklist();
        }

        private void grvUserList_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            User user = userBindingSource.Current as User;
            EditUserInformationByAdmin editUserInformationByAdmin = new EditUserInformationByAdmin(user.Id);
            editUserInformationByAdmin.ShowDialog();
            Cursor = Cursors.Arrow;

        }
    }
}
