//-----------------------------------------------------------------------
// File:    Account.cs
// Summary: class for Task 2, write a simple bank application that 
//          allow deposit and withdraw
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-03-04: Created the file
//		2019-03-05: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------
using System;

namespace Task2
{
    public class Account
    {
        //declare an instance variable that holds the balance
        private double balance = 0;
        //declare an instance variable that holds the name
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
        //property to get or set the name

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
        }// end method Deposit
        //method Withdraw
        public double Withdraw(double withdrawAmount)
        {
            return withdrawAmount;
        }// end method Withdraw
    }//end of class
}
