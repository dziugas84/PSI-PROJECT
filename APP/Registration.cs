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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createUser_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || surnameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Fill in all text boxes");
            }
            else
            {
                User u = new User();
                u.Name = nameTextBox.Text;
                u.Surname = surnameTextBox.Text;
                u.Username = usernameTextBox.Text;
                u.Password = passwordTextBox.Text;
                List<User> help = new List<User>();
                int h = 0;
                help = ShopDatabase.GetUser("User");
                for (int i = 0; i < help.Count; i++)
                {
                    if (help[i].Username == u.Username)
                    {
                        MessageBox.Show("This Username is already taken");
                        h = 1;
                        i = help.Count + 1;
                    }
                }
                if (h == 0)
                {
                    ShopDatabase.SaveUser("User", u);
                    MessageBox.Show("New user has been created");
                    Close();
                }
            }
            nameTextBox.Text="";
            surnameTextBox.Text="";
            usernameTextBox.Text="";
            passwordTextBox.Text="";
        }
    }
}
