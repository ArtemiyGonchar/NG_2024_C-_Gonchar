using System;

namespace Task_1_1
{
	internal class Storage
	{
		public Storage()
		{
			transactions_list = new List<Transaction> ();
			clients_list = new List<Person>();
		}

		private List<Transaction> transactions_list;
		private List<Person> clients_list;

		public List<Transaction> Transactions { get { return transactions_list; } }
		public List<Person> Clients { get { return clients_list; } }

		public void add_to_clientlist(Person person)
		{
            clients_list.Add(person);
        }

		public void remove_client(Person person)
		{
			clients_list.Remove(person);
		}

		public void add_to_transactionlist(Transaction transaction)
		{
			transactions_list.Add(transaction);
        }

		public List<Person> get_clientlist() { return clients_list; }

		public List<Transaction> get_transactionlist() { return transactions_list; }
	}
}