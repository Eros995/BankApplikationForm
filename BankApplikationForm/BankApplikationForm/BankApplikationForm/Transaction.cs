using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    public class Transaction
    {
        private int nextId = 0;
        public int TransactionId { get; set; }
        public Account? SenderAccount { get; set; }
        public Account? ReceiverAccount { get; set; }
        public double Amount { get; set; }
        public string? Date {  get; set; }

        public Transaction(Account senderAccount, Account receiverAccount, double amount)
        {
            TransactionId = nextId++;
            SenderAccount = senderAccount;
            ReceiverAccount = receiverAccount;
            Amount = amount;
            Date = DateTime.Today.ToLongDateString();
        }

        public void RegisterTransaction()
        {

        }

        public void GetTransactionInformation()
        {

        }
    }
}
