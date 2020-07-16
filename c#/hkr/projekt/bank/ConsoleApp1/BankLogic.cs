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
                    customer1.accounts[1] = name;
                    found = true;
                }
            }
            return found;
        }
        //inte färdig måste få konton först
        public List<string> RemoveCustomer(long pNr)
        {
            List<string> testList;
            List<string> testList2 = new List<string>();
            string result;
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    testList = customer1.accounts;
                    
                    for (int i=2; i < testList.Count; i++)
                    {
                        int accountNr;
                        Int32.TryParse(testList[i],
                    out accountNr);
                        result = CloseAccount(pNr, accountNr);
                        testList2.Add(result);
                    }
                    customers.Remove(customer1);
                    return testList2;
                }
            }
            return null;
        }

        public List<string> RemoveAccountFromCustomer(long pNr, int accountNr)
        {
//            List<string> testList;
            List<string> testList2 = new List<string>();
            string result;
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    for (int i = 2; i < customer1.accounts.Count; i++)
                    {
                        int accountNr2;
                        
                        Int32.TryParse(customer1.accounts[i],
                    out accountNr2);
                        if (accountNr2 == accountNr)
                        {
                            //customer1.accounts.RemoveAt(i);
                            result = CloseAccount(pNr, accountNr);
                            testList2.Add(result);
                            customer1.accounts.RemoveAt(i);
                        }
                    }
                    return testList2;
                }
            }
            return null;
        }

        public int AddSavingsAccount(long pNr)
        {
            int number = -1;
            decimal amount = 0;
            decimal interest = 1.0m;//1%
            int accountType = 1;//typ 1 = sparkonto
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    SavingsAccount saveAcc = new SavingsAccount(amount, interest, accountType);
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
            decimal amount;
            decimal interest;
            string result = "tomt, något blev fel";
            for (int i = 0; i < AccountList.Count; i++)
            {
                if (AccountList[i].kontonummer == accountId)
                {
                    amount = AccountList[i].saldo;
                    interest = AccountList[i].ranta;
                    //AccountList.Remove(AccountList[i]);
                    result = accountId + " saldo " + amount + " ränta " + interest + "% = " + (amount * interest / 100);
                    return result;
                }
            }
            return null;
        }
        public string GetAllAccounts(long pNr, int accountId)
        {
            decimal amount;
            decimal interest;
            string result = "tomt, något blev fel";
            for (int i = 2; i < AccountList.Count; i++)
            {
                //Console.WriteLine("GetAccount "+AccountList[i].kontonummer+" "+accountId);
                if (AccountList[i].kontonummer == accountId)
                {
                    amount = AccountList[i].saldo;
                    interest = AccountList[i].ranta;
                    //AccountList.Remove(AccountList[i]);
                    result = accountId + " saldo " + amount + " ränta " + interest + "% = " + (amount * interest / 100);
                    return result;
                }
                else
                {
                    Console.WriteLine("GetAccount else i= " + i + " " + AccountList[i].kontonummer + " " + accountId);
                }

            }
            return null;
        }

        public bool Deposit(long pNr, int accountId, decimal amount)
        {
            List<string> testList2 = new List<string>();
            bool result = false;
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    for (int i = 2; i < customer1.accounts.Count; i++)
                    {
                        int accountNr2;

                        Int32.TryParse(customer1.accounts[i],
                    out accountNr2);
                        if (accountNr2 == accountId)
                        {
                            for (int j = 0; j < AccountList.Count; j++)
                            {
                                if (AccountList[j].kontonummer == accountId)
                                {
                                    decimal oldAmount = AccountList[j].saldo;

                                    AccountList[j].saldo = amount + oldAmount;
                                    result = true;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Withdraw(long pNr, int accountId, decimal amount)
        {
            List<string> testList2 = new List<string>();
            bool result = false;
            foreach (Customer customer1 in customers)
            {
                if (customer1.socialSecurityNumber == pNr)
                {
                    for (int i = 2; i < customer1.accounts.Count; i++)
                    {
                        int accountNr2;

                        Int32.TryParse(customer1.accounts[i],
                    out accountNr2);
                        if (accountNr2 == accountId)
                        {
                            for (int j = 0; j < AccountList.Count; j++)
                            {
                                if (AccountList[j].kontonummer == accountId)
                                {
                                    decimal oldAmount = AccountList[j].saldo;

                                    if (amount <= oldAmount)
                                    {
                                        AccountList[j].saldo = oldAmount - amount;
                                        result = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public string CloseAccount(long pNr, int accountId)
        {
            decimal amount;
            decimal interest;
            string result = "tomt, något blev fel";
            for (int i = 0; i < AccountList.Count; i++)
            {
                if (AccountList[i].kontonummer == accountId)
                {
                    amount = AccountList[i].saldo;
                    interest = AccountList[i].ranta;
                    AccountList.Remove(AccountList[i]);
                    result = accountId + " saldo " + amount + " ränta " + interest + "% = "+(amount*interest/100);
                }
            }
            return result;
        }
    }
}
