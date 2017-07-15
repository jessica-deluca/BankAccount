using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class MenuOutputs : Menus
    {
        public override void CreateMenu()
        {
            Console.WriteLine("Choose an option from the menu below:");
            string[] accountMenu = { "a. Checking Account", "b. Savings Account" };
            Console.WriteLine(accountMenu[0]);
            Console.WriteLine(accountMenu[1]);
        }

        public override void InvalidEntryResponse()
        {
            Console.WriteLine("Incorrect Entry.");
        }
    }
}
