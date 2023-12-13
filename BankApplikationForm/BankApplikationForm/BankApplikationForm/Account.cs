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
        public List<Transaction> transactions = new List<Transaction>();

        public double Balance { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }

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

        public bool Withdrawal(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                transactions.Add(new Transaction("Withdrawal", -amount));
                return true;
            }
            return false;
        }

        public void TransferMoney(int receiverAccountId, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                transactions.Add(new Transaction(AccountId, receiverAccountId, -amount));
            }
        }

        public void ReceiveMoney(int senderAccountId, double amount)
        {
            Balance += amount;
            transactions.Add(new Transaction(senderAccountId, AccountId, amount));
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
