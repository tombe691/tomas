using System;
 class Times
    {
        static void Main(string[] args)
        {
            double tal, result;
            Console.WriteLine("Skrive ett tal:");
            tal = Convert.ToDouble(Console.ReadLine());
            result = 123.321 * tal;
            Console.WriteLine("\nProdukten av 123,321 och {0} är {1}", tal, result);
            Console.ReadLine();
        }
    }
