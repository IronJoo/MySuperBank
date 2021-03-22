using System;

namespace MySuperBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Joana", 1000);
            Console.WriteLine($"Account {account.Number} was created {account.Owner} with {account.Balance}");
        }
    }
}
