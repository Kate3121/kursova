using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Access { get; set; }

        public User(string name, string password, string access)
        {
            Name = name;
            Password = password;
            Access = access;
        }
    }
}
