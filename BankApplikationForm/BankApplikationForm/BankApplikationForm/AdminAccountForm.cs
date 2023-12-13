using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BankApplikationForm
{
    public partial class AdminAccountForm : Form
    {
        LoginForm loginForm;
        BankManager bankManager = new BankManager();
        User user;
        List<Account> accounts = new List<Account>();
        List<User> users = new List<User>();
        public AdminAccountForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.GetUserList();

        }
        public void GetUserList()
        {
            users = bankManager.GetUsers();
            foreach (User user in users)
            {
                listBox1.Items.Add($"User: " + user.Name + " | " + "User Id: " + user.UserId);

            }
        }

        private void AdminAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (listBox1.SelectedIndex != -1)
            {

                User selectedUser = users[listBox1.SelectedIndex];


                selectedUser.GetUserAccounts();
                selectedUser.GetAccountInfo();


                foreach (Account account in selectedUser.accounts)
                {
                    listBox2.Items.Add($"Account ID: {account.AccountId} | Balance: {account.Balance}");

                }
            }
        }

        private void loadUserButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                User selectedUser = users[listBox1.SelectedIndex];

                tabControl1.SelectedIndex = 1; // Navigate to userInfoTab

                usersNameLabel.Text = $"Name:\n{selectedUser.Name}";
                usersAdressLabel.Text = $"Address:\n{selectedUser.Address}";
                usersIdLabel.Text = $"ID:\n{selectedUser.UserId}";
                usersEmailLabel.Text = $"Email:\n{selectedUser.Email}";
                usersPasswordLabel.Text = $"Password:\n{selectedUser.Password}";

            }
        }

        private void changeUserPasswordButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                User selectedUser = users[listBox1.SelectedIndex];
                string currentPassword = currentPasswordTextBox.Text;
                string newPassword = newPasswordTextBox.Text;
                string confirmPassword = confirmPasswordTextBox.Text;

                if (currentPassword == selectedUser.Password)
                {
                    if (newPassword == confirmPassword)
                    {
                        // Update the user's password
                        selectedUser.Password = newPassword;
                        FileManager fileManager = new FileManager();
                        fileManager.UpdateUser(selectedUser); // Save changes after updating the password
                        MessageBox.Show("Password updated successfully!");
                        usersPasswordLabel.Text = $"Password:\n{selectedUser.Password}";
                    }
                    else
                    {
                        MessageBox.Show("New password and confirm password don't match!");
                    }
                }
                else
                {
                    MessageBox.Show("Current password is incorrect!");
                }
            }
        }

        private void updateUsersInfoButton_Click(object sender, EventArgs e)
        {
            string newName = usersNameTextBox.Text;
            string newAddress = usersAddressTextBox.Text;
            string newEmail = usersEmailTextBox.Text;

            // Get the selected user from the list box
            if (listBox1.SelectedIndex != -1)
            {
                User selectedUser = users[listBox1.SelectedIndex];

                if (!string.IsNullOrEmpty(newName))
                {
                    selectedUser.Name = newName;
                }
                else if (!string.IsNullOrEmpty(newAddress))
                {
                    selectedUser.Address = newAddress;
                }
                else if (!string.IsNullOrEmpty(newEmail))
                {
                    selectedUser.Email = newEmail;
                }
                else
                {
                    MessageBox.Show("Please provide at least one field to update!");
                    return;
                }

                
                usersNameLabel.Text = $"Name:\n{selectedUser.Name}";
                usersAdressLabel.Text = $"Address:\n{selectedUser.Address}";
                usersEmailLabel.Text = $"Email:\n{selectedUser.Email}";

                listBox1.Items[listBox1.SelectedIndex] = $"User: {selectedUser.Name} | User Id: {selectedUser.UserId}";

                FileManager fileManager = new FileManager();
                fileManager.UpdateUser(selectedUser);
                MessageBox.Show("User information updated!");
            }
        }
    }
    
}
