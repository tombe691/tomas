using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SavingsAccount
    {
        public decimal saldo { get; set; }
        public decimal ranta { get; set; }
        public int type { get; set; }
        public int kontonummer { get; set; }

        

        public SavingsAccount(decimal saldo1, decimal ranta1, int type1)
        {
            saldo = saldo1;
            ranta = ranta1;
            type = type1;
            //kontonummer = this.accountNr;

            //this.accountNr++;
        }
    }
}
