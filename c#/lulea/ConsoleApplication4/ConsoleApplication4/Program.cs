using System;
using System.Collections.Generic;

namespace LOGBOOK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Jag skapar en lista "logBook" som kan lagra strängvektorer
            // så att jag kan lagra vektorerna med titlar och texter i listan logBook
            List<string[]> logBook = new List<string[]> { };
            //Skriv ut hälsningsfras: "Hej och välkommen till loggboken!"
            Console.WriteLine("Hej och välkommen till loggboken!");
            //Nu skapar jag min Meny
            //Jag deklarerar en bool-variabel som kan ha värdet true eller false
            //tilldelar värdet true för att skapa en menyloop
            // som gör att menyn loopas så länge programmet körs
            bool isRunning = true;
            while (isRunning)
            {
                //Uppmana användaren att välja något från menyn
                //Skriv ut menyn
                Console.WriteLine("Välj något ur menyn: ");
                Console.WriteLine("[1] Skriv ett nytt inlägg i loggboken");
                Console.WriteLine("[2] Skriv ut alla inlägg i loggboken");
                Console.WriteLine("[3] Sök inlägg i loggboken");
                Console.WriteLine("[4] Avsluta");

                // Läs in användarens menyval och lagra i variabeln menuChoice
                //Jag lägger in en try parse för att undvika krasch vid fel inmatning
                int menuChoice;
                int.TryParse(Console.ReadLine(), out menuChoice);

                //Kontrollera menyval med hjälp av switch-sats
                switch (menuChoice)
                {
                    //Menyval 1: Skriv nytt inlägg i loggboken
                    case 1:
                        //Jag skapar ett strängobjekt av typen vektor med två platser
                        //som kan lagra två strängelement (titel och text)
                        // jag väljer en strängvektor för att kunna lagra text på två olika ställen i minnet
                        string[] log = new string[2];
                        //Uppmana användaren att skriva in en titel
                        Console.WriteLine("Skriv in titel");
                        //Läs in användarens inmatade titel och lagra i strängvektorn på indexplats 0
                        log[0] = Console.ReadLine();
                        //Uppmana användaren att ange text
                        Console.WriteLine("Skriv in din text: ");
                        //Läs in användarens inmatade text och lagra i strängvektorn på indexplats 1
                        log[1] = Console.ReadLine();
                        //Lägg till/Lagra inlägget i listan logBook
                        logBook.Add(log);
                        //Slut menyval 1
                        break;

                    //Menyval 2 Skriv ut alla inlägg i loggboken
                    case 2:
                        //Loopa igenom alla strängvektorer i loggboken med en foreach-loop
                        //programmet går igenom varje strängvektorelement som finns lagrat i listan logBook
                        //och skriver ut "Din loggbok innehåller: "+ de lagrade titlarna och texterna
                        Console.WriteLine("Din loggbok innehåller: ");
                        foreach (string[] item in logBook)
                        {
                            Console.WriteLine("Titel: " + item[0] + "\nText: " + item[1]);
                        }
                        //Slut menyval 2
                        break;

                    //Menyval 3 Sök inlägg i loggboken
                    case 3:
                        //Uppmanar användaren att skriva in ett sökord (titel)
                        Console.Write("Skriv in ett sökord (titel): ");
                        //Läser in användarens sökord och lagrar i variablen strängvariabeln searchWord
                        string searchWord = Console.ReadLine();
                        bool search = false;
                        //Skapa en sökning
                        //loopa igenom varje strängobjekt (savedLog) i listan logBook
                        foreach (string[] savedLog in logBook)
                            //Om någon av strängarna på plats 0 i strängvektorerna (titel) 
                            //innehåller användarens sökord (searchWord)
                            //skriv ut att sökningen gav träff och returnera titeln
                            if (savedLog[0].ToUpper().Contains(searchWord.ToUpper()))
                            {
                            Console.WriteLine("Din sökning gav träff: " + savedLog[0]);
                                search = true;
                            }
                        //Om någon användarens sökning inte matchar
                        //Skriv ut "tyvärr, vi kunde inte hitta det du sökte
                        if(!search)
                        {
                            Console.WriteLine("Tyvärr, vi kunde inte hitta det du sökte");
                        }
                        //Slut menyval 3
                        break;

                    //Menyval 4
                    case 4:
                        //Skriv ut ett hejdå-meddelande
                        Console.WriteLine("Hej då!");
                        //villkoret att programmet körs blir falskt
                        //Programmet avslutas
                        isRunning = false;
                        //Slut menyval 4
                        break;

                    //Övriga fall
                    default:
                        //Meddela användaren att något gick fel, om den ej trycker 1,2,3 eller 4
                        Console.WriteLine("Något gick fel. Välj i menyn genom att trycka 1,2,3 eller 4!");
                        //Slut övriga fall
                        break;
                }
            }




        }
    }
}



