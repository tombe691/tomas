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
                Console.WriteLine("\t[1] Lägg till kund"); 
                Console.WriteLine("\t[2] Skriv ut kunder");
                Console.WriteLine("\t[3] Ändra namn på kund");
                Console.WriteLine("\t[4] Ta bort kund");
                Console.WriteLine("\t[5] Skriv ut kund");
                Console.WriteLine("\t[6] Lägg till konto");
                Console.WriteLine("\t[7]Avsluta programmet\n");

                Console.Write("\tVälj: "); // Ber användaren om ett val från menyn.

                Int32.TryParse(Console.ReadLine(),
                    out choice); // Undantagshantering/TryParse om användaren väljer att skriva in något annat än valmöjligheterna(siffror). 

                switch (choice) // Switch satsen.
                {

                    case 1:
                        Console.WriteLine("\tVad heter kunden?");
                        string name = Console.ReadLine();
                        Console.WriteLine("\tKundens personnummer?");
                        long pNr;
                        long.TryParse(Console.ReadLine(), out pNr);
                        bool passed = bankLog.AddCustomer(name, pNr);
                        if (!passed)
                        {
                            Console.WriteLine("personnummer finns redan");
                        }
                        break;

                    case 2:
                        List<string> testList = new List<string>();
                        testList = bankLog.GetCustomers();
                        foreach (string customer in testList)
                        {
                            Console.WriteLine(customer); // Här kan användaren sök efter önskad logg.
                        }
                        break;

                    case 3:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToChange;
                        long.TryParse(Console.ReadLine(), out pNrToChange);
                        Console.WriteLine("\tNytt namn på kunden?");
                        string newName = Console.ReadLine();
                        bool changed = bankLog.ChangeCustomerName(newName, pNrToChange);
                        if (!changed)
                        {
                            Console.WriteLine("gick inte att ändra, hittade inte kunden");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToRemove;
                        long.TryParse(Console.ReadLine(), out pNrToRemove);
                        bankLog.RemoveCustomer(pNrToRemove);
                        break;

                    case 5:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToPrint;
                        long.TryParse(Console.ReadLine(), out pNrToPrint);
                        List<string> testList2 = new List<string>();
                        testList2 = bankLog.GetCustomer(pNrToPrint);
                        foreach (string customerInfo in testList2)
                        {
                            Console.WriteLine(customerInfo); // Här kan användaren sök efter önskad logg.
                        }
                        break;

                    case 6:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToAddAccountTo;
                        long.TryParse(Console.ReadLine(), out pNrToAddAccountTo);
                        int accountNr = bankLog.AddSavingsAccount(pNrToAddAccountTo);
                        break;

                    case 7:
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
