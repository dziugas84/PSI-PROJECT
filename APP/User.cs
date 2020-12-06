using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        protected static User u;
        protected static int ID;
        public void SetList(User U)
        {
            u = U;
        }
        public User GetList()
        {
            return u;
        }
        public void SetID(int id)
        {
            ID = id;
        }
        public int GetID()
        {
            return ID;
        }

    }
}
