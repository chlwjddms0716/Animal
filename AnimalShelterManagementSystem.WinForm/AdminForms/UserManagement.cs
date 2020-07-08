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
            {
                FilteredById = (List<User>)(from x in UserList
                                            where x.Name.Contains(txbName.Text) == true
                                            select x);
            }
            else
                FilteredById = UserList;
        }
        private void querybyId()
        {
            querybyName();
            if (String.Equals(txbId.Text, "") == false)
            {
                FilteredByName = (List<User>)(from x in FilteredById
                                              where x.Id.Contains(txbId.Text) == true
                                            select x);
            }
            else
                FilteredByName = FilteredById;
        }
        private void querybyAdmin()
        {
            querybyId();
            if (AdminCode != 2)
            {
                FilteredByAdmin = (List<User>)(from x in FilteredByName
                                               where x.IsAdministrator == Convert.ToBoolean(AdminCode)
                                               select x);
            }
            else
                FilteredByAdmin = FilteredByName;
        }
        private void querybyBlacklist()
        {
            querybyAdmin();
            if (BlacklistCode != 2)
            {
                FilteredByBlacklist = (List<User>)(from x in FilteredByAdmin
                                               where x.IsBlacklist == Convert.ToBoolean(BlacklistCode)
                                               select x);
            }
            else
                FilteredByBlacklist = FilteredByAdmin;
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserList = DataRepository.User.GetAll();
            querybyBlacklist();
            userBindingSource.DataSource = FilteredByBlacklist;
            
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
    }
}
