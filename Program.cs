using System;

namespace BankClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.Age = 30;

            BankAccount bankAccount = new BankAccount(client);

            Console.WriteLine(bankAccount.CalculateExtraRate());
        }
    }
}
