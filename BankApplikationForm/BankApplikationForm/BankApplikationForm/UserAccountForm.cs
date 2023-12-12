﻿using Microsoft.VisualBasic.ApplicationServices;
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
        private int loadedAccountId;
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

                    loadedAccountId = Convert.ToInt32(accountId);
                }
                else
                {
                    MessageBox.Show("Error! Could not retrieve account information.");
                }

                userTabControl.SelectedTab = transactionTab;
            }
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            {
                if (selectedAccountInfo != null)
                {
                    string[] accountDetails = selectedAccountInfo.Split('|');
                    if (accountDetails.Length > 1 && int.TryParse(accountDetails[1].Split(':')[1].Trim(), out int accountId))
                    {
                        if (MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DeleteAccount(accountId);
                        }
                    }
                }
            }
        }

        private void DeleteAccount(int accountId)
        {
            loggedInUser.DeleteAccount(accountId);
            RefreshAccountListBox(loggedInUser);
        }

        private void renameAccountButton_Click(object sender, EventArgs e)
        {
            if (selectedAccountInfo != null &&
                TryParseAccountId(selectedAccountInfo, out int accountId) &&
                !string.IsNullOrEmpty(selectedAccountInfo))
            {
                string newAccountName = Microsoft.VisualBasic.Interaction.InputBox("Enter a new account name:", "Rename Account", "");

                if (!string.IsNullOrEmpty(newAccountName))
                {
                    Account accountToRename = loggedInUser.GetUserAccounts().FirstOrDefault(acc => acc.AccountId == accountId);
                    if (accountToRename != null)
                    {
                        accountToRename.RenameAccount(newAccountName);
                        FileManager fileManager = new FileManager();
                        fileManager.UpdateUser(loggedInUser);

                        RefreshAccountListBox(loggedInUser);
                    }
                }
            }
        }


        private bool TryParseAccountId(string selectedAccountInfo, out int accountId)
        {
            accountId = 0;
            string[] accountDetails = selectedAccountInfo.Split('|');
            if (accountDetails.Length > 1)
            {
                string[] idDetails = accountDetails[1].Split(':');
                if (idDetails.Length > 1 && int.TryParse(idDetails[1].Trim(), out accountId))
                {
                    return true;
                }
            }
            return false;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            foreach (Account account in loggedInUser.accounts)
            {
                if (account.AccountId == loadedAccountId)
                {
                    account.Deposit(Convert.ToInt32(depositTextBox.Text));
                    depositTextBox.Text = "";
                    FileManager fm = new FileManager();
                    fm.UpdateUserBalance(loggedInUser);
                    RefreshAccountListBox(loggedInUser);

                    balanceLabel.Text = $"Balance:\n {account.Balance}";
                }
            }
        }

        private void depositTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void withdrawTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            foreach (Account account in loggedInUser.accounts)
            {
                if (account.AccountId == loadedAccountId)
                {
                    if (account.Withdrawal(Convert.ToInt32(withdrawTextbox.Text)))
                    {
                        withdrawTextbox.Text = "";
                        FileManager fm = new FileManager();
                        fm.UpdateUserBalance(loggedInUser);
                        RefreshAccountListBox(loggedInUser);

                        balanceLabel.Text = $"Balance:\n {account.Balance}";
                    }
                    else
                    {
                        MessageBox.Show("Not enough money");
                    }
                }
            }
        }
    }
}