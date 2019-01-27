using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skickar ut ett välkomst meddelande
            Console.WriteLine("Hej och Välkommen!");
            //Frågrar vad hon/han heter
            Console.WriteLine("Vad heter du?");
            //Använder var för att komma ihåg namn
            var namn = Console.ReadLine();


            //"kollar upp" dagens datum och tid
            var idag = DateTime.Today;
            
            
            //Säger hej(namn) 
            Console.WriteLine("Hej" + namn);
         
            
            //Frågar om ålder
            Console.WriteLine("Hur gammal är du? YYYY-MM-DD");
         
            
            //Gör så att den lägger datumet på "minne" ett kort tag
            DateTime född = DateTime.Parse(Console.ReadLine());
         
            
            //räknar ut tiden mellan "idag" och "angivna datumet"
            TimeSpan ålder = idag - född;
         
            
            //Säger hur länge personen har levt mellan idag och "Angivna datumet"
            Console.WriteLine("Du har levt i {0} dagar, eller {1} timmar, eller {2} minuter.", ålder.TotalDays, ålder.TotalHours, ålder.TotalMinutes);
             
           
            Console.ReadKey();
    

            





         
        











        }
    }
}
