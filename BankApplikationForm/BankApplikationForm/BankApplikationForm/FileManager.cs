using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    public class FileManager
    {
        private readonly string usersFile = Directory.GetCurrentDirectory() + "\\users.json";

        public void CreateNewUser(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(usersFile, json);
        }

        public List<User> ReadUsers(List<User> users)
        {
            if (File.Exists(usersFile))
            {
                string json = File.ReadAllText(usersFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return users;
        }

    }
}
