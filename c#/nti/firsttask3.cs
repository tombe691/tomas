using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Koden ovanför berättar vilka bibliotek man vill använda sig utav och med hjälp av dessa kan jag skriva koden under //


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) // Detta är main-metoden //
        {
            string strNamn1;      // variabel för förnamn //
            string strNamn2;      // variabel för efternamn //
            int alder = 0;        // variabel för ålder //

            Console.Write("Hallå där! Vänligen skriv in ditt förnamn: ");   // en hälsning till användare och fråga om användares förnamn //

            strNamn1 = Console.ReadLine();      // läser in förnamnet //

            Console.Clear();          // tar bort nuvarande mening för att undvika flera meningar efter varandra //

            Console.Write("Vänligen skriv in ditt efternamn: ");   // andra frågan om användares efternamn //

            strNamn2 = Console.ReadLine();         // läser in efternamn //

            Console.Clear();          // tar bort nuvarande mening....//

            Console.WriteLine("Välkommen till mitt program " + strNamn1 + " " + strNamn2 + "! Tryck på ENTER för att gå vidare.");

            Console.ReadKey();        // användaren trycker på ENTER för att gå vidare till frågan under //

            Console.Clear();          // tar bort nuvarande mening....//

            Console.Write("Hur gammal är du" + " " + strNamn1 + "? ");        // skriver ut frågan med förnamn, med hjälp av variabeln "strNamn" //
                               
            alder = Convert.ToInt32(Console.ReadLine());       // konverterar till nr istället för karaktärer samt läser in åldern //

            Console.Clear();            // tar bort nuvarande mening....//

            Console.Write("Antal dagar du har levt: " + alder*365);        // svaret på frågan, den räknar ut ålder gånger 365 dagar, den bortser dock ifrån skottår // 

            Console.ReadKey();         // så att konsolrutan inte stängs efter att man fyllt i ålder //

                    


        }
    }
}
