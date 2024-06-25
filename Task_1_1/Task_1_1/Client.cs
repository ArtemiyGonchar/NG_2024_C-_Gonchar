using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
    internal class Client : Person
    {
        public string Name
        {
            get { return name; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public int ClientId
        { 
            get { return clientId; }
        }

        public Client(int id, int personId, string adress, string clientName, int accountNum)
        : base (personId, adress, clientName)
        {
            this.clientId = id;
            this.name = clientName;
            this.accountNumber = accountNum;
            this.clientBalance = new Balance(accountNum, clientId);
        }

        private Transaction transaction;
        private Balance clientBalance;
        private int clientId;
        private string name;
        private int accountNumber;

        public void Deposit(int amount)
        {
            clientBalance.UpdateBalance(amount);
        }

        public int GetBalance()
        {
            return clientBalance.GetBalance();
        }

        public string Withdraw(int amount)
        {
            int balance = clientBalance.GetBalance();
            if (amount > balance) 
            {
                return $"Not enough money on your balance, {name}";
            }
            clientBalance.UpdateBalance(-amount);
            return "Succes";
        }
    }
}
