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
    public partial class LossReport : Form
    {
        private int userId;
        public LossReport()
        {
            InitializeComponent();
        }

        public LossReport(int UserId) : this()
        {
            userId = UserId;
        }

        private void LossRequest_Load(object sender, EventArgs e)
        {
            speciesBindingSource.DataSource = DataRepository.Species.GetAll();
        }
    }
}
