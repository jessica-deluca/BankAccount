using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //For now, the application will have only one client that is hard-coded into the system.
        // Client class should contain:
        // 3 properties
        // 1 constructor
        // 1 method
        // Client information should be filled in here

        protected string clientName;
        protected string clientCheckingAccountNumber;
        protected string clientSavingsAccountNumber;

        public string ClientName { get; }
        public string ClientCheckingAccountNumber { get; }
        public string ClientSavingsAccountNumber { get; }

        public Client()
        {
                //default constructor
        }

        public void View()
        {
            clientName = "Jessica DeLuca";
            clientCheckingAccountNumber = "123456789";
            clientSavingsAccountNumber = "987654321";
            Console.WriteLine("Client Name: " + clientName + "\nChecking Account Number: " + clientCheckingAccountNumber + "\nSavings Account Number: " + clientSavingsAccountNumber);
        }
    }
}
