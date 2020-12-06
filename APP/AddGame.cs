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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && Convert.ToString(yearBox1) != "" && Convert.ToString(priceTextBox) != "")
            {
                Game n = new Game();
                n.name = nameTextBox.Text;
                n.price = Convert.ToDouble(priceTextBox.Text);
                n.year = Convert.ToInt32(yearBox1.Text);
                ShopDatabase.SaveGames("Games", n);
                MessageBox.Show("Game has been added");
                Close();
            }
            else
            {
                MessageBox.Show("Fill in all text boxes");
            }
        }

        private void yearBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != ',')
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
