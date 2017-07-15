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
            // how can client 1 continue to make deposits & withdraws?

            int returnMenuOptionSelected;

            Client client1 = new Client(); //instantiate client object
            CheckingAccount checkingAccount1 = new CheckingAccount(); //instantiate checking account object
            SavingsAccount savingsAccount1 = new SavingsAccount(); //instantiate savings account object

            do
            {
                Console.WriteLine("Choose an option from the menu below:");
                string[] mainMenu = { "1. View Client Information", "2. View Account Information", "3. Deposit Funds", "4. Withdraw Funds", "5. Exit" };
                Console.WriteLine(mainMenu[0]);
                Console.WriteLine(mainMenu[1]);
                Console.WriteLine(mainMenu[2]);
                Console.WriteLine(mainMenu[3]);
                Console.WriteLine(mainMenu[4]);

                int mainMenuOptionSelected = int.Parse(Console.ReadLine());

                if (mainMenuOptionSelected == 1) // option 1 = View Client Information
                {
                    client1.View(); // calls View from Client class
                }
                else if (mainMenuOptionSelected == 2) // option 2 = View Account Information
                {
                    Console.WriteLine("Choose an option from the menu below:");
                    string[] accountBalanceMenu = { "a. Checking Account Balance", "b. Savings Account Balance" };
                    Console.WriteLine(accountBalanceMenu[0]);
                    Console.WriteLine(accountBalanceMenu[1]);

                    char accountInformationMenuOptionSelected = char.Parse(Console.ReadLine().ToLower());

                    if (accountInformationMenuOptionSelected == 'a') // Checking Account Balance
                    {
                        checkingAccount1.View(); // calls View from CheckingAccount class
                    }
                    else if (accountInformationMenuOptionSelected == 'b')
                    {
                        savingsAccount1.View(); // calls View from SavingsAccount class
                    }
                }
                else if (mainMenuOptionSelected == 3) // Deposit Funds
                {
                    Console.WriteLine("Choose an option from the menu below:");
                    string[] depositFundsMenu = { "a. To Checking Account", "b. To Savings Account" };
                    Console.WriteLine(depositFundsMenu[0]);
                    Console.WriteLine(depositFundsMenu[1]);

                    char depositFundsMenuOptionSelected = char.Parse(Console.ReadLine().ToLower());

                    if (depositFundsMenuOptionSelected == 'a') // To Checking Account
                    {
                        checkingAccount1.Deposit(); // calls Deposit from CheckingAccount class
                    }
                    else if (depositFundsMenuOptionSelected == 'b') // To Savings Account
                    {
                        savingsAccount1.Deposit(); // calls Deposit from SavingsAccount class
                    }
                }
                else if (mainMenuOptionSelected == 4) // Withdraw Funds
                {
                    Console.WriteLine("Choose an option from the menu below:");
                    string[] withdrawFundsMenu = { "a. From Checking Account", "b. From Savings Account" };
                    Console.WriteLine(withdrawFundsMenu[0]);
                    Console.WriteLine(withdrawFundsMenu[1]);

                    char withdrawFundsMenuOptionSelected = char.Parse(Console.ReadLine().ToLower());

                    if (withdrawFundsMenuOptionSelected == 'a') // To Checking Account
                    {
                        checkingAccount1.Withdraw(); // calls Deposit from CheckingAccount class
                    }
                    else if (withdrawFundsMenuOptionSelected == 'b') // To Savings Account
                    {
                        savingsAccount1.Withdraw(); // calls Deposit from SavingsAccount class
                    }
                }
                else if (mainMenuOptionSelected == 5) // Exit
                {
                    Console.WriteLine("Thank you. Please come again.");
                    return;
                }

                Console.WriteLine("Return to main menu or exit?");
                string[] returnMenu = { "1. Main Menu", "2. Exit" };
                Console.WriteLine(returnMenu[0]);
                Console.WriteLine(returnMenu[1]);
                returnMenuOptionSelected = int.Parse(Console.ReadLine());
                if (returnMenuOptionSelected == 2)
                {
                    Console.WriteLine("Thank you. Please come again.");
                }
            }
            while (returnMenuOptionSelected == 1); // returns to main menu

        }
    }
}
