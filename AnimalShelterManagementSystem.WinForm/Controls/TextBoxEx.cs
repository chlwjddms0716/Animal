using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.Controls
{
    public partial class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            InitializeComponent();

            Enter += TextBoxEx_Enter;
            Leave += TextBoxEx_Leave;
        }

        [Category("포커스 색상")]
        public Color ColorOnEnter { get; set; } = Color.Beige; //기본값설정

        [Category("포커스 색상")]
        public Color ColorOnLeave { get; set; } = Color.White; //기본값설정

        private void TextBoxEx_Leave(object sender, EventArgs e)
        {
            BackColor = ColorOnLeave;
        }

        private void TextBoxEx_Enter(object sender, EventArgs e)
        {
            BackColor = ColorOnEnter;
        }

    }
}
