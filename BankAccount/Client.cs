using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client // all client information should be filled in here
    {
        private string clientName;
        private string clientCheckingAccountNumber;
        private string clientSavingsAccountNumber;

        public string ClientName { get; }
        public string ClientCheckingAccountNumber { get; }
        public string ClientSavingsAccountNumber { get; }

        public Client()
        {
                // default constructor
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
