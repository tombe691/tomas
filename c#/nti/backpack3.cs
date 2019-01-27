using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2_Ryggsäcken
{
    class Program
    {
        static void Main(string[] args)
        {
            string readText = ""; //skapar en tom readText som senare kan definieras, ska hållas utanför while-loopen
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\tVälkommen till Ryggsäcken");
                Console.WriteLine("\t[1] Lägg till ett föremål");
                Console.WriteLine("\t[2] Ditt föremål är: ");
                Console.WriteLine("\t[3] Rensa innehållet");
                Console.WriteLine("\t[4] Avsluta");
                Console.Write("\tGör menyval: ");

                int menyVal = Convert.ToInt32(Console.ReadLine());
                

                if (menyVal == 1)
                {
                    Console.Write("\tLägg till ett föremål: ");
                    readText = Console.ReadLine();

                }

                else if (menyVal == 2)
                {
                   Console.WriteLine("\t" + readText); //hämtar upp den readText som definierats under ovanstående if-sats

                }

                else if (menyVal == 3)
                {
                    readText = string.Empty; //rensar tidigare readText

                }
                else if (menyVal == 4)

                {
                    isRunning = false; //avslutar loopen
                }

                else

                    Console.WriteLine("Ogiltigt menyval"); //används om användaren gör ett ogiltigt val ex. siffran 5

                Console.ReadLine(); //håller consolfönstret öppet för att fortsätta jobba i
            }

           
        }
    }
}
