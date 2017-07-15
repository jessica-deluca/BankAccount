using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Accounts // Checking class inheriting from Accounts class
    {
        public CheckingAccount()
        {
            //default constructor
        }

        public CheckingAccount(double balance)
        {
            this.balance = balance;
        }
    }
}
