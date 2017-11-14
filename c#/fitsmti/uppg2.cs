using System;
class Rakna
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, produkt, kvot, rest;
            Console.WriteLine("Ge under två heltal\n");
            Console.WriteLine("heltal1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("heltal2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            produkt = num1 * num2;
            kvot = num1 / num2;
            rest = num1 % num2;
            Console.WriteLine("\nSumman av {0} och {1} är {2}\n",num1,num2,sum);
            Console.WriteLine("Produken är {0}\n", produkt);
            Console.WriteLine("Kvoten är {0} och Resten är {1}", kvot, rest);
            Console.ReadLine();
        }
    }
