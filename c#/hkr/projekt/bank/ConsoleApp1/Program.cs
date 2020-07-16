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
                Console.WriteLine("\t[7] Ta bort konto");
                Console.WriteLine("\t[8] Sätt in pengar på konto");
                Console.WriteLine("\t[9] Ta ut pengar från konto");
                Console.WriteLine("\t[10]Avsluta programmet\n");

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
                        List<string> removeList;// = new List<string>();
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToRemove;
                        long.TryParse(Console.ReadLine(), out pNrToRemove);
                        removeList = bankLog.RemoveCustomer(pNrToRemove);
                        foreach (string account in removeList)
                        {
                            Console.WriteLine("tar bort "+account); // skriver ut borttagna konton.
                        }
                        break;

                    case 5:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToPrint;
                        long.TryParse(Console.ReadLine(), out pNrToPrint);
                        List<string> testList2 = new List<string>();
                        testList2 = bankLog.GetCustomer(pNrToPrint);
                        int i = 0;
                        //int accountNr = 0;
                        foreach (string customerInfo in testList2)
                        {
                            if (i == 0)
                            {
                                Console.Write("namn ");
                                Console.Write(customerInfo + " "); // Här visas rad för rad.
                            }
                            else if (i == 1)
                            {
                                Console.Write("personnummer ");
                                Console.Write(customerInfo + " "); // Här visas rad för rad.
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine("konton: ");
                                //Console.Write(customerInfo + " "); // Här visas rad för rad.
                            }


//                            Console.Write(customerInfo+" "); // Här visas rad för rad.


                            if (i > 1)
                            {
                                int accountNrToShow;
                                Int32.TryParse(customerInfo, out accountNrToShow);
                                //Console.WriteLine("in case 5 i=" + i + "accountNrToShow = " + accountNrToShow);
                                string test = bankLog.GetAccount(pNrToPrint, accountNrToShow);
                                Console.WriteLine(test);
                            }
                            i++;
                        }
                        break;

                    case 6:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToAddAccountTo;
                        long.TryParse(Console.ReadLine(), out pNrToAddAccountTo);
                        int accountNr = bankLog.AddSavingsAccount(pNrToAddAccountTo);
                        break;

                    case 7:
                        List<string> removeAccountList;// = new List<string>();
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToRemoveAccountFrom;
                        long.TryParse(Console.ReadLine(), out pNrToRemoveAccountFrom);
                        //List<string> testList3 = new List<string>();
                        testList2 = bankLog.GetCustomer(pNrToRemoveAccountFrom);
                        foreach (string customerInfo in testList2)
                        {
                            Console.WriteLine(customerInfo); // Här visas kundinfo
                        }
                        Console.WriteLine("\tVilket konto ska tas bort?");
                        int accountNrToRemove;
                        Int32.TryParse(Console.ReadLine(), out accountNrToRemove);

                        removeAccountList = bankLog.RemoveAccountFromCustomer(pNrToRemoveAccountFrom, accountNrToRemove);
                        foreach (string account in removeAccountList)
                        {
                            Console.WriteLine("tar bort " + account); // skriver ut borttagna konton.
                        }

                        break;

                    case 8:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToDepositAccountFrom;
                        long.TryParse(Console.ReadLine(), out pNrToDepositAccountFrom);
                        //List<string> testList4 = new List<string>();
                        testList2 = bankLog.GetCustomer(pNrToDepositAccountFrom);
                        foreach (string customerInfo in testList2)
                        {
                            Console.WriteLine(customerInfo); // Här visas kundinfo
                        }
                        Console.WriteLine("\tVilket konto ska pengarna sättas in på?");
                        int accountNrToDeposit;
                        Int32.TryParse(Console.ReadLine(), out accountNrToDeposit);

                        Console.WriteLine("\tHur mycket pengar ska sättas in?");
                        decimal amountToDeposit;
                        decimal.TryParse(Console.ReadLine(), out amountToDeposit);

                        bool result = bankLog.Deposit(pNrToDepositAccountFrom, accountNrToDeposit, amountToDeposit);
                        if (result)
                        {
                            Console.WriteLine("det gick bra");
                        }
                        else
                        {
                            Console.WriteLine("det gick inte bra");
                        }
                        break;

                    case 9:
                        Console.WriteLine("\tKundens personnummer?");
                        long pNrToWithdrawAccountFrom;
                        long.TryParse(Console.ReadLine(), out pNrToWithdrawAccountFrom);
                        //List<string> testList4 = new List<string>();
                        testList2 = bankLog.GetCustomer(pNrToWithdrawAccountFrom);
                        foreach (string customerInfo in testList2)
                        {
                            Console.WriteLine(customerInfo); // Här visas kundinfo
                        }
                        Console.WriteLine("\tVilket konto ska pengarna tas ut från?");
                        int accountNrToWithdraw;
                        Int32.TryParse(Console.ReadLine(), out accountNrToWithdraw);

                        Console.WriteLine("\tHur mycket pengar ska tas ut?");
                        decimal amountToWithdraw;
                        decimal.TryParse(Console.ReadLine(), out amountToWithdraw);

                        bool result2 = bankLog.Withdraw(pNrToWithdrawAccountFrom, accountNrToWithdraw, amountToWithdraw);
                        if (result2)
                        {
                            Console.WriteLine("det gick bra");
                        }
                        else
                        {
                            Console.WriteLine("det gick inte bra, kanske inte finns så mycket");
                        }
                        break;

                    case 10:
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
