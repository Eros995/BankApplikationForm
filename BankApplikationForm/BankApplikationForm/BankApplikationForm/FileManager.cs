﻿using Newtonsoft.Json;
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

        public List<User> ReadUsers(List<User> users) //Används utanför FileManager
        {
            if (File.Exists(usersFile))
            {
                string json = File.ReadAllText(usersFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return users;
        }
        public void UpdateUser(User userToUpdate)
        {
            List<User> users = ReadUsers();
            int index = users.FindIndex(u => u.UserId == userToUpdate.UserId);

            if (index != -1)
            {
                users[index] = userToUpdate;

                var json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(usersFile, json);
            }
            else
            {
                MessageBox.Show("User not found for update.");
            }
        }

        private List<User> ReadUsers() //Används innanför filemanager
        {
            List<User> users = new List<User>();

            if (File.Exists(usersFile))
            {
                string json = File.ReadAllText(usersFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }

            return users;
        }

        public void UpdateUserBalance(User user)
        {
            List<User> users = ReadUsers();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserId == user.UserId)
                {
                    users[i] = user;
                    var json = JsonConvert.SerializeObject(users, Formatting.Indented);
                    File.WriteAllText(usersFile, json);
                    break;
                }
            }
        }
        public void DeleteUser(User userToDelete)
        {
            List<User> users = ReadUsers();

            int index = users.FindIndex(u => u.UserId == userToDelete.UserId);

            if (index != -1)
            {
                users.RemoveAt(index);

                var json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(usersFile, json);
            }
            else
            {
                MessageBox.Show("User not found for deletion.");
            }
        }


    }
}

