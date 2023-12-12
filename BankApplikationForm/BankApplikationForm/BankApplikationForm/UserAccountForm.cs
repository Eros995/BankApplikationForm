using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BankApplikationForm
{
    public partial class UserAccountForm : Form
    {
        private string selectedAccountInfo = null;
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
            newAccountNameLabel.Visible = true;
            newAccountNameLabel2.Visible = true;
            newAccountNameTextBox.Visible = true;
            newAccountNameTextBox.Focus();
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
                string accountName = newAccountNameTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(accountName))
                {
                    loggedInUser.CreateNewAccount(accountName);
                    RefreshAccountListBox(loggedInUser);
                }

                newAccountNameTextBox.Visible = false;
                newAccountNameLabel.Visible = false;
                createNewAccountButton.Visible = true;
            }
        }

        private void accountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccountInfo = accountsListBox.SelectedItem?.ToString();
        }

        private void loadAccountButton_Click(object sender, EventArgs e)
        {
            if (selectedAccountInfo != null)
            {
                string[] accountDetails = selectedAccountInfo.Split('|'); 

                if (accountDetails.Length == 3)
                {
                    string accountName = accountDetails[0].Split(':')[1].Trim(); 
                    string accountId = accountDetails[1].Split(':')[1].Trim(); 
                    string balance = accountDetails[2].Split(':')[1].Trim(); 

                    
                    accountNameLabel.Text = "Account Name:\n" + accountName;
                    accountIdLabel.Text = "Account ID:\n " + accountId;
                    balanceLabel.Text = $"Balance:\n {balance.ToString()}";
                }
                else
                {
                    MessageBox.Show("Error! Could not retrieve account information.");
                }

                userTabControl.SelectedTab = transactionTab;
            }
        }

    }
}