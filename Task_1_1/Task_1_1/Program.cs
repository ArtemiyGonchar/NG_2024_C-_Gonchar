using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Task_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gonchar Bank.");
            Console.WriteLine("List of commands (enter from 1 to ...):\n" +
                "1 - add client to the system.\n" +
                "2 - remove client from the system.\n" +
                "3 - view transaction history.\n" +
                "4 - get current balance.\n" +
                "5 - Deposit.\n" +
                "6 - Withdraw.\n" +
                "7 - exit.\n");

            int adminIdCount = 1;
            int personIdCount = 1;
            int clientIdCount = 1;
            int accountIdCount = 1;
            int transactionIdCount = 1;

            string amount;

            Storage storage = new Storage();
            Admin admin = new Admin(0, "Super-admin", 0, 0, "kukarekovo", "artem", 0); 
            Client client;
            Transaction transaction;

            while (true)
            {
                Console.Write("Enter command: ");
                string action = Console.ReadLine().ToString();

                switch (action)
                {
                    case "1":

                        string name = "";
                        string adress = "";

                        do
                        {
                            Console.Write("Enter client`s name: ");
                            name = Console.ReadLine().ToString();

                            Console.Write("Enter client`s adress: ");
                            adress = Console.ReadLine().ToString();

                        } while (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(adress));

                        client = new Client(clientIdCount, personIdCount, adress, name, accountIdCount);
                        admin.AddClient(storage, client);

                        clientIdCount++;
                        personIdCount++;
                        accountIdCount++;
                        break;

                    case "2":
                        string id = "";
                        do
                        {
                            Console.Write("Enter client`s account id: ");
                            id = Console.ReadLine().ToString();
                        } while (string.IsNullOrEmpty(id));

                        for (int i = 0; i < storage.Clients.Count; i++)
                        {
                            if (storage.Clients[i].PersonId == int.Parse(id))
                            {
                                admin.RemoveClient(storage, storage.Clients[i]);
                                Console.WriteLine("Deleted");
                            }
                            else
                            {
                                Console.WriteLine("No such client");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine(admin.ViewTransactions(storage));
                        break;

                    case "4":
                        Console.WriteLine("Balance: " + admin.GetBalance());
                        break;

                    case "5":
                        Console.Write("Enter amount: ");
                        amount = Console.ReadLine().ToString();
                        admin.Deposit(int.Parse(amount));

                        transaction = new Transaction();
                        transaction.record_transaction(transactionIdCount, int.Parse(amount));
                        storage.AddToTransactionList(transaction);
                        transactionIdCount++;
                        break;

                    case "6":
                        Console.Write("Enter amount: ");
                        amount = Console.ReadLine().ToString();
                        admin.Withdraw(int.Parse(amount));

                        transaction = new Transaction();
                        transaction.record_transaction(transactionIdCount, int.Parse(amount));
                        storage.AddToTransactionList(transaction);
                        transactionIdCount++;
                        break;

                    case "7":
                        return;
                        break;                 
                }
            }
            Console.ReadLine();//
        }
    }
}
