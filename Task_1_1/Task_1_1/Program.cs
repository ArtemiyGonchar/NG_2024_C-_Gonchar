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
                "5 - deposit.\n" +
                "6 - withdraw.\n" +
                "7 - exit.\n");

            int admin_id_count = 1;
            int person_id_count = 1;
            int account_id_count = 1;
            int transaction_id_count = 1;

            string amount;

            Storage storage = new Storage();
            Admin admin = new Admin("Super-admin", 0, 0, "kukarekovo", "artem", 0); 
            Person person;
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

                        person = new Person(person_id_count, adress, name, account_id_count);
                        admin.add_client(storage, person);

                        person_id_count++;
                        account_id_count++;
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
                                admin.remove_client(storage, storage.Clients[i]);
                                Console.WriteLine("Deleted");
                            }
                            else
                            {
                                Console.WriteLine("No such client");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine(admin.view_transactions(storage));
                        break;

                    case "4":
                        Console.WriteLine("Balance: " + admin.get_balance());
                        break;

                    case "5":
                        Console.Write("Enter amount: ");
                        amount = Console.ReadLine().ToString();
                        admin.deposit(int.Parse(amount));

                        transaction = new Transaction();
                        transaction.record_transaction(transaction_id_count, int.Parse(amount));
                        storage.add_to_transactionlist(transaction);
                        transaction_id_count++;
                        break;

                    case "6":
                        Console.Write("Enter amount: ");
                        amount = Console.ReadLine().ToString();
                        admin.withdraw(int.Parse(amount));

                        transaction = new Transaction();
                        transaction.record_transaction(transaction_id_count, int.Parse(amount));
                        storage.add_to_transactionlist(transaction);
                        transaction_id_count++;
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
