using System;

namespace BankAppEncapsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checkingAccount = new BankAccount();
                      

            Console.WriteLine($"Please enter the amount you would like to deposit: ");

            double amount = 0.0;

            bool validDeposit = false;

            while (!validDeposit)
            {
                if(double.TryParse(Console.ReadLine(), out amount))
                {
                    validDeposit = true;

                }
                else
                {
                    Console.WriteLine($"Please enter a valid ammount!");
                }
            }

            checkingAccount.Deposit(amount);

            Console.WriteLine($"Your Balance is now: {checkingAccount.GetBalance()}");

        }

    }
}
