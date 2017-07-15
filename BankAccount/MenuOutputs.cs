using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class MenuOutputs : Menus // MenusOutputs class inheriting from Menus class
    {
        public override void CreateAccountTypeMenu() // create Checking or Savings Account menu
        {
            Console.WriteLine("Choose an option from the menu below:");
            string[] accountMenu = { "a. Checking Account", "b. Savings Account" };
            Console.WriteLine(accountMenu[0]);
            Console.WriteLine(accountMenu[1]);
        }

        public override void InvalidEntryResponse() // give user same response when entry is invalid
        {
            Console.WriteLine("Incorrect Entry.");
        }
    }
}
