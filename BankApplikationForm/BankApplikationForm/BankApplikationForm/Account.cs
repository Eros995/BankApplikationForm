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
        public List<Transaction> transactions = new List<Transaction>();

        public Account(string accountName)
        {
            Balance = 0;
            AccountId = nextId++;
            AccountName = accountName;
        }

        public void Deposit()
        {

        }

        public void Withdrawal()
        {

        }

        public void TransferMoney()
        {

        }

        public void GetTransactionHistory()
        {

        }
    }
}
