// File:    Program.cs
// Summary: This is a simple change calculator.
// Version: 1.0
// Owner:   Tomas Berggren 700905-2114     L0002B
// ----------------------------------------------
// Log: 2019-01-14 Created the file. 

using System;
namespace inlamningsuppgift1
{
    internal class Program
    {
        /*method do modify grammar, valueString give size of bill/coin,
         small is used to differ names ending on or er depending on singular or
         plural and grammar rules for the suffix*/
        private static void PrintAmount(string valueString, int amount, bool small)
        {
            if (amount != 0)
            {
                string suffix = "";
                if (amount == 1)
                {
                    if (small == true)
                    {
                        suffix = "a";
                    }
                }
                else
                {
                    if (small == true)
                    {
                        suffix = "or";
                    }
                    else
                    {
                        suffix = "ar";
                    }
                }

                Console.WriteLine(amount+valueString+suffix);
            }
        }
        /*method to check if input is a valid number and not any other character*/
        private static int CheckInput(string infoText)
        {
            int amount = 0;
            bool validInput = false;
            Console.Write(infoText);
            while (!validInput)
            {
                validInput = int.TryParse(Console.ReadLine(), out amount);
                if (!validInput)
                {
                    Console.WriteLine("Felaktig inmatning, försök igen");
                    Console.Write(infoText);
                }
                else
                {
                    validInput = true;
                }
            }
            return amount;
        }
        /*method to calculate and print amount of each bill/coin*/
        public static void ShowChange(int inReturn)
        {
            int fiveHundred = inReturn / 500;
            inReturn = inReturn %= 500;
            int hundred = inReturn / 100;
            inReturn = inReturn %= 100;
            int fifty = inReturn / 50;
            inReturn = inReturn %= 50;
            int twenty = inReturn / 20;
            inReturn = inReturn %= 20;
            int ten = inReturn / 10;
            inReturn = inReturn %= 10;
            int five = inReturn / 5;
            inReturn = inReturn %= 5;
            int one = inReturn / 1;
            PrintAmount(" femhundralapp", fiveHundred, false);
            PrintAmount(" hundralapp", hundred, false);
            PrintAmount(" femtiolapp", fifty, false);
            PrintAmount(" tjug", twenty, true);
            PrintAmount(" ti", ten, true);
            PrintAmount(" femkron", five, true);
            PrintAmount(" enkron", one, true);
        }
        /*method to read input, check if the paid amount is higher than the cost and calculate the
         change amount*/    
        public static int GetInput()
        {
            int costInt = CheckInput("Ange pris: ");
            int paidInt = CheckInput("Betalt: ");

            while (paidInt < costInt)
            {
                Console.WriteLine("Du har betalat för lite, du behöver mata in ett större belopp");
                paidInt = CheckInput("Betalt: ");
            }
            Console.WriteLine("Växel tillbaka:");
            int inReturn = paidInt - costInt;
            return inReturn;
        }
        /*main method to start the application, GetInput to read input, ShowChange to print result*/
        public static void Main(string[] args)
        {
            int inReturn = GetInput();
            ShowChange(inReturn);
        }
    }
}

