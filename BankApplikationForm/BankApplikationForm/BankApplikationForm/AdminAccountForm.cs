using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplikationForm
{

    public partial class AdminAccountForm : Form
    {
        LoginForm loginForm;
        BankManager bankManager = new BankManager();
        User user;
        List<Account> accounts = new List<Account>();
        List<User> users = new List<User>();
        FileManager fileManager;
        public AdminAccountForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.GetUserList();
            fileManager = new FileManager();
        }
        public void GetUserList()
        {
            users = bankManager.GetUsers();
            foreach (User user in users)
            {
                AdminFormListBoxUsers.Items.Add($"User: " + user.Name + " | " + "User Id: " + user.UserId);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AdminAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (AdminFormListBoxUsers.SelectedIndex != -1)
            {

                User selectedUser = users[AdminFormListBoxUsers.SelectedIndex];


                selectedUser.GetUserAccounts();
                selectedUser.GetAccountInfo();


                foreach (Account account in selectedUser.accounts)
                {
                    listBox2.Items.Add($"Account ID: {account.AccountId} | Balance: {account.Balance}");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AdminFormListBoxUsers.SelectedIndex != -1)
            {
                User selectedUser = users[AdminFormListBoxUsers.SelectedIndex];


                fileManager.DeleteUser(selectedUser);

                
                RefreshListBox();
            }
        }
        private void RefreshListBox()
        {
            users = bankManager.GetUsers();

            
            for (int i = AdminFormListBoxUsers.Items.Count - 1; i >= 0; i--)
            {
                string listBoxItem = AdminFormListBoxUsers.Items[i].ToString();
                int userId = ExtractUserId(listBoxItem); 

                
                if (!users.Any(user => ExtractUserId(user.ToString()) == userId))
                {
                    AdminFormListBoxUsers.Items.RemoveAt(i);
                }
            }
        }
        private int ExtractUserId(string listBoxItem)
        {
            int userIdIndex = listBoxItem.LastIndexOf("User Id: ") + "User Id: ".Length;
            int userId = int.Parse(listBoxItem.Substring(userIdIndex));
            return userId;
        }


    }
}
