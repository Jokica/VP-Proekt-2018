using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerKing
{
    public class Users
    {
        LinkedList<User> users;
        public Users()
        {
            users = new LinkedList<User>();
        }
        public void addUser(User user)
        {
            users.AddLast(user);
        }
        public bool shouldLogin(string name,string pass)
        {
            foreach(User user in users)
            {
                if (user.isUser(name, pass)) return true;
            }
            return false;
        }
    }
}
