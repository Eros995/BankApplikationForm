using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankApplikationForm
{
    public class Account
    {
        public static int nextId = 0;
        public double Balance { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        private List<Transaction> transactions = new List<Transaction>();

        public Account(string accountName)
        {
            Balance = 0;
            AccountId = nextId++;
            AccountName = accountName;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            transactions.Add(new Transaction("Deposit", amount));
        }

        public void Withdrawal(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                transactions.Add(new Transaction("Withdrawal", -amount));
            }
        }

        public void TransferMoney(Account receiverAccount, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                receiverAccount.Balance += amount;
                transactions.Add(new Transaction(this, receiverAccount, amount));
            }
        }

        public List<Transaction> GetTransactionHistory()
        {
            return transactions;
        }

        public void RenameAccount(string newAccountName)
        {
            AccountName = newAccountName;
        }
    }
}
