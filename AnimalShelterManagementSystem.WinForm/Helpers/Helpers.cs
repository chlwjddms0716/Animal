using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.Helpers
{
    public static class Helpers
    {
        public static bool SureToDelete()
        {
            return MessageBox.Show(
                "really?",
                "질문",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes;
        }
    }
}