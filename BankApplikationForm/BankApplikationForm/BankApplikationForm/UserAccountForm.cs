using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserAccountForm : Form
    {
        private User loggedInUser;
        public UserAccountForm(User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            loggedInAsLabel.Text = "You are logged in as:\n" + loggedInUser.Name;
            this.DisplayAccountInfo();
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
        private void DisplayAccountInfo()
        {
            List<string> accountInfoList = loggedInUser.GetAccountInfo();
            accountsListBox.Items.AddRange(accountInfoList.ToArray());
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            createNewAccountButton.Visible = false;
            accountNameLabel.Visible = true;
            accountNameLabel2.Visible = true;
            accountNameTextBox.Visible = true;
            accountNameTextBox.Focus();
        }

        private void RefreshAccountListBox(User user)
        { 
            accountsListBox.Items.Clear(); 
            List<string> accountInfoList = user.GetAccountInfo();
            foreach (string accountInfo in accountInfoList)
            {
                accountsListBox.Items.Add(accountInfo);
            }
        }
        private void accountNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string accountName = accountNameTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(accountName))
                {
                    loggedInUser.CreateNewAccount(accountName);
                    RefreshAccountListBox(loggedInUser); 
                }

                accountNameTextBox.Visible = false;
                accountNameLabel.Visible = false;
                createNewAccountButton.Visible = true;
            }
        }


    }
}
