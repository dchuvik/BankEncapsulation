using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount userBankAccount = new BankAccount();
            Console.WriteLine($"Please input how much you would like to deposit: ");
            userBankAccount.Deposit(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Your bank balance is {userBankAccount.GetBalance()}");
        }
    }
}
