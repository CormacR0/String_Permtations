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
        int y_Len = 0;
        int x_Len = 0;
        private void Y_Textbx_TextChanged(object sender, EventArgs e)
        {
            y_Len = Y_Textbx.Text.Length;
        }

        private void X_Textbx_TextChanged(object sender, EventArgs e)
        {
            x_Len = X_Textbx.Text.Length;
        }

        private void Cal_But_Click(object sender, EventArgs e)
        {
            if ( 0 < y_Len && x_Len < 1000 && 1000 > y_Len && x_Len > 0)
            {
                MessageBox.Show("Valid input");



            }
            else
            {
                MessageBox.Show("Please enter a string between 1 and 1000 characters");
            }
        }
    }
}
