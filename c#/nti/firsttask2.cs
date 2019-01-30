using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstName;
            string myLastName;

            Console.WriteLine("Hej och välkommen till Programmering 1!");
            Console.Write("Skriv ditt förnamn:");
            myFirstName = Console.ReadLine();
            Console.WriteLine("Roligt att ha dig här " + myFirstName + "!");

            Console.Write("Skriv ditt efternamn:");
            myLastName = Console.ReadLine();
            Console.WriteLine("Välkommen, " + myFirstName + " " + myLastName + "!");
            Console.Write(myFirstName + "," + "Hur gammal är du?:");

            string enterYear = Console.ReadLine();
            int age = Convert.ToInt32(enterYear);
            age = age * 365;
            Console.Write("Vill du veta en roligt sak? Du är " + age + " dagar gammal.");

            Console.ReadLine();
        }
    }
}