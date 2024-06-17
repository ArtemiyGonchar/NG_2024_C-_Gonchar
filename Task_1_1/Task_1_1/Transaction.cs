﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
    internal class Transaction
    {
        private int transaction_id;
        private int amount;
        private string timestamp;

        public void record_transaction(int id, int amount)
        {
            this.transaction_id = id;
            this.amount = amount;
            this.timestamp = DateTime.Now.ToString("yyyy/MM/dd");
        }

        public string get_transaction_details()
        {
            return $"ID:{transaction_id}, AMOUNT:{amount}, TIME:{timestamp}";
        }
    }
}
