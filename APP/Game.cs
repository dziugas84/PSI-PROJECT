using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class Game
    {
        public string name { get; set; }
        public double price { get; set; }
        public int year { get; set; }

        public virtual void Equal(List<Game> f, List<Game> s, int i)
        {
            f.Add(new Game { name = s[i].name, price = s[i].price, year = s[i].year });
        }
    }
}
