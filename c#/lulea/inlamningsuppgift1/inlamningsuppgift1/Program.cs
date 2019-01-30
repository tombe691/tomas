using System;
namespace inlamningsuppgift1
{
    internal class Program
    {
        private static void PrintAmount(string valueString, int amount)
        {
            if (amount != 0)
            {
                Console.WriteLine(valueString + amount);
            }
        }
        
        public static void Main(string[] args)
        {
            int costInt, paidInt;    
            Console.Write("Ange pris:");
            bool validInput = int.TryParse(Console.ReadLine(), out costInt);
            if (!validInput)
            {
                Console.WriteLine("Felaktig inmatning");
            }
            Console.Write("Betalt:");
            validInput = int.TryParse(Console.ReadLine(), out paidInt);
            if (!validInput)
            {
                Console.WriteLine("Felaktig inmatning");
            }
            Console.WriteLine("Växel tillbaka:");


            int inReturn = paidInt - costInt;
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
            PrintAmount("Antal femhundralappar: ", fiveHundred);
            PrintAmount("Antal hundralappar: ", hundred);
            PrintAmount("Antal femtiolappar: ", fifty);
            PrintAmount("Antal tjugolappar: ", twenty);
            PrintAmount("Antal tior: ", ten);
            PrintAmount("Antal femmor: ", five);
            PrintAmount("Antal kronor: ", one);
        }
    }
}

