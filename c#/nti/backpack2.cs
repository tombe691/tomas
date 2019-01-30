using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryggsäcken
{
    class Program
    {
        static void Main(string[] args)
        {
            string föremål = ""; // försöker deklarera en variabel som ska regristrera föremålen
            bool isRunning = true;
            while (isRunning)
            {
                // Vi börjar med att skriva ut menyn!
                Console.WriteLine("\n\tVälkommen till vår ryggsäck!"); // Hehe började tänka på Bag of Holding xD 
                Console.WriteLine("\t[1] Lägg till ett föremål");
                Console.WriteLine("\t[2] Skriv ut innehållet");
                Console.WriteLine("\t[3] Rensa innehållet");
                Console.WriteLine("\t[4] Avsluta");
                Console.Write("\tVälj: ");

                // initierar Meny variabeln
                int menyVal = Convert.ToInt32(Console.ReadLine());
                // försöker deklarera en variabel som sparar föremålen


                // använda oss av if eller switch i menyvalet

                switch (menyVal)
                {
                    case 1: //lägg till ett föremål i ryggan
                        Console.Clear(); // Tömmer konsolfönstret på tidigare text
                        Console.WriteLine("\n\tLägg till ett föremål i ryggsäcken: ");
                        föremål += Console.ReadLine() +" "; // variabeln sparar alla värden i ryggan. 
                        Console.WriteLine(föremål + " Finns i ryggsäcken");
                        Console.ReadKey();
                        break;
                    case 2: //Skriv ut innehållet             
                        {
                            Console.Clear(); // Tömmer konsolfönstret på tidigare text
                            Console.WriteLine("\tI ryggsäcken finns: \n\t" + föremål); //skriver en metod som skriver ut alla föremålen som har skrivits in
                            Console.ReadLine();
                        }

                        break;
                    case 3: // Rensa innehållet
                        {
                            Console.Clear(); // Tömmer konsolfönstret på tidigare text
                            Console.WriteLine("\n\tRyggsäcken är tömd");
                            // Tömmer Ryggsäcken på innehåll genom att göra "omvandla" alla föremålen som har skrivits in och skriver in "ingenting" istället. hade "Tömd på innehåll" förut, 
                            // men "ingenting" passar bättre om man sen kollar med menyval 2 
                            föremål = "";
                            Console.ReadLine();
                        }
                        break;

                    case 4: //avsluta programmet
                        isRunning = false;
                        break;

                    default: // Om användaren skriver in ett nummer som inte är 1 - 4 
                        Console.WriteLine("\n\tDu har skrivit in ett ogilitigt nummer, försök igen");
                        Console.ReadLine();
                        break;
                }

                /* if (menyVal == 1)
                 {
                     Console.Write("Skriv vad som läggs till i ryggsäcken: ");
                     // string = Console.ReadLine();
                     Console.ReadLine();

                 }

                 else if (menyVal == 2)
                 {

                 }

                 else if (menyVal == 3)
                 {

                 }

                 else if (menyVal == 4)
                 {
                     break; // Avslutar Programmet
                 }

                 else
                 {
                     Console.WriteLine("\n\tOgiltligt val!");
                     Console.ReadLine();
                 }
                 */
            }
           
                Console.ReadLine();
        }
    }
}
