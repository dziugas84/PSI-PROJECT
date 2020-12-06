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
    public partial class BasketForm : Form
    {
        List<Basket> B = new List<Basket>();
        public BasketForm()
        {
            InitializeComponent();
            Basket b = new Basket { name = "", price = 0, year = 0 };
            B = b.GetList();
            Refresh(B);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (basketList.SelectedItem != null)
            {
                B.RemoveAt(basketList.SelectedIndex);
                Refresh(B);
                MessageBox.Show("Game was deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select game to delete");
            }
        }

        private void Refresh(List<Basket> b)
        {
            basketList.Items.Clear();
            if (b.Count > 0)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    basketList.Items.Add(b[i].name + "    " + b[i].price + "$    " + b[i].year + " year");
                }
                textBox1.Text = "Amount to pay: " + Convert.ToString(b[0].Payment(b) + "$");
            }
            else
            {
                basketList.Items.Add("Your basket is empty");
                basketList.Enabled = false;
                textBox1.Text = ("Your basket is empty");
            }
            textBox1.Enabled = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (basketList.Items.Contains("Your basket is empty"))
            {
                MessageBox.Show("You cannot pay cause your basket is empty");
            }
            else
            {
                Payment p = new Payment();
                p.ShowDialog();
            }
        }
    }
}
