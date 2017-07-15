using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Accounts // Checking class inheriting from Accounts class
    {
        // needs to include 1 constructor
        public CheckingAccount()
        {
            //default constructor
        }

        public CheckingAccount(double balance)
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
