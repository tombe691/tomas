using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vi börjar med att hällsa er alla välkommna till programmet! samt sparar svaret på första frågan: 
            Console.WriteLine("Välkommen!");
            Console.WriteLine("Skriv in ert namn samt efternamn tack!");
            string namn = Console.ReadLine();

            //Här behövs en konvertering från string till int så att programmet förstår vad det är för value ni skriver, jag försöker använda mig av namn för variablerna som är förståliga:
            Console.WriteLine(namn + " hur gammal är ni?");
            string år = Console.ReadLine();
            //int fulltår = Convert.ToInt32(år);//Vi kan inte använda convert för att felhantera, därför blev det TryParse istället, se det under.
            int fulltår;
            if (int.TryParse(år, out fulltår))//Jag vill veta om det går att konvertera eller inte.
            {
                //Nu tar vi fram födelseåret ur minnet och * det med antalet dagar på ett år och visar upp det på konsolen. 
                int totaldagar = fulltår * 365;
                Console.WriteLine("Du har drygt levt i " + totaldagar + " dagar.");
                Console.WriteLine("Tryck ENTER för tilläg.");
            }
            else
            {
                Console.WriteLine("Jag förstår inte...");
            }
                Console.ReadLine();

            //Nu kommer programet att strunta i frågan om man skriver fel och fortsätta till nästa, det börjar bli lite förr förvirrande för mig.
            
            //Under är tillägg samt raden: "tryck ENTER för tilläg, och if satsen ovan med TryParse."
            Console.WriteLine(namn + " skriv in ert födelsedatum: yyyy-MM-dd");
            DateTime nu = DateTime.Now;//Vi kollar klockan på datorn, nu variabeln är för att gemföra värdet vi kommer ta emot från användaren.
            string datum = Console.ReadLine();
            //DateTime tiddatum = Convert.ToDateTime(datum);// Samma som ovan, nu när vi vill använda oss av if satser så fungerar det inte att använda convert.

            DateTime tiddatum;
            if (DateTime.TryParse(datum, out tiddatum))//Samma som ovan fast med DateTime istället.
            {
                TimeSpan årsdag = (nu - tiddatum);
                Console.WriteLine("Oj, du är drygt " + årsdag.TotalDays / 365 + " år gammal, grattis!");

                Console.WriteLine(årsdag.TotalHours + " är det totala antalet timmar du varit vid liv.");
                Console.WriteLine(årsdag.TotalDays/30 + " är det dryga totala antalet månader du varit vid liv."); //Delat på 30 då det inte finns någon TotalMonths option...

                //Så att programet inte stängs ner på en gång!
            }
            else
            {
                Console.WriteLine("Jag förstår inte...");
            }
            //Så att programmet inte stängs ner på en gång använder vi en sista ReadLine()!
            Console.ReadLine();


        }
    }
}
