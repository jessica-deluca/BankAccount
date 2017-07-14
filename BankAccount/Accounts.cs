using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Accounts // base class
    {
        // All accounts must include the following:

        // An account number
        // Balance
        // An account type(savings or checking)

        protected string accountNumber;
        protected double balance;
        protected string type;

        // properties (characteristics)

        public string AccountNumber { get; }
        public double Balance { get; }
        public string Type { get; }

        // methods (verbs)

        public Accounts()
        {
            //default contructor
        }

        // A way to view the current balance
        public virtual void View()
        {
            // Console.WriteLine(balance);
        }

        // User must be able to deposit money into either account
        public virtual void Desposit()
        {
            // Console.WriteLine("Enter deposit amount.");
            // double amountDeposited = double.Parse(Console.ReadLine()); 
            // balance += amountDeposited;
            // Console.WriteLine("Current balance: " + balance);
        }

        // User must be able to withdraw money from either account
        public virtual void Withdraw()
        {
            // Console.WriteLine("Enter withdraw amount.");
            // double amountWithdrawn = double.Parse(Console.ReadLine()); 
            // balance -= amountWithdrawn;
            // Console.WriteLine("Current balance: " + balance);
        }
    }
}
