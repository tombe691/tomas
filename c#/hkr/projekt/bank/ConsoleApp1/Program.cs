using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true; // En bool och whileloop körs.
            BankLogic bankLog = new BankLogic();

            while (isRunning)
            {

                int choice; // initierar variabeln som kommer användas till switchsatsen.

                // Skriver ut en meny till användaren
                Console.WriteLine("\t[1]"); 
                Console.WriteLine("\t[2]");
                Console.WriteLine("\t[3] Lägg till konto");
                Console.WriteLine("\t[4]Avsluta programmet\n");

                Console.Write("\tVälj: "); // Ber användaren om ett val från menyn.

                Int32.TryParse(Console.ReadLine(),
                    out choice); // Undantagshantering/TryParse om användaren väljer att skriva in något annat än valmöjligheterna(siffror). 

                switch (choice) // Switch satsen.
                {

                    case 1:
                        break;

                    case 2:
                        Console.Write("\tSÖK: "); // Här kan användaren sök efter önskad logg.
                        break;

                    case 3:
                        bankLog.AddSavingsAccount(7009052114);
                        break;

                    case 4:
                        isRunning = false; // Här avslutas loopen / programmet.
                        break;

                    default:
                        Console.WriteLine(
                            "\t<<<Vänligen välj ett av altenativen>>>\n"); // Skriver ut en sträng om användarens val är felaktigt.
                        break;
                }
            }
        }
    }
}
