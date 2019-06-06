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
        public BankLogic()
        {

        }
    
        public List<string> GetCustomers()
        {
            return null;
        }

        public void AddCustomer(string name, long pNr)
        {
            //public static List<SavingsAccount> AccountList = new List<SavingsAccount>();
        //public static List<string> testList = new List<string>();
        Customer customer = new Customer("nisse", 123, null);
        //return false;
    }

    public List<string> GetCustomer()
        {
            
            return null;
        }
        public bool ChangeCustomerName(string name, long pNr)
        {
            return false;
        }

        public List<string> RemoveCustomer(long pNr)
        {
            return null;
        }

        public int AddSavingsAccount(long pNr)
        {
            int number = 123;
            SavingsAccount saveAcc = new SavingsAccount(5.5, 10.5, 1, number);
            AccountList.Add(saveAcc);
            
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
