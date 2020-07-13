
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
    public partial class AdoptionRequest : Form
    {
        private int UserId;
        public AdoptionRequest()
        {
            InitializeComponent();
        }

        public AdoptionRequest(int UserId) : this()
        {
            this.UserId = UserId;
        }


        private void drbSpeciesSelection_Click(object sender, EventArgs e)
        {

        }

        private void AdotionRequest_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("입양 신청 되었습니다.");
        }
    }
}
