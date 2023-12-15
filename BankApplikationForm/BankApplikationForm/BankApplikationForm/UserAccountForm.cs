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
        private string? selectedAccountInfo = null;
        private User? userToTransferTo;
        private User loggedInUser;
        private int? loadedAccountId = null;
        private BankManager bankManager;
        private FileManager fileManager = new FileManager();
        private LoginForm loginForm;
        public UserAccountForm(User loggedInUser, BankManager bankManager, LoginForm loginForm)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            loggedInAsLabel.Text = "You are logged in as:\n" + loggedInUser.Name;
            this.DisplayAccountInfo();
            this.bankManager = bankManager;
            ListUsers();
            LoadAccount();
            ListTransactionsAtStart();
            this.loginForm = loginForm;
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();

        }
        private void userLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayAccountInfo() // Visar information om userns account i accountListBoxen.
        {
            List<string> accountInfoList = loggedInUser.GetAccountInfo();
            accountsListBox.Items.AddRange(accountInfoList.ToArray());
        }

        private void createNewAccountButton_Click(object sender, EventArgs e) 
        {
            createNewAccountButton.Visible = false; //Gömmer knappen och gör text labels tydliga.
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
            if (e.KeyChar == (char)Keys.Enter) // När enter trycks så körs koden för att en ny account skapas.
            {
                string accountName = newAccountNameTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(accountName))
                {
                    loggedInUser.CreateNewAccount(accountName);
                    RefreshAccountListBox(loggedInUser);
                }

                newAccountNameTextBox.Visible = false;
                newAccountNameLabel.Visible = false; //Gömmer textlabels och gör knappen tydlig igen.
                newAccountNameLabel2.Visible = false;
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

        private void transferButton_Click(object sender, EventArgs e) //funktionen för att göra en transfer
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
                                if (loadedAccountId != null)
                                {
                                    UpdateLoadedAccountTransactions();
                                }
                                else
                                {
                                    UpdateTransactionHistory();
                                }

                                balanceLabel2.Text = $"Balance:\n {loggedInUserAccount.Balance} kr";
                                balanceLabel.Text = $"Balance:\n {loggedInUserAccount.Balance} kr";
                            }
                        }
                    }
                }
            }
        }

        private void LoadAccount() //textlabels för account info.
        {
            accountNameLabel.Text = "Account Name:\nNot Loaded";
            accountIdLabel.Text = "Account ID:\nNot Loaded";
            balanceLabel.Text = "Balance:\nNot Loaded";

            accountNameLabel2.Text = "Account Name:\nNot Loaded";
            accountIdLabel2.Text = "Account ID:\nNot Loaded";
            balanceLabel2.Text = "Balance:\nNot Loaded";
        }

        private void loadAccountButton_Click(object sender, EventArgs e) //Laddar accounten som är vald i listbox.
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

                    accountNameLabel2.Text = "Name:\n " + accountName;
                    balanceLabel2.Text = "Balance:\n " + balance;
                    accountIdLabel2.Text = "Account ID:\n " + accountId;

                    loadedAccountId = Convert.ToInt32(accountId);
                    ListLoadedAccountTransactions();
                }
                else
                {
                    MessageBox.Show("Error! Could not retrieve account information.");
                }

                userTabControl.SelectedTab = transactionTab;
            }
        }

        private void deleteAccountButton_Click(object sender, EventArgs e) //Tar bort en account.
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

        private void renameAccountButton_Click(object sender, EventArgs e) // Funktionen för att döpa om ens accounts namn.
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


        private bool TryParseAccountId(string selectedAccountInfo, out int accountId)// letar efter account id.
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

        private void depositButton_Click(object sender, EventArgs e) //funktionen för att sätta in pengar.
        {
            foreach (Account account in loggedInUser.accounts)
            {
                if (account.AccountId == loadedAccountId && depositTextBox.Text != "")
                {
                    account.Deposit(Convert.ToInt32(depositTextBox.Text));
                    depositTextBox.Text = "";
                    fileManager.UpdateUserBalance(loggedInUser);
                    RefreshAccountListBox(loggedInUser);
                    if (loadedAccountId != null)
                    {
                        UpdateLoadedAccountTransactions();
                    }
                    else
                    {
                        UpdateTransactionHistory();
                    }

                    balanceLabel2.Text = $"Balance:\n {account.Balance} kr";
                    balanceLabel.Text = $"Balance:\n {account.Balance} kr";
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

        private void withdrawButton_Click(object sender, EventArgs e) // Funktionen för att ta ut pengar.
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
                        if (loadedAccountId != null)
                        {
                            UpdateLoadedAccountTransactions();
                        }
                        else
                        {
                            UpdateTransactionHistory();
                        }

                        balanceLabel2.Text = $"Balance:\n {account.Balance} kr";
                        balanceLabel.Text = $"Balance:\n {account.Balance} kr";
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


        private void ListTransactionsAtStart() //Listar alla transaction för accounten som är loadat.
        {
            foreach (Transaction transaction in loggedInUser.accounts[0].transactions)
            {
                if (transaction.Type == "Transfer")
                {
                    transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount: {transaction.Amount} kr | SenderId: {transaction.SenderAccountId} | ReceiverId: {transaction.ReceiverAccountId} | Date: {transaction.Date}");
                }
                else
                {
                    transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount {transaction.Amount} kr | SenderId : {transaction.Date}");
                }
            }
        }

        private void UpdateTransactionHistory() // Uppdaterar transaktionshistorikens listruta med transaktioner från det första kontot hos den inloggade användaren, vanligtvis efter en överföring, insättning eller uttag.
        {
            transactionHistoryListBox.Items.Clear();
            foreach (Transaction transaction in loggedInUser.accounts[0].transactions)
            {
                if (transaction.Type == "Transfer")
                {
                    transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount: {transaction.Amount} kr | SenderId: {transaction.SenderAccountId} | ReceiverId: {transaction.ReceiverAccountId} | Date: {transaction.Date}");
                }
                else
                {
                    transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount {transaction.Amount} kr | SenderId : {transaction.Date}");
                }
            }
        }

        private void ListLoadedAccountTransactions() //laddar historiken med det laddade accounts historik.
        {
            transactionHistoryListBox.Items.Clear();
            foreach (Account account in loggedInUser.accounts)
            {
                if (account.AccountId == loadedAccountId)
                {
                    foreach (Transaction transaction in account.transactions)
                    {
                        if (transaction.Type == "Transfer")
                        {
                            transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount: {transaction.Amount} kr | SenderId: {transaction.SenderAccountId} | ReceiverId: {transaction.ReceiverAccountId} | Date: {transaction.Date}");
                        }
                        else
                        {
                            transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount {transaction.Amount} kr | Date: {transaction.Date}");
                        }
                    }
                }
            }
        }

        private void UpdateLoadedAccountTransactions() // Uppdaterar transaktionshistorikens listruta med transaktioner specifikt från det konto som för närvarande är laddat.
        {
            transactionHistoryListBox.Items.Clear();
            foreach (Account account in loggedInUser.accounts)
            {
                if (account.AccountId == loadedAccountId)
                {
                    foreach (Transaction transaction in account.transactions)
                    {
                        if (transaction.Type == "Transfer")
                        {
                            transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount: {transaction.Amount} kr | SenderId: {transaction.SenderAccountId} | ReceiverId: {transaction.ReceiverAccountId} | Date: {transaction.Date}");
                        }
                        else
                        {
                            transactionHistoryListBox.Items.Add($"Id: {transaction.TransactionId} | Type: {transaction.Type} | Amount {transaction.Amount} kr | Date: {transaction.Date}");
                        }
                    }
                }
            }
        }

        private void UpdatePassword_click(object sender, EventArgs e)
        {

            string currentPassword = currentPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmTextBox.Text;

            if (currentPassword == loggedInUser.Password)
            {
                if (newPassword == confirmPassword)
                {
                    loggedInUser.Password = newPassword;
                    FileManager fileManager = new FileManager();
                    fileManager.UpdateUser(loggedInUser);
                    MessageBox.Show("Password updated successfully!");

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

        private void changeUserInformation_click(object sender, EventArgs e) // Låter en user byta deras Info.
        {
            string newName = newNameTextBox.Text;
            string newAddress = newAddressTextBox.Text;
            string newEmail = newEmailTextBox.Text;

            if (!string.IsNullOrEmpty(newEmail) &&
                bankManager.GetUsers().Any(u => u.Email == newEmail && u.UserId != loggedInUser.UserId))
            {
                MessageBox.Show("This email is already in use by another user. Please choose a different email.");
                return;
            }// email är unikt bland varje user.

            int originalId = loggedInUser.UserId; // detta behövdes för att id kunde blandas ihop ifall man gav users samma namn och email på någotsätt.

            if (!string.IsNullOrEmpty(newName))
            {
                loggedInUser.Name = newName;
                loggedInAsLabel.Text = "You are logged in as:\n" + loggedInUser.Name;
                accountNameLabel2.Text = "Account Name:\n" + loggedInUser.accounts[0].AccountName;
                newNameTextBox.Text = "";
            }

            if (!string.IsNullOrEmpty(newAddress))
            {
                loggedInUser.Address = newAddress;
                newAddressTextBox.Text = "";
            }

            if (!string.IsNullOrEmpty(newEmail))
            {
                loggedInUser.Email = newEmail;
                newEmailTextBox.Text = "";
            }

            loggedInUser.UserId = originalId;
            fileManager.UpdateUser(loggedInUser);

            MessageBox.Show("User information updated!");
        }

        
    }
}