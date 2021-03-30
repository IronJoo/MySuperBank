using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Joana", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammok");

            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");

            Console.WriteLine(account.GetAccountHistory());

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

        }
    }
}
