using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankApplikationForm
{
    public class User 
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        private List<Account> accounts = new List<Account>();

        public User(string name, string password, string email, string address)
        {
            Name = name;
            Password = password;
            Email = email;
            accounts.Add(new Account());
            Address = address;
        }

        public void Login()
        {

        }

        public void Logout()
        {

        }

        public void ChangePassword()
        {

        }
    }
}
