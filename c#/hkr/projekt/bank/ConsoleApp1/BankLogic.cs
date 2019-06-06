using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankLogic
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<SavingsAccount> AccountList = new List<SavingsAccount>();
        public int accountNr = 1001;
        public BankLogic()
        {

        }
    
        public List<string> GetCustomers()
        {
            List<string> testList = new List<string>();
            foreach (Customer customer in customers)
            {
                testList.Add(customer.socialSecurityNumber+" "+customer.customerName);
            }
            return testList;
            //return null;
        }

        public bool AddCustomer(string name, long pNr)
        {
            bool uniqueNr = true;
            
            //public static List<string> testList = new List<string>();
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    uniqueNr = false;
                }
            }
            if (uniqueNr)
            {
                Customer customer = new Customer(name, pNr, null);
                customers.Add(customer);
            }
            return uniqueNr;
    }

    public List<string> GetCustomer(long pNr)
        {
            List<string> testList;

            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    testList = customer1.accounts;
                    return testList;
                }
            }

            return null;
        }
        public bool ChangeCustomerName(string name, long pNr)
        {
            bool found = false;
            //public static List<SavingsAccount> AccountList = new List<SavingsAccount>();
            //public static List<string> testList = new List<string>();
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    customer1.customerName = name;
                    found = true;
                }
            }
            return found;
        }
        //inte färdig måste få konton först
        public List<string> RemoveCustomer(long pNr)
        {
            List<string> testList;// = new List<string>();
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    testList = customer1.accounts;
                    customers.Remove(customer1);
                    for (int i=2; i < testList.Count; i++)
                    {
                        int accountNr;
                        Int32.TryParse(Console.ReadLine(),
                    out accountNr);
                        CloseAccount(pNr, accountNr);
                        //AccountList.Remove();
                    }
                }
            }
            return null;
        }

        public int AddSavingsAccount(long pNr)
        {
            int number = -1;
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    SavingsAccount saveAcc = new SavingsAccount(5.5, 10.5, 1);
                    saveAcc.kontonummer = accountNr;
                    number = saveAcc.kontonummer;
                    customer1.accounts.Add(number.ToString());
                    accountNr++;
                    AccountList.Add(saveAcc);
                }
            }
            
            
            
            return number;
        }

        public string GetAccount(long pNr, int accountId)
        {
            return null;
        }

        public bool Deposit(long pNr, int accountId, decimal amount)
        {
            return false;
        }

        public bool Withdraw(long pNr, int accountId, decimal amount)
        {
            return false;
        }

        public string CloseAccount(long pNr, int accountId)
        {
            return null;
        }

    }
}
