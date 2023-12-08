using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    public class Admin
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Admin()
        {
            Name = "admin";
            Password = "password";
        }
    }
}
