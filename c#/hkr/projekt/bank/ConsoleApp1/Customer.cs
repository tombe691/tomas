using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        public string customerName { get; set; }
        public long socialSecurityNumber { get; set; }
        public List<string> accounts { get; set; }

        public Customer(string customerName1, long pNr1, List<string> accounts1)
        {
            List<string> testList = new List<string>();
        customerName = customerName1;
            socialSecurityNumber = pNr1;
            testList.Add(customerName);
            testList.Add(pNr1.ToString());
            accounts = testList;
        }
    }
}
