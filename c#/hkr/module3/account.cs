using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Account
    {
        //declare an instance variable that holds the balance
        private double balance = 0;
        private string name = "";

        //Add empty constructor
        public Account(string name, double amount)
        {
            Name = name;
            Balance = amount;
        }// end constructor

        //property to get or set the balance value
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //method ShowMessage
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        //method Deposit
        public double Deposit(double depositAmount)
        {
            return depositAmount;
        }// end methos Deposit
        //method Withdraw
        public double Withdraw(double withdrawAmount)
        {
            return withdrawAmount;
        }// end methos Withdraw
    }//end of class
}
