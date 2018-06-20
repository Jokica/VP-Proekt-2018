using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerKing
{
   public class User
    {
        public string userName { set; get; }
        public string Email { set; get; }

        public int Age { get; set; }
        public string password { get; set; }

        public User(string userName,string Email,int Age,string password)
        {
            this.userName = userName;
            this.Email = Email;
            this.Age = Age;
            this.password = password;
        }
        public bool isUser(String name,String pass)
        {
            return name == userName && password == pass;
        }
    }
}
