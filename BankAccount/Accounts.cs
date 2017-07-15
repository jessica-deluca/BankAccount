using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Accounts // base class
    {
        protected string type;
        protected string accountNumber;
        protected double balance;

        public string AccountNumber { get; }
        public double Balance { get; }
        public string Type { get; }

        public Accounts()
        {
            //default contructor
        }

        public Accounts(double balance)
        {
            this.balance = balance;
        }

        public virtual void View() // user can view current balance
        {
            Console.WriteLine("Balance: $" + balance);
        }

        public virtual void Deposit() // user can deposit money into account
        {
            Console.WriteLine("Enter deposit amount.");
            double amountDeposited = double.Parse(Console.ReadLine()); 
            balance += amountDeposited;
            Console.WriteLine("Current balance: $" + balance);
        }

        public virtual double Withdraw() // user can withdraw money from account
        {
            Console.WriteLine("Enter withdraw amount.");
            double amountWithdrawn = double.Parse(Console.ReadLine()); 
            balance -= amountWithdrawn;
            return balance;
        }
    }
}
