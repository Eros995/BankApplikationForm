﻿using System;
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

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        private bool firstAccount = true;
        private static int nextId = 0;
        public List<Account> accounts = new List<Account>();

        public User(string name, string password, string email, string address)
        {
            UserId = nextId++;
            Name = name;
            Password = password;
            Email = email;
            accounts.Add(new Account(name));
            Address = address;
        }


        public List<Account> GetUserAccounts()
        {
            return accounts;
        }


        public List<string> GetAccountInfo()
        {
            List<string> accountInfoList = new List<string>();
            foreach (Account account in accounts)
            {
                string accountInfo = $"Name: {account.AccountName} | Account ID: {account.AccountId} | Balance: {account.Balance} kr";
                accountInfoList.Add(accountInfo);
            }
            return accountInfoList;
        }


        public void CreateNewAccount(string accountName = null)
        {
            if (firstAccount && string.IsNullOrEmpty(accountName))
            {
                // For the first account, use the user's name
                Account newAccount = new Account(Name);
                accounts.Add(newAccount);
                firstAccount = false;
            }
            else
            {
                Account newAccount = new Account(accountName);
                accounts.Add(newAccount);
            }

            FileManager fileManager = new FileManager();
            fileManager.UpdateUser(this);
            
        }


        public void DeleteAccount(int accountId)
        {
            Account accountToRemove = accounts.Find(acc => acc.AccountId == accountId);
            if (accountToRemove != null)
            {
                accounts.Remove(accountToRemove);
                FileManager fileManager = new FileManager();
                fileManager.UpdateUser(this);
            }
        }

    }

}

