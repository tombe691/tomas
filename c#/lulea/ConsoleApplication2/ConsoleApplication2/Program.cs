using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CompactString cs = new CompactString("nisse");
            Console.WriteLine("hello world "+cs.saveString);
            
            CompactString csCopy = new CompactString(cs);
            Console.WriteLine("hello world cs copy "+cs.saveString);
            
            CompactString csEmpty = new CompactString();
            Console.WriteLine("hello world "+csEmpty.saveString);
            
            Console.WriteLine(cs);
            
        }
    }
    public class CompactString
    {
        public string saveString;

        public CompactString(string a = "")
        {
            saveString = a.Replace(" ", string.Empty);
        }

        public CompactString(CompactString orig)
        {
            this.saveString = orig.saveString;
        }
        public override string ToString()
        {
            return "cs saveString: " + this.saveString;
        }
    }
}



//1. Skriv kod för att skapa ett objekt av klassen. Skicka ett strängvärde till konstruktorn och skriv ut värdet sparat i "saveString" med en WriteLine.

//2. Skriv kod för att skapa en kopia av det tidigare objektet du har gjort, användandes kopieringskonstruktorn.

//3. Kan vi skapa ett CompactString-objekt utan att skicka varken en sträng eller en CompactString?

//4. Testa att lägga till en ToString-override till CompactString, så att dess saveString skrivs ut när man försöker skriva ut objektet.