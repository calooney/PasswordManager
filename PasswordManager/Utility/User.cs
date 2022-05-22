using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class User
    {
        public string name, username, password, email, telephone;

        public User(string name, string username, string password, string email, string telephone)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.telephone = telephone;
        }
    }
}
