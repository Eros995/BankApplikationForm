using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    public class Transaction
    {
        private static int nextId = 0;

        public int TransactionId { get; set; }
        public int? SenderAccountId { get; set; }
        public int? ReceiverAccountId { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public string? Date {  get; set; }

        public Transaction(int senderAccountId, int receiverAccountId, double amount)
        {
            TransactionId = nextId++;
            SenderAccountId = senderAccountId;
            ReceiverAccountId = receiverAccountId;
            Type = "Transfer";
            Amount = amount;
            Date = DateTime.Today.ToShortDateString();
        }

        public Transaction(string type, double amount)
        {
            TransactionId = nextId++;
            SenderAccountId = null;
            ReceiverAccountId = null;
            Type = type;
            Amount = amount;
            Date = DateTime.Today.ToShortDateString();
        }
        public Transaction()
        {
            TransactionId = nextId++;
            SenderAccountId = null;
            ReceiverAccountId = null;
            Type = "Transfer";
            Amount = Amount;
            Date = DateTime.Today.ToShortDateString();
        }

    }
}
