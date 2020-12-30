using System;

namespace MyBank
{
    public class program
    {

        static void Main(string[] args)
        {

            var account = new BankAccount("Demola", 200000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(10000, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caugth creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account.GetAccountHistory());






        }

    
    }
}
