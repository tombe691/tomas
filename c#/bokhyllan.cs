using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bokhyllan1
{
    class Bok //bok class
    {
        protected string Titel { get; }
        protected string Författare = "";
        protected string Boktyp = "";

        public Bok(string Titel, String Författare, string Boktyp) // strings för ge värde till title,författare och boktyp
        {
            this.Titel = Titel;
            this.Författare = Författare;
            this.Boktyp = Boktyp;
        }

        public override String ToString() // to string för att printa ut 
        {
            return "Titel: " + this.Titel + " \tFörfattare: " + this.Författare + " \t\tType: " + this.Boktyp;
        }

    }
    class Tidskrift : Bok //underklass 
    {
        private const string TYP = "Tidsskrift";
        public Tidskrift(String Titel, string Författare) :
            base(Titel, Författare, TYP)
        { }


        //En tidskrift eller ett magasin är en sorts periodisk skrift
    }
    class Novell : Bok
    {
        private const string TYP = "Novell";
        public Novell(string Titel, string författare) :
            base(Titel, författare, TYP)
        { }
        // En novell är en kort prosaberättelse
    }
    class Roman : Bok
    {
        private const string TYP = "Roman";
        public Roman(string Titel, string författare) :
            base(Titel, författare, TYP)
        { }

        //Roman är en populär skönlitterär form som består av en längre berättelse på prosa
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Bok> Bibliotek = new List<Bok>(); // listan som tar emot bok
            bool isRunning = true;
            String Titel;
            String Författare;
            while (isRunning)
            {
                Console.WriteLine("\nVälkommen till Biblioteket!");
                Console.WriteLine("[1] Registrera ny bok ");
                Console.WriteLine("[2] Visa Böcker ");
                Console.WriteLine("[3] Avsluta");

                Console.Write("\nGör ett val i menyn: ");
                int MenuChoice;

                if (Int32.TryParse(Console.ReadLine(), out MenuChoice)) // felhanterings
                {
                    switch (MenuChoice)
                    {
                        case 1:

                            Console.WriteLine("\nSkriv en title  "); // väntar på title
                            Titel = Console.ReadLine();  // läser title
                            Console.WriteLine("Skriv in författare:"); // väntar på text
                            Författare = Console.ReadLine();  // läser text
                            Console.WriteLine("Vilken typ är din bok? ");
                            Console.WriteLine("[1]Roman" + "\t[2]Tidsskrift" + "\t[3]Novell");
                            if (Int32.TryParse(Console.ReadLine(), out MenuChoice)) // felhanterings
                            {
                                switch (MenuChoice) // switch för val samt lägger till i listan
                                {
                                    case 1:
                                        Bok roman = new Roman(Titel, Författare);
                                        Bibliotek.Add(roman);
                                        break;

                                    case 2:
                                        Bok tidskrift = new Tidskrift(Titel, Författare);
                                        Bibliotek.Add(tidskrift);
                                        break;

                                    case 3:
                                        Bok novell = new Novell(Titel, Författare);
                                        Bibliotek.Add(novell);

                                        break;

                                    default:
                                        Console.WriteLine("\nNågot gick fel vid registrering av boken, var vänlig att försöka igen"); // utifall fel input 
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nOps något gick fel, försök igen välj Meny 1-3");
                            }

                            break;

                        case 2:

                            {
                                foreach (Bok bok in Bibliotek) // foreach funktion som går ingenom listan och sedan printar ut den
                                {
                                    Console.WriteLine(bok);

                                }
                                Console.Write("\nTryck valfri tangent för att återgå till meny   "); // en pause för meny
                                Console.ReadKey(); // väntar på användar input
                                Console.Clear(); //rensar cdm
                                break;
                            }

                        case 3:
                            isRunning = false;
                            break;


                        default:
                            Console.WriteLine("\nOps något gick fel, försök igen välj Meny 1-3"); // utifall fel input i meny
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nOps något gick fel, försök igen välj Meny 1-3");
                }
            }
        }
    }
}
