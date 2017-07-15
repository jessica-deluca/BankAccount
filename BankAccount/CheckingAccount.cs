using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Accounts // Checking class inheriting from Accounts class
    {
        //how to hardcode balance here so that it doesn't have to be repeated below???

        // needs to include 1 constructor
        public CheckingAccount()
        {
            //default constructor
        }

        public override void View()
        {
            balance = 20000d;
            base.View();
        }

        public override void Deposit()
        {
            balance = 20000d;
            base.Deposit();
        }

        public override void Withdraw()
        {
            balance = 20000d;
            base.Withdraw();
        }

    }
}
