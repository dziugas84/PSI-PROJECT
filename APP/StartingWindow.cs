using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class StartingWindow : Form
    {
        public StartingWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            LoginUser lu = new LoginUser();
            lu.ShowDialog();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            LoginAdmin la = new LoginAdmin();
            la.ShowDialog();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
