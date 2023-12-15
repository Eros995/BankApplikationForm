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
        private void adminLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

                tabControl1.SelectedIndex = 1;

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
                        selectedUser.Password = newPassword;
                        FileManager fileManager = new FileManager();
                        fileManager.UpdateUser(selectedUser);
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
            if (listBox1.SelectedIndex != -1)
            {
                string selectedUserName = listBox1.SelectedItem.ToString().Split('|')[0].Trim().Substring(6);
                User selectedUser = users.FirstOrDefault(user => user.Name == selectedUserName);

                if (selectedUser != null)
                {
                    string newName = usersNameTextBox.Text;
                    string newAddress = usersAddressTextBox.Text;
                    string newEmail = usersEmailTextBox.Text;

                    bool isUpdated = false;

                    if (!string.IsNullOrEmpty(newEmail) &&
                        users.Any(u => u.Email == newEmail && u.UserId != selectedUser.UserId))
                    {
                        MessageBox.Show("This email is already in use by another user. Please choose a different email.");
                        return;
                    }


                    if (!string.IsNullOrEmpty(newName) && newName != selectedUser.Name)
                    {
                        selectedUser.Name = newName;
                        usersNameLabel.Text = $"Name:\n{newName}";
                        listBox1.Items[listBox1.SelectedIndex] = $"User: {newName} | User Id: {selectedUser.UserId}";
                        isUpdated = true;
                    }


                    if (!string.IsNullOrEmpty(newAddress) && newAddress != selectedUser.Address)
                    {
                        selectedUser.Address = newAddress;
                        usersAdressLabel.Text = $"Address:\n{newAddress}";
                        isUpdated = true;
                    }


                    if (!string.IsNullOrEmpty(newEmail) && newEmail != selectedUser.Email)
                    {
                        selectedUser.Email = newEmail;
                        usersEmailLabel.Text = $"Email:\n{newEmail}";
                        isUpdated = true;
                    }


                    if (isUpdated)
                    {
                        FileManager fileManager = new FileManager();
                        fileManager.CreateNewUser(users);
                        usersNameTextBox.Text = "";
                        usersAddressTextBox.Text = "";
                        usersEmailTextBox.Text = "";

                        MessageBox.Show("User information updated!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string selectedUserName = selectedItem.Split('|')[0].Trim().Substring(6);

                User selectedUser = users.FirstOrDefault(user => user.Name == selectedUserName);

                if (selectedUser != null)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{selectedUserName}'?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        users.Remove(selectedUser);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                        FileManager fileManager = new FileManager();
                        fileManager.CreateNewUser(users);

                        ClearUserInfo(selectedUserName);

                        MessageBox.Show("User deleted successfully.");
                    }
                }
            }
        }
        private void ClearUserInfo(string selectedUserNam)
        {
            usersNameLabel.Text = "Name:";
            usersAdressLabel.Text = "Address:";
            usersIdLabel.Text = "User ID:";
            usersEmailLabel.Text = "Email:";
            usersPasswordLabel.Text = "Password:";
            usersNameTextBox.Text = "";
            usersAddressTextBox.Text = "";
            usersEmailTextBox.Text = "";
        }

        
    }

}
