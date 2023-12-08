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

        public bool LoginAsAdmin(string adminName, string adminPassword)
        {
            if (adminName == admin.Name && adminPassword == admin.Password)
            {
                return true;
            }
            return false;
        }

        public bool LoginAsUser(string email, string password)
        {
            foreach (User u in users)
            {
                if (u.Email == email && u.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
