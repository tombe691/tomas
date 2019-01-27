using System;

namespace Rextester
{
public class Program
    {
        public static void Main(string[] args)
        {

Console.WriteLine("Skriv ditt för och efternamn"); //Skriver ut till konsolen
string user = Console.ReadLine(); // Läser in och sparar använderens namn i variabeln user med datatypen string
Console.WriteLine("Välkommen " + user); //Skriver ut till konsolen, hälsar användaren välkommen
Console.WriteLine(user + " vad är din ålder?"); //Skriver ut till konsolen, frågar använderen om ålder
int age = Int32.Parse(Console.ReadLine()); // Läser in och konverterar användarens ålder till siffor, sparar i variebeln age med datatypen int
int days = age * 365; //Multiplicerar användarens ålder med 356
Console.WriteLine(user + " du har levt i " + days + " dagar"); //Skriver ut till konsolen hur många dagar användaren har levt

      }
    }
}