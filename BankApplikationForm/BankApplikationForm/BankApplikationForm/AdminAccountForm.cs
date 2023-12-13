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
                adminFormListBoxUsers.Items.Add($"User: " + user.Name + " | " + "User Id: " + user.UserId);

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

            if (adminFormListBoxUsers.SelectedIndex != -1)
            {

                User selectedUser = users[adminFormListBoxUsers.SelectedIndex];


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
            if (adminFormListBoxUsers.SelectedIndex != -1)
            {
                string selectedUserName = adminFormListBoxUsers.SelectedItem.ToString().Split('|')[0].Trim().Substring(6); // Extracting the selected user's name from the list box

                // Find the user by name
                User selectedUser = users.FirstOrDefault(user => user.Name == selectedUserName);

                if (selectedUser != null)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{selectedUserName}'?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        users.Remove(selectedUser);
                        adminFormListBoxUsers.Items.RemoveAt(adminFormListBoxUsers.SelectedIndex);

                        FileManager fileManager = new FileManager();
                        fileManager.CreateNewUser(users); // Save the updated user list to the JSON file

   

                        MessageBox.Show("User deleted successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }
        


    }
}
