using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Accounts // Savings class inheriting from Accounts class
    {

        // needs to include 1 constructor & 1 property
        // Savings Account must include a minimum balance
        // User cannot withdraw money if balance will drop below minimum

        public SavingsAccount()
        {
            //default constructor
        }

        public SavingsAccount(double balance)
        {
            this.balance = balance;
        }

        public override void View()
        {
            base.View();
        }

        public override void Deposit()
        {
            base.Deposit();
        }

        public override void Withdraw()
        {
            base.Withdraw();
        }
    }
}
