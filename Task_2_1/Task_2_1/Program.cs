using Task_2_1.Services;
namespace Task_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encoder encoder = new Encoder();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            string hashedPassword = encoder.HashPassword(password);
            Console.WriteLine(hashedPassword);
        }
    }
}
