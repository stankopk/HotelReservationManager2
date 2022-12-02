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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainViewLoginButton_Click(object sender, EventArgs e)
        {
            LoginScreen f2 = new LoginScreen();          
            f2.Show();
            this.Hide();
        }
    }
}
