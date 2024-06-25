using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
    internal class Transaction
    {
        private int transactionId;
        private int amount;
        private string timestamp;

        public void record_transaction(int id, int amount)
        {
            this.transactionId = id;
            this.amount = amount;
            this.timestamp = DateTime.Now.ToString("yyyy/MM/dd");
        }

        public string get_transaction_details()
        {
            return $"ID:{transactionId}, AMOUNT:{amount}, TIME:{timestamp}";
        }
    }
}
