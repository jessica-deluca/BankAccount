using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Accounts // Savings class inheriting from Accounts class
    {
        private double minimumBalance;

        public double MinimumBalance { get; }

        public SavingsAccount()
        {
            // default constructor
        }

        public SavingsAccount(double balance) // starting balance can be entered in Program class
        {
            this.balance = balance;
        }

        public override double Withdraw()
        {
            minimumBalance = 500d;

            Console.WriteLine("Enter withdraw amount.");
            double amountWithdrawn = double.Parse(Console.ReadLine());
            balance -= amountWithdrawn; // new balance = amount withdrawn - balance
            while (balance < minimumBalance)
            {
                balance += amountWithdrawn; // add withdrawn amount back in
                Console.WriteLine("Withdraw amount exceeds minimum balance of $" + minimumBalance + ". Please enter a new amount.");
                amountWithdrawn = double.Parse(Console.ReadLine());
                balance -= amountWithdrawn;
            }
            return balance;
        }
    }
}
