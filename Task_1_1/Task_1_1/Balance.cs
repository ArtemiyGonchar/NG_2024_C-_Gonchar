using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
    internal class Balance
    {
        public Balance(int balance_id, int client_id)
        {
            this.client_id = client_id;
            this.balance_id = balance_id;
            balance_amount = 0; //imagine that client doesnt deposit money when creating account :)
        }

        private int balance_id;
        private int client_id; //attached to balance_id
        private int balance_amount;

        public int get_balance() { return balance_amount; }
        public void update_balance(int amount) { balance_amount += amount; }
    }
}
