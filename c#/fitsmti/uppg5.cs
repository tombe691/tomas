using System;
class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cput;
            int[] input = new int[10];
            int i = 0;
            Console.WriteLine("Nedan skriv 10 tecken \n");
            do
            {
                cput = Console.ReadKey();
                Console.WriteLine();
                try
                {
                    input[i] = int.Parse(cput.KeyChar.ToString());
                    i++;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: Du borde skriva bara tal.",e);
                }
         
            } while (i < 10);

            Console.WriteLine("\nDu har skivit - i baklädas;\n");
            for (int j = 9; j >= 0; j--)
            {
                Console.WriteLine(input[j]);
            }

            Console.ReadKey();

        }
    }

