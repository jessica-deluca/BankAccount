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
            // All menu options listed above must have functionality behind them
            // Program should run until user selects 'Exit'
            // After each transaction, the current balance should be displayed on the screen.
            // Be sure the user can continue making selections from the menu until all desired transactions have been completed.

            // Must instantiate one client object; call Client class: 
            Client client1 = new Client();

            // Must instantiate one checking account object; call CheckingAccount class:
            // CheckingAccount checkingAccount1 = new checkingAccount();

            // Must instantiate one savings account object; call SavingAccount class:
            // SavingAccount savingAccount1 = new savingsAccount();

            Console.WriteLine("Choose an option from the menu below:");
            string[] mainMenu = { "1. View Client Information", "2. View Account Information", "3. Deposit Funds", "4. Withdraw Funds", "5. Exit" };
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
            else if (mainMenuOptionSelected == 2) // View Account Information
            {
                Console.WriteLine("Choose an option from the menu below:");
                string[] accountBalanceMenu = { "a. Checking Account Balance", "b. Savings Account Balance" };
                Console.WriteLine(accountBalanceMenu[0]);
                Console.WriteLine(mainMenu[1]);
                //if client enters a, they will call the View() method from CheckingAccount Class
                    //which will autodisplay balance
                //if client enters b, they will call the View() method from SavingsAccount Class
                    //which will autodisplay balance
            }
            else if (mainMenuOptionSelected == 3) // Deposit Funds
            {
                Console.WriteLine("Choose an option from the menu below:");
                string[] depositFundsMenu = { "a. To Checking Account", "b. To Savings Account" };
                Console.WriteLine(depositFundsMenu[0]);
                Console.WriteLine(depositFundsMenu[1]);
                //if client enters a, they will call the Deposit() method from CheckingAccount Class
                    //which will ask how much they want to deposit, add that amount to balance, autodisplay new balance
                //if client enters b, they will call the Deposit() method from SavingsAccount Class
                    //which will ask how much they want to deposit, add that amount to balance, autodisplay new balance
            }
            else if (mainMenuOptionSelected == 4) // Withdraw Funds
            {
                Console.WriteLine("Choose an option from the menu below:");
                string[] withdrawFundsMenu = { "a. From Checking Account", "b. From Savings Account" };
                Console.WriteLine(withdrawFundsMenu[0]);
                Console.WriteLine(withdrawFundsMenu[1]);
                //if client enters a, they will call the Withdraw() method from CheckingAccount Class
                    //which will ask how much they want to withdraw, add that amount to balance, autodisplay new balance
                //if client enters b, they will call the Withdraw() method from SavingsAccount Class
                    //which will ask how much they want to withdraw, add that amount to balance, autodisplay new balance
            }
            else if (mainMenuOptionSelected == 5) // Exit
            {
                return;
            }


        }
    }
}
