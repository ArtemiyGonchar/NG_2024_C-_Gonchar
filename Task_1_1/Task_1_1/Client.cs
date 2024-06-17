using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
    internal class Client
    {
        public Client(int id, string client_name, int account_num) {
            this.client_id = id;
            this.name = client_name;
            this.account_number = account_num;
            this.client_balance = new Balance(account_num, client_id);
        }

        private Transaction transaction;
        private Balance client_balance;
        private int client_id;
        private string name;
        private int account_number;

        public string Name { get { return name; } }
        public int AccountNumber { get { return account_number; } }
        public int ClientId { get { return client_id; } }

        public void deposit(int amount)
        {
            client_balance.update_balance(amount);
        }

        public int get_balance()
        {
            return client_balance.get_balance();
        }

        public string withdraw(int amount)
        {
            int balance = client_balance.get_balance();
            if (amount > balance) 
            {
                return $"Not enough money on your balance, {name}";
            }
            client_balance.update_balance(-amount);
            return "Succes";
        }
    }
}
