namespace Task_1_1
{
    internal class Client : Person
    {
        public string Name { get; set; }

        public int AccountNumber { get; set; }

        public int ClientId { get; set; }

        public Client(int id, int personId, string adress, string clientName, int accountNum)
        : base(personId, adress, clientName)
        {
            this.ClientId = id;
            this.Name = clientName;
            this.AccountNumber = accountNum;
            this.clientBalance = new Balance(accountNum, ClientId);
        }

        private Transaction transaction;
        private Balance clientBalance;

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
                return $"Not enough money on your balance, {Name}";
            }
            clientBalance.UpdateBalance(-amount);
            return "Succes";
        }
    }
}
