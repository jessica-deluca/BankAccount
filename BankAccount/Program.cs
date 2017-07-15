using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIX SAVINGS ACCOUNT RESTRICTION

            // STRETCH TASK
            // Giving the ability to enter a user name when the program begins would make the program useful for multiple users.
            // Let user log-in with their username (do not worry about trying to add passwords)

            //string clientUserName;

            //do
            //{
            //    Console.WriteLine("Please enter your username.");
            //    clientUserName = Console.ReadLine().ToLower();

            //    Dictionary<string, string> userNames = new Dictionary<string, string>()
            //    {
            //        { "jessicaUserName", "?" }, // { "key", "value" }
            //        { "jordanUserName", "?" },
            //        { "danielUserName", "?" },
            //        { "laurenUserName", "?" }
            //    };

            //    foreach (KeyValuePair<string, string> userName in userNames)
            //    {
            //        if (clientUserName == userName.Key) // if clientUserName is equal to any of the keys in the dictionary
            //        {
            //            Client client1 = new Client(); //then instantiate client object
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect user name.");
            //        }
            //    }
            //}
            //while (clientUserName != userName.Key);


            int returnMenuOptionSelected;

            Client client1 = new Client(); // instantiate client object
            CheckingAccount checkingAccount1 = new CheckingAccount(20000d); // instantiate checking account object with starting balance
            SavingsAccount savingsAccount1 = new SavingsAccount(1000000d); // instantiate savings account object with starting balance
            MenuOutputs accountTypeMenu = new MenuOutputs(); // instantiate account type menu object
            MenuOutputs invalidEntry = new MenuOutputs(); // instantiate invalid entry object

            do
            {
                Console.WriteLine("Choose an option from the menu below:");
                string[] mainMenu = { "1. View Client Information", "2. View Account Balance", "3. Deposit Funds", "4. Withdraw Funds", "5. Exit" };
                Console.WriteLine(mainMenu[0]);
                Console.WriteLine(mainMenu[1]);
                Console.WriteLine(mainMenu[2]);
                Console.WriteLine(mainMenu[3]);
                Console.WriteLine(mainMenu[4]);

                int mainMenuOptionSelected = int.Parse(Console.ReadLine());

                if (mainMenuOptionSelected == 1) // View Client Information
                {
                    client1.View(); // calls View from Client class
                }
                else if (mainMenuOptionSelected == 2) // View Account Balance
                {
                    accountTypeMenu.CreateAccountTypeMenu();

                    char accountInformationMenuOptionSelected = char.Parse(Console.ReadLine().ToLower());

                    if (accountInformationMenuOptionSelected == 'a') // Checking Account
                    {
                        checkingAccount1.View(); // calls View from CheckingAccount class
                    }
                    else if (accountInformationMenuOptionSelected == 'b') // Savings Account
                    {
                        savingsAccount1.View(); // calls View from SavingsAccount class
                    }
                    else
                    {
                        invalidEntry.InvalidEntryResponse();
                    }
                }
                else if (mainMenuOptionSelected == 3) // Deposit Funds
                {
                    accountTypeMenu.CreateAccountTypeMenu();

                    char depositFundsMenuOptionSelected = char.Parse(Console.ReadLine().ToLower());

                    if (depositFundsMenuOptionSelected == 'a') // Checking Account
                    {
                        checkingAccount1.Deposit(); // calls Deposit from CheckingAccount class
                    }
                    else if (depositFundsMenuOptionSelected == 'b') // Savings Account
                    {
                        savingsAccount1.Deposit(); // calls Deposit from SavingsAccount class
                    }
                    else
                    {
                        invalidEntry.InvalidEntryResponse();
                    }
                }
                else if (mainMenuOptionSelected == 4) // Withdraw Funds
                {
                    accountTypeMenu.CreateAccountTypeMenu();

                    char withdrawFundsMenuOptionSelected = char.Parse(Console.ReadLine().ToLower());

                    if (withdrawFundsMenuOptionSelected == 'a') // Checking Account
                    {
                        Console.WriteLine("Current balance: $" + checkingAccount1.Withdraw()); // calls Deposit from CheckingAccount class
                    }
                    else if (withdrawFundsMenuOptionSelected == 'b') // Savings Account
                    {
                        Console.WriteLine("Current balance: $" + savingsAccount1.Withdraw()); // calls Deposit from SavingsAccount class
                    }
                    else
                    {
                        invalidEntry.InvalidEntryResponse();
                    }
                }
                else if (mainMenuOptionSelected == 5) // Exit
                {
                    Console.WriteLine("Thank you. Have a nice day!");
                    return;
                }
                else
                {
                    invalidEntry.InvalidEntryResponse();
                }

                Console.WriteLine("Return to main menu or exit?");
                string[] returnMenu = { "1. Main Menu", "2. Exit" };
                Console.WriteLine(returnMenu[0]);
                Console.WriteLine(returnMenu[1]);
                returnMenuOptionSelected = int.Parse(Console.ReadLine());
                if (returnMenuOptionSelected == 2)
                {
                    Console.WriteLine("Thank you. Have a nice day!");
                }
            }
            while (returnMenuOptionSelected == 1); // returns to main menu
        }
    }
}
