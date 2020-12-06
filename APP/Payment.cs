using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class Payment : Form
    {
        List<Basket> B = new List<Basket>();
        User U = new User { Name = "", Password = "", Username = "", Surname = "" };
        public Payment()
        {
            InitializeComponent();
            Basket b = new Basket { name = "", price = 0, year = 0 };
            B = b.GetList();
            U = U.GetList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check(e);
        }
        private void Check(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            PaymentClass P = new PaymentClass { Amount = Convert.ToString(B[0].Payment(B)), Username = U.Username };
            List<PaymentClass> Plist = new List<PaymentClass>();
            Plist = ShopDatabase.GetPayment("Payment");
            if (Plist.Count == 0)
            {
                P.ID = 1;
                ShopDatabase.SavePayment("Payment", P);
            }
            else
            {
                P.ID = Plist[Plist.Count - 1].ID + 1;
                ShopDatabase.SavePayment("Payment", P);
            }
            MessageBox.Show("works");
        }
    }
}
