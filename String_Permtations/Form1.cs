using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Permtations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Y_Textbx_TextChanged(object sender, EventArgs e)
        {
            string Ycontents = Y_Textbx.Text;
        }

        private void X_Textbx_TextChanged(object sender, EventArgs e)
        {
            string Xcontents = X_Textbx.Text;
        }

        private void Cal_But_Click(object sender, EventArgs e)
        {
            if ( 0 < Y_Textbx.Text.Length < 1000 && 0 < Ycontents.Length < 1000 )
            {




            }
        }
    }
}
