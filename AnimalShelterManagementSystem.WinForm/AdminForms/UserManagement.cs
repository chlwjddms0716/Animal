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
        private int IsAdmin = 2;
        private int IsBlacklist = 2;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void rdgAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
