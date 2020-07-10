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
    public partial class FindingForm : Form
    {
        private FindingReport findingReport;
        public FindingForm()
        {
            InitializeComponent();
            findingReport = new FindingReport();
        }
        public FindingForm(FindingReport findingReport)
        {
            InitializeComponent();
            this.findingReport = findingReport;

        }
    }
}
