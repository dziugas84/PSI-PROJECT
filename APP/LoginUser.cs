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
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int help = -1;
            List<User> U = new List<User>();
            U = ShopDatabase.GetUser("User");
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            for (int i = 0; i < U.Count; i++)
            {
                if (U[i].Username == username && U[i].Password == password)
                {
                    help = i;
                    this.Hide();
                    U[i].SetList(U[i]);
                    U[i].SetID(0);
                    MessageBox.Show (username + " successfully logged in");
                    Main sistema = new Main();
                    sistema.ShowDialog();
                    this.Close();
                }
            }
            if (help == -1)
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {

        }
    }
}
