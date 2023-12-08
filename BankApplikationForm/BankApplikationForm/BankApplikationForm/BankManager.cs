using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    public class BankManager
    {
        List<User> users = new List<User>();
        Admin admin = new Admin();
        FileManager fileManager = new FileManager();

        public BankManager()
        {
            users = fileManager.ReadUsers(users);
        }

        public bool CreateNewUser(string name, string password, string email, string address)
        {
            foreach (User u in users)
            {
                if (email == u.Email)
                {
                    return false;
                }
            }

            User user = new User(name, password, email, address);
            users.Add(user);
            fileManager.CreateNewUser(users);
            return true;
        }
    }
}
