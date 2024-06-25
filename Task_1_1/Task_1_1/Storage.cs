namespace Task_1_1
{
    internal class Storage
    {
        public List<Transaction> Transactions
        {
            get
            {
                return transactionList;
            }
        }

        public List<Client> Clients
        {
            get
            {
                return clientsList;
            }
        }

        public Storage()
        {
            transactionList = new List<Transaction>();
            clientsList = new List<Client>();
        }

        private List<Transaction> transactionList;
        private List<Client> clientsList;

        public void AddToClientList(Client client)
        {
            clientsList.Add(client);
        }

        public void RemoveClient(Client client)
        {
            clientsList.Remove(client);
        }

        public void AddToTransactionList(Transaction transaction)
        {
            transactionList.Add(transaction);
        }

        public List<Client> GetClientList()
        {
            return clientsList;
        }

        public List<Transaction> GetTransactionList()
        {
            return transactionList;
        }
    }
}