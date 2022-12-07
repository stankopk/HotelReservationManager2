using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationManager.View
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxHidePass_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string Value = "";

            int richTextlent = 1;

            if (richTextBox1.Text.Length == richTextlent)
            {
                Value += richTextBox1.Text[0].ToString();
                richTextBox1.Text = richTextBox1.Text.Remove(0, 1);
                richTextBox1.Text += "*";

            }
            else
            {
                Value = "";
                richTextBox1.Text = "";
            }
            richTextlent = richTextBox1.Text.Length + 1;
        }
    }
}
