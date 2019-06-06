using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgiftv3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till mitt program.");
            Console.Write("Ange förnamn: ");

            string namn = Console.ReadLine();

            Console.Write("Ange efternamn: ");

            string efternamn = Console.ReadLine();

            Console.WriteLine("");
            

            Console.WriteLine("Välkommen \n"  + namn + " "  + efternamn  + ", ange gärna din ålder i siffror.");

            Console.Write("Ålder: ");

            string år = Console.ReadLine();

            int årint = Convert.ToInt32(år);

            
            årint = årint * 365;

            Console.WriteLine("");
            Console.WriteLine("Oj, det var gammalt. Du har spenderat minst " + årint + " dagar på denna jord...");
            Console.WriteLine("");
            Console.WriteLine("Och vi hoppas såklart på att det blir många mer! ;)");
            Console.WriteLine("");
            Console.WriteLine("Klicka på valfri knapp för att stänga programmet. Ha en fin dag " + namn + ".");


            
            Console.ReadKey();
        }
    }
}
