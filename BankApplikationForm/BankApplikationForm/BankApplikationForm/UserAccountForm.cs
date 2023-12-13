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
        private User userToTransferTo;
        private User loggedInUser;
        private int loadedAccountId;
        private BankManager bankManager;
        private FileManager fileManager = new FileManager();
        public UserAccountForm(User loggedInUser, BankManager bankManager)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            loggedInAsLabel.Text = "You are logged in as:\n" + loggedInUser.Name;
            this.DisplayAccountInfo();
            this.bankManager = bankManager;
            ListUsers();
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

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedUserInfo = userListBox.SelectedItem.ToString();
            userAccountsListBox.Items.Clear();

            if (selectedUserInfo != null)
            {
                string[] userDetails = selectedUserInfo.Split('|');

                string userId = userDetails[0].Split(':')[1].Trim();

                foreach (User user in bankManager.GetUsers())
                {
                    if (user.UserId == Convert.ToInt32(userId))
                    {
                        userToTransferTo = user;
                        foreach (Account account in user.accounts)
                        {
                            userAccountsListBox.Items.Add($"Name: {account.AccountName} | Id: {account.AccountId}");
                        }
                        break;
                    }
                }
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (userAccountsListBox.SelectedItem != null && transferTextBox.Text != "")
            {
                string? selectedAccount = userAccountsListBox.SelectedItem.ToString();
                string[] accountDetails = selectedAccount.Split('|');
                string accountId = accountDetails[1].Split(':')[1].Trim();

                foreach (Account account in userToTransferTo.accounts)
                {
                    if (account.AccountId == Convert.ToInt32(accountId))
                    {
                        foreach (Account loggedInUserAccount in loggedInUser.accounts)
                        {
                            if (loggedInUserAccount.AccountId == loadedAccountId)
                            {
                                loggedInUserAccount.TransferMoney(account.AccountId, Convert.ToInt32(transferTextBox.Text));
                                account.ReceiveMoney(loggedInUserAccount.AccountId, Convert.ToInt32(transferTextBox.Text));
                                transferTextBox.Text = "";
                                fileManager.UpdateUserBalance(loggedInUser);
                                fileManager.UpdateUserBalance(userToTransferTo);
                                RefreshAccountListBox(loggedInUser);

                                balanceLabel.Text = $"Balance:\n {loggedInUserAccount.Balance}";
                            }
                        }
                    }
                }
            }
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
                if (account.AccountId == loadedAccountId && depositTextBox.Text != "")
                {
                    account.Deposit(Convert.ToInt32(depositTextBox.Text));
                    depositTextBox.Text = "";
                    fileManager.UpdateUserBalance(loggedInUser);
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

        private void transferTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (account.AccountId == loadedAccountId && withdrawTextbox.Text != "")
                {
                    if (account.Withdrawal(Convert.ToInt32(withdrawTextbox.Text)))
                    {
                        withdrawTextbox.Text = "";
                        fileManager.UpdateUserBalance(loggedInUser);
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

        private void ListUsers()
        {
            foreach (User user in bankManager.GetUsers())
            {
                userListBox.Items.Add($"Id: {user.UserId} | {user.Name}");
            }
        }


    }
}