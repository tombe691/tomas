using System;
 class Times
    {
static void Main(string[] arg)
        {

            ConsoleKeyInfo cki;
            int summ = 0;
            Console.WriteLine("Skriv ett heltal och avsluta det med ett bokstav för att få summan av heltalet.\n");
           
            do 
            {
                cki = Console.ReadKey();
                if (!(char.IsDigit(cki.KeyChar))){
                    break;
                }
                int tal = int.Parse(cki.KeyChar.ToString());
                summ += tal;
            } while (cki.Key != ConsoleKey.Escape);

            Console.WriteLine();
            Console.WriteLine("\nSumman är : {0}",summ);
            Console.ReadLine();
        }

    }
