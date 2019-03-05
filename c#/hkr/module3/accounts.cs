using System;

namespace ConsoleApp3
{
    public class Accounts
    {
        public static void DisplayWelcomeMessage(Account myAccount)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            myAccount.Name = name;
            myAccount.ShowMessage("Hello " + myAccount.Name + ". Welcome to the Account Book!");
            //call myAccount's ShowMessage method with a parameter
            string dateNOW = Convert.ToString(DateTime.Today);
            myAccount.ShowMessage("Your balance is " + dateNOW + " is " + myAccount.Balance);        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Enter 1 to deposit money");            Console.WriteLine("Enter 2 to withdraw money");            Console.WriteLine("Enter 3 to leave");        }
        public static void DepositMoney(Account myAccount)
        {
            bool validAmount = false;
            double newBalance = 0;
            Console.WriteLine("Case 1, deposit money");
            //prompt the account user to enter the amount
            Console.Write("Enter the deposit amount: ");
            //call myAccount's Deposit method with the read amount as parameter
            //newBalance = myAccount.Deposit(double.Parse(Console.ReadLine()));
            validAmount = double.TryParse(Console.ReadLine(), out newBalance);
            while (!validAmount)
            {
                Console.WriteLine("Not a valid amount, please try again, only numbers");
                validAmount = double.TryParse(Console.ReadLine(), out newBalance);
            }
            myAccount.Balance = myAccount.Balance + newBalance;
            //call myAccount's ShowMessage method with another parameter
            myAccount.ShowMessage("Your balance becomes " + myAccount.Balance);
        }
        public static void WithdrawMoney(Account myAccount)
        {
            bool validAmount = false;
            double newBalance = 0;
            Console.WriteLine("Case 2, withdraw money");
            //prompt the account user to enter the amount
            Console.Write("Enter the withdraw amount: ");
            //call myAccount's Withdraw method with the read amount as parameter
            //                        newBalance = myAccount.Withdraw(double.Parse(Console.ReadLine()));
            validAmount = double.TryParse(Console.ReadLine(), out newBalance);
            while (!validAmount)
            {
                Console.WriteLine("Not a valid amount, please try again, only numbers");
                validAmount = double.TryParse(Console.ReadLine(), out newBalance);
            }
            if (myAccount.Balance < newBalance)
            {
                myAccount.ShowMessage("Your balance is " + myAccount.Balance + " Withdraw rejected");
            }
            else
            {
                myAccount.Balance = myAccount.Balance - newBalance;
                //call myAccount's ShowMessage method with another parameter
                myAccount.ShowMessage("Your balance becomes " + myAccount.Balance);
            }
        }

        //Main method is application's entry point
        public static void Main(string[] args)
        {
            //create an Account object, initialize it and assign it to myAccount
            Account myAccount = new Account("", 0);
            //call myAccount's ShowMessage method with a parameter
            DisplayWelcomeMessage(myAccount);
            int menuChoice = 0;
            bool validMenuChoice = false;
            bool isRunning = true;
            //bool validAmount = false;
            //double newBalance = 0;
            while (isRunning)
            {
                DisplayMenu();
                validMenuChoice = int.TryParse(Console.ReadLine(), out menuChoice);
                while (!validMenuChoice)
                {
                    Console.WriteLine("Not a valid choice, please try again, only numbers");
                    validMenuChoice = int.TryParse(Console.ReadLine(), out menuChoice);
                    if (!validMenuChoice)
                    {
                        Console.WriteLine("Not a valid choice, please try again, only numbers");
                    }
                }
                switch (menuChoice)
                {
                    case 1:
                        DepositMoney(myAccount);
                        break;
                    case 2:
                        WithdrawMoney(myAccount);
                        break;
                    case 3:
                        Console.WriteLine("Case 3, leave");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
           // Console.ReadKey();
        }//end method Main
    }//end class Accounts
}//end namespace 