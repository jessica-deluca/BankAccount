﻿using System;
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

        // properties (characteristics)

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

        // A way to view the current balance
        public virtual void View()
        {
            Console.WriteLine("Balance: $" + balance);
        }

        // User must be able to deposit money into either account
        public virtual void Deposit()
        {
            Console.WriteLine("Enter deposit amount.");
            double amountDeposited = double.Parse(Console.ReadLine()); 
            balance += amountDeposited;
            Console.WriteLine("Current balance: $" + balance);
        }

        // User must be able to withdraw money from either account
        public virtual double Withdraw()
        {
            Console.WriteLine("Enter withdraw amount.");
            double amountWithdrawn = double.Parse(Console.ReadLine()); 
            balance -= amountWithdrawn;
            return balance;
        }
    }
}
