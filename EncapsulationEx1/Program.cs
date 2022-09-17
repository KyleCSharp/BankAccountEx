using System;

namespace EncapsulationEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("your new bank account has been set up, and has a balance of 0");
            Console.WriteLine("how much would you like to deposit");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);
            Console.WriteLine($"The new account balance is...${account.GetBalance()}");
           
            Console.WriteLine("Thank you!");


        }
    }
}
