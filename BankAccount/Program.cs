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
            // STRETCH TASK - started thinking of ideas for how to accomplish stretch task but did not finished

            //string clientUserName;

            //Console.WriteLine("Please enter your username.");
            //clientUserName = Console.ReadLine();

            //Dictionary<string, string> userNames = new Dictionary<string, string>()
            //{
            //    { "username1", "client1" }, // { "key", "value" }
            //    { "username2", "client2" },
            //    { "Dusername3", "client3" },
            //    { "LLusername4", "client4" }
            //};

            //foreach (KeyValuePair<string, string> userName in userNames)
            //{
            //    if (clientUserName == userNames.Key) // if user name entered is equal to any of the keys in the dictionary
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect user name.");
            //    }

            //}

            string returnMenuOptionSelected;

            Client client1 = new Client(); // instantiate client object
            CheckingAccount checkingAccount1 = new CheckingAccount(20000d); // instantiate checking account object with starting balance
            SavingsAccount savingsAccount1 = new SavingsAccount(1000000d); // instantiate savings account object with starting balance
            MenuOutputs accountTypeMenu = new MenuOutputs(); // instantiate account type menu object
            MenuOutputs invalidEntry = new MenuOutputs(); // instantiate invalid entry object
            MenuOutputs exitRepsonse = new MenuOutputs(); // instantiate exit response object

            do
            {
                Console.WriteLine("Choose an option from the menu below:");
                string[] mainMenu = { "1. View Client Information", "2. View Account Balance", "3. Deposit Funds", "4. Withdraw Funds", "5. Exit" };
                Console.WriteLine(mainMenu[0]);
                Console.WriteLine(mainMenu[1]);
                Console.WriteLine(mainMenu[2]);
                Console.WriteLine(mainMenu[3]);
                Console.WriteLine(mainMenu[4]);

                string mainMenuOptionSelected = Console.ReadLine();

                if (mainMenuOptionSelected == "1") // View Client Information
                {
                    client1.View(); // calls View from Client class
                }
                else if (mainMenuOptionSelected == "2") // View Account Balance
                {
                    accountTypeMenu.CreateAccountTypeMenu();

                    string accountInformationMenuOptionSelected = Console.ReadLine().ToLower();

                    if (accountInformationMenuOptionSelected == "a") // Checking Account
                    {
                        checkingAccount1.View(); // calls View from CheckingAccount class
                    }
                    else if (accountInformationMenuOptionSelected == "b") // Savings Account
                    {
                        savingsAccount1.View(); // calls View from SavingsAccount class
                    }
                    else
                    {
                        invalidEntry.InvalidEntryResponse();
                    }
                }
                else if (mainMenuOptionSelected == "3") // Deposit Funds
                {
                    accountTypeMenu.CreateAccountTypeMenu();

                    string depositFundsMenuOptionSelected = Console.ReadLine().ToLower();

                    if (depositFundsMenuOptionSelected == "a") // Checking Account
                    {
                        checkingAccount1.Deposit(); // calls Deposit from CheckingAccount class
                    }
                    else if (depositFundsMenuOptionSelected == "b") // Savings Account
                    {
                        savingsAccount1.Deposit(); // calls Deposit from SavingsAccount class
                    }
                    else
                    {
                        invalidEntry.InvalidEntryResponse();
                    }
                }
                else if (mainMenuOptionSelected == "4") // Withdraw Funds
                {
                    accountTypeMenu.CreateAccountTypeMenu();

                    string withdrawFundsMenuOptionSelected = Console.ReadLine().ToLower();

                    if (withdrawFundsMenuOptionSelected == "a") // Checking Account
                    {
                        Console.WriteLine("Current balance: $" + checkingAccount1.Withdraw()); // calls Deposit from CheckingAccount class
                    }
                    else if (withdrawFundsMenuOptionSelected == "b") // Savings Account
                    {
                        Console.WriteLine("Current balance: $" + savingsAccount1.Withdraw()); // calls Deposit from SavingsAccount class
                    }
                    else
                    {
                        invalidEntry.InvalidEntryResponse();
                    }
                }
                else if (mainMenuOptionSelected == "5") // Exit
                {
                    exitRepsonse.ExitResponse();
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
                returnMenuOptionSelected = Console.ReadLine();
                if (returnMenuOptionSelected == "2")
                {
                    exitRepsonse.ExitResponse();
                }
            }
            while (returnMenuOptionSelected == "1"); // returns to main menu
        }
    }
}