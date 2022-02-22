using System;
namespace BankAppEncapsPractice
{
    public class BankAccount
    {
        private double _balance = 0; // private is teh default access modifier for fields in classes; use underscore for private field names

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public double GetBalance()
        {
        return _balance;
        }

    }
}
