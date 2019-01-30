using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hej Tomas ! det var en ganska svår uppgift vi fick som inledning.Det tog många kvällar. jag märker att den grundkurs (programmering 1) som jag gick på
ÅSÖ gymnasiet i Stockholm var nog lite för lätt. Det var först i slutet som vi nosade lite på objekt origenterad programmering.
Jag har köpt extra studiematreal och sökt mycket på internet för att lära mig om klasser, objekt, konstruktorer, properties mm.
Men jag tycker nog att en del poletter börjar trilla ned nu.
Programmet jag skrivit fungerar i alla fall som på videoklippet och jag hoppas att jag förstått uppgiften rätt. Jag skapade objekten
från underklasserna och inte från huvudklassen som angivits.
Jag har varit väldigt noga med att skriva mycket kommentarer så att du ser om jag missförstått någonting och kan rätta mig i så fall.

                                                           Hälsningar / Mikael

    */
namespace Uppgift_NTI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bok> Boklista = new List<Bok>();//                 Listan "Boklista" som ska lagra objekt av klassen "Bok"
            Console.WriteLine("\n*** VÄLKOMMEN TILL BIBLIOTEKET ***\n");//      eller av någon av underklassernas objekt

            string svar = null; string svarboktyp = null; string boktyp = null;// Variabler som behövs i metoden "Main"
            string svartitel = null; string svarskribent = null;

            while (true)  // En evighetsloop som bara kan lämnas av "break". Rad 78
            {
                Console.WriteLine("\n");
                Console.WriteLine("[1]  Registrera ny bok");
                Console.WriteLine("[2]  Visa böcker");
                Console.WriteLine("[3]  Avsluta");
                svar = Console.ReadLine(); // Variabeln som avgör vilken av if satserna 1,2 eller 3 som ska utföras.

                if (svar == "1")
                {
                    Console.Write("\nSkriv in titel: "); svartitel = Console.ReadLine();
                    Console.Write("Skriv in Författare: "); svarskribent = Console.ReadLine();

                    while (true) // En evighets loop. kan endast lämnas av "break"
                    {
                        Console.WriteLine("Är boken en |1| Roman, |2| Tidskrift eller |3| Novellsamling");
                        svarboktyp = Console.ReadLine();
                        if (svarboktyp == "1") { boktyp = "Roman"; }
                        else if (svarboktyp == "2") { boktyp = "Tidskrift"; }
                        else if (svarboktyp == "3") { boktyp = "Novellsamling"; }

                        if (svarboktyp == "1")
                        {
                            Boklista.Add(new Roman(svartitel, svarskribent, boktyp)); break;// Loopen lämnas
                        }
                        else if (svarboktyp == "2")
                        {
                            Boklista.Add(new Tidskrift(svartitel, svarskribent, boktyp)); break;// Loopen lämnas
                        }
                        else if (svarboktyp == "3")
                        {
                            Boklista.Add(new Novellsamling(svartitel, svarskribent, boktyp)); break; // Loopen lämnas
                        }
                        else { Console.WriteLine("Felaktig inmatning. Försök igen\n"); } // Om inte "1", "2" eller "3" anges så lämnas inte loopen
                                                                                         // och felmeddelande ges
                    }

                    Console.WriteLine(" Boken är sparad");
                }
                else if (svar == "2")
                {
                    Console.WriteLine();
                    foreach (var B in Boklista)   // Boklistans innehåll skrivs ut
                    {
                        Console.WriteLine("\"" + B.Titel + "\"" + " av " + B.Skribent + " " + "(" + B.Boktyp + ")");
                    }
                }
                else if (svar == "3") { break; } // Om "3" inmatas så lämnas loopen

                else if (svar != "1" || svar != "2" || svar != "3")      // Endast 1, 2 och 3 är giltiga svar. Annars kommer ett felmeddelande
                { Console.WriteLine("Felaktig inmatning. Försök igen!\n"); }
            }
            Console.WriteLine("Hej då !");
            Console.ReadKey();
        }

        class Bok
        {
            protected string titel;      // Bok klasssens 3 medlemmar. Default är "private" men om man vill att underklasserna ska kunna 
            protected string skribent;   // se medlemmarna så ska dom vara "protected". I det här programmet kunde dom vara "private" för
            protected string boktyp;     // det är underklassernas konstruktor som kommer att sätta värderna

            public Bok(string titel, string skribent, string boktyp) // Bokklassens konstruktor
            {
                this.titel = titel;
                this.skribent = skribent;  // Konstruktorn ger värden till medlemmarna
                this.boktyp = boktyp;
            }
            public string Titel           // Property metoden "Titel" kan ändra och hämta medlemmarnas värden som konstruktorn givit
            {                             // med hjälp av "get" och "set". Underklasserna ärver property metoderna så dom behöver
                get { return titel; }     // man inte skriva igen.
                set { titel = value; }
            }
            public string Skribent
            {
                get { return skribent; }
                set { skribent = value; }
            }
            public string Boktyp
            {
                get { return boktyp; }
                set { boktyp = value; }
            }
        }

        class Roman : Bok      // Underklassen "Roman" som ärvs av huvudklassen "Bok"
        {
            public Roman(string titel, string skribent, string boktyp) : base(titel, skribent, boktyp) // Konstruktorn ärvs inte av huvudklassen
            {                                                                                         // och den måste man skriva på det här som
                this.Boktyp = boktyp;// konstruktorn sätter värde till medlemmen "boktyp"             // jag tycker lite omständiga sättet
            }
        }

        class Tidskrift : Bok  // Underklassen "Tidskrift"
        {
            public Tidskrift(string titel, string skribent, string boktyp) : base(titel, skribent, boktyp)
            {
                this.Boktyp = boktyp;// konstruktorn sätter värde till medlemmen "boktyp"
            }
        }

        class Novellsamling : Bok // Underklassen "Novellsamling"
        {
            public Novellsamling(string titel, string skribent, string boktyp) : base(titel, skribent, boktyp)
            {
                this.Boktyp = boktyp;// konstruktorn sätter värde till medlemmen "boktyp"
            }
        }
    }
}