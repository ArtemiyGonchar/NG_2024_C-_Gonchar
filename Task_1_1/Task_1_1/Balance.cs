namespace Task_1_1
{
    internal class Balance
    {
        public Balance(int balanceId, int clientId)
        {
            this.clientId = clientId;
            this.balanceId = balanceId;
            balanceAmount = 0; //imagine that client doesnt Deposit money when creating account :)
        }

        private int balanceId;
        private int clientId; //attached to balanceId
        private int balanceAmount;

        public int GetBalance()
        {
            return balanceAmount;
        }

        public void UpdateBalance(int amount)
        {
            balanceAmount += amount;
        }
    }
}
