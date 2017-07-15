using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Accounts // Savings class inheriting from Accounts class
    {
        protected double minimumBalance;

        public double MinimumBalance { get; }

        public SavingsAccount()
        {
            //default constructor
        }

        public SavingsAccount(double balance)
        {
            this.balance = balance;
        }

        public override double Withdraw() // NEED TO FIX
        {
            minimumBalance = 500d;

            Console.WriteLine("Enter withdraw amount.");
            double amountWithdrawn = double.Parse(Console.ReadLine());
            balance -= amountWithdrawn;
            while (balance < minimumBalance)
            {
                Console.WriteLine("Withdraw amount exceeds minimum balance of " + minimumBalance + ". Please enter a new amount.");
                amountWithdrawn = double.Parse(Console.ReadLine());
                balance -= amountWithdrawn;
            }
            return balance;
        }
    }
}
