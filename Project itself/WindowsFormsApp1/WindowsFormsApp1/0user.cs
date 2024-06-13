using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        public string email = "";
        public string password = "";
        public User(string name, string password) 
        { 
            this.email = name;
            this.password = password;
        }

        public string getName()
        {
            return email;
        }
        public void setName(string name)
        {
            this.email = name;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
