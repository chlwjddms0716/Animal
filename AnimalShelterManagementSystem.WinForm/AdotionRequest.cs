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
using System.Data.Entity;

namespace AnimalShelterManagementSystem.WinForm
{
    public partial class AdotionRequest : Form
    {
        public AdotionRequest()
        {
            InitializeComponent();
        }

        private void drbSpeciesSelection_Click(object sender, EventArgs e)
        {

        }

        private void AdotionRequest_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            speciesBindingSource.DataSource = DataRepository.Species.GetAll();
        }
    }
}
