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
    public partial class Main : Form
    {
        List<Game> games = new List<Game>();
        List<Basket> bs = new List<Basket>();
        int ID;
        public Main()
        {
            InitializeComponent();
            User U = new User { Name = "", Password = "", Username="", Surname="" };
            ID = U.GetID();
            U = U.GetList();
            Label l = new Label();
            l.Text = "Username: " + U.Name + " " + U.Surname;
            l.Font = new Font("Arial", 8);
            l.MaximumSize = new Size(150, 0);
            l.AutoSize = true;
            Panel1.Controls.Add(l);

            Button basket = new Button();
            basket.Text = "Basket";
            basket.Left = (this.Width - basket.Width) - 40;
            basket.Click += basket_Click;
            Panel1.Controls.Add(basket);

            Button log_out = new Button();
            log_out.Text = "Log out";
            log_out.Left = (this.Width - log_out.Width) - 40;
            log_out.Top = basket.Bottom + 10;
            log_out.Click += log_out_Click;
            Panel1.Controls.Add(log_out);

            if (ID == 1)
            {
                Button add_game = new Button();
                add_game.Text = "Add Game";
                add_game.Left = (this.Width - add_game.Width) - 140;
                add_game.Top = 287;
                add_game.Click += add_game_Click;
                groupBox1.Controls.Add(add_game);

                Button delete_game = new Button();
                delete_game.Text = "Delete Game";
                delete_game.Left = (this.Width - delete_game.Width) - 240;
                delete_game.Top = 287;
                delete_game.Click += delete_game_Click;
                delete_game.AutoSize = true;
                groupBox1.Controls.Add(delete_game);
            }
            Ref();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void basket_Click(object sender, EventArgs e)
        {
            bs[0].SetList(bs);
            BasketForm bf = new BasketForm();
            bf.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gamesList.Items.Clear();
            List<Game> search = new List<Game>();
            if (textBox1.Text == null)
            {
                search = games;
            }
            else
            {
                for (int i = 0; i < games.Count; i++)
                {
                    if (games[i].name.Contains(textBox1.Text))
                    {
                        games[0].Equal(search, games, i);
                    }
                }
            }
            for (int i = 0; i < search.Count; i++)
            {
                gamesList.Items.Add(search[i].name + "    " + search[i].price + "$    " + search[i].year + " year");
            }
        }
        private void add_game_Click(object sender, EventArgs e)
        {
            AddGame ad = new AddGame();
            ad.ShowDialog();
            Ref();
        }
        private void delete_game_Click(object sender, EventArgs e)
        {
            if (gamesList.SelectedItem != null)
            {
                string item = Convert.ToString(gamesList.SelectedItem);
                for (int i = 0; i < games.Count; i++)
                {
                    if (item.Contains(games[i].name))
                    {
                        Game help = new Game();
                        help.name = games[i].name;
                        help.price = games[i].price;
                        help.year = games[i].year;
                        ShopDatabase.DeleteGames("Games", help);
                        MessageBox.Show("Game has been deleted");
                        Ref();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the game first");
            }
        }

        private void addtobasketButton_Click(object sender, EventArgs e)
        {
            if (gamesList.SelectedItem != null)
            {
                string item = Convert.ToString(gamesList.SelectedItem);
                for (int i = 0; i < games.Count; i++)
                {
                    if (item.Contains(games[i].name))
                    {
                        bs.Add(new Basket { name = games[i].name, price = games[i].price, year = games[i].year });
                        MessageBox.Show("Game has been added to basket");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the game first");
            }
        }
        private void Ref()
        {
            gamesList.Items.Clear();
            games = ShopDatabase.GetGames("Games");
            for (int i = 0; i < games.Count; i++)
            {
                gamesList.Items.Add(games[i].name + "    " + games[i].price + "$    " + games[i].year + " year");
            }
        }
        private void log_out_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
