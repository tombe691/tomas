using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2_Programmering_2
{

    class Program
    {
        //============================== Main =======================================
        //case 1: startar metoden nyBok, som gör att användaren kan skapa en Bok klass som blir tilldelad en underklass.
        //case 2: startar metoden visaBok som matar ut en lista med alla böcker som finns i listan Bokhyllan.
        //case 3: startar metoden kastaBok, som raderar en bok som finns på bokhyllan alternativt tömmer hela bokhyllan.
        //case 5: stänger av programmet genom att tilldela boolen onOff false
        //default: ifall inget alternativen väljs, får man ett felmedelande och blir skickad tillbaka till menyn.
        static void Main(string[] args)
        {
            Biblotekarie biblotekarien = new Biblotekarie();
            bool onOff = true;
            while (onOff)
            {
                Console.WriteLine();
                Console.WriteLine("\t" + "Hej och välkommen till biblioteket!");
                Console.WriteLine("\t" + "[1] - Registrera ny bok.");
                Console.WriteLine("\t" + "[2] - Visa böcker.");
                Console.WriteLine("\t" + "[3] - Radera en bok.");
                Console.WriteLine("\t" + "[4] - Sök efter en bok.");
                Console.WriteLine("\t" + "[5] - Avsluta.");
                Console.Write("\t" + "Välj: ");
                int menySwitch; Int32.TryParse(Console.ReadLine(), out menySwitch); Console.WriteLine();
                switch (menySwitch)
                {
                    case 1:
                        biblotekarien.SkapaBok(); break;
                    case 2:
                        biblotekarien.HämtaBok(); break;
                    case 3:
                        biblotekarien.KastaBok(); break;
                    case 4:
                        biblotekarien.SökBok(); break;
                    case 5:
                        onOff = false; break;
                    default:
                        Console.WriteLine("\t" + "Felaktig input."); break;
                }
            }

        }
    }
    

    class Biblotekarie
    {
        private List<Bok> bokList = new List<Bok>();
        //========================== HämtaBok =========================================
        //en metod som matar ut en lista utav bokList.
        public void HämtaBok()
        {
            {
                bool finnsBok = false; int antalBöcker = (bokList.Count);
                if (antalBöcker > 0) finnsBok = true;
                if (finnsBok == true) for (int i = 0; i < antalBöcker; i++) { Console.WriteLine("\t" + bokList[i]); }
                if (finnsBok == false) Console.WriteLine("\t" + "Det finns inga böcker i bokhyllan.");
            }
        }
        //=============================SkapaBok =======================================
        //en metod för att skapa en Bok klass och ge den en utav underklasserna, och sedan lägga den i en klassens bokList.
        //först ber den använderan on titel författare och årtal, sedan väljer använderen av följande alternativ.
        //case 1: skapar en bok med underklassen Roman och lägger in i listan.
        //case 2: skapar en bok med underklassen Tidsskrift och lägger in i listan.
        //case 3: skapar en bok med underklassen Novellsamling och lägger in i listan.
        public void SkapaBok()
        {
            bool bokSkapad = false; string titel = ""; string författare = ""; int årTal = 0;
            while (bokSkapad == false)
            {
                bool titelVald = false; while (titelVald == false)
                {
                    Console.WriteLine("\t" + "Vilken titel har boken?"); Console.Write("\t" + "Välj: ");
                    titel = Console.ReadLine(); Console.WriteLine(); titelVald = true;
                }
                bool författareVald = false; while (författareVald == false)
                {
                    Console.WriteLine("\t" + "Vilken författare har boken?"); Console.Write("\t" + "Välj: ");
                    författare = Console.ReadLine(); Console.WriteLine(); författareVald = true;
                }
                bool årVald = false; while (årVald == false)
                {
                    Console.WriteLine("\t" + "När släpptes boken? (endast årtal)"); Console.Write("\t" + "Välj: ");
                    Int32.TryParse(Console.ReadLine(), out årTal); Console.WriteLine();
                    if (årTal > 0) { årVald = true; }
                    else { Console.WriteLine("\t" + "Fel input, försök igen."); Console.WriteLine(); }
                }
                while (bokSkapad == false)
                {
                    Console.WriteLine("\t" + "Är boken en [1] Roman, [2] Tidsskrift eller [3] Novellsamling?"); Console.WriteLine(); Console.Write("\t" + "Välj: ");
                    int underklassVal; Int32.TryParse(Console.ReadLine(), out underklassVal);
                    switch (underklassVal)
                    {
                        case 1:
                            Bok bok = new Roman(titel, författare, årTal); bokList.Add(bok);
                            Console.WriteLine(); Console.WriteLine("\t"+"Boken har blivit lagd i bokhyllan!");
                            bokSkapad = true; break;
                        case 2:
                            Bok bok2 = new Tidsskrift(titel, författare, årTal); bokList.Add(bok2);
                            Console.WriteLine(); Console.WriteLine("\t" + "Boken har blivit lagd i bokhyllan!");
                            bokSkapad = true; break;
                        case 3:
                            Bok bok3 = new Novellsamling(titel, författare, årTal); bokList.Add(bok3);
                            Console.WriteLine(); Console.WriteLine("\t" + "Boken har blivit lagd i bokhyllan!");
                            bokSkapad = true; break;
                    }
                    if (bokSkapad == false)
                    {
                        Console.WriteLine("\t" + "Fel input, försök igen.");
                    }
                }
            }
        }
        //==============================SökBok() ==================================
        //en metod som använder sig av .FindAll för att hitta ett objekt i bokList.
        public void SökBok()
        {
            if (bokList.Count() > 0)
            {
                Console.WriteLine("\t" + "Hur vill du söka boken?");
                Console.WriteLine("\t" + "[1] - Via Titel");
                Console.WriteLine("\t" + "[2] - Via Författare.");
                Console.WriteLine("\t" + "[3] - Via Årtal.");
                Console.Write("\t" + "Välj: ");
                int switchInt; Int32.TryParse(Console.ReadLine(), out switchInt); Console.WriteLine();
                switch (switchInt)
                {
                    case 1:
                        Console.Write("\t" + "Välj sökord : ");
                        string titleSearch = Console.ReadLine();
                        Console.WriteLine();
                        List<Bok> result1 = bokList.FindAll(x => x.Title == titleSearch);
                        if (result1.Count > 0)
                        {
                            for (int i = 0; i < result1.Count; i++) { Console.WriteLine("\t" + bokList[i]); }
                        }
                        else
                        {
                            Console.WriteLine("\t" + "Hittade inte någon bok med titeln '" + titleSearch + "'.");
                        }
                        break;
                    case 2:
                        Console.Write("\t" + "Välj sökord : ");
                        string authorSearch = Console.ReadLine();
                        Console.WriteLine();
                        List<Bok> result2 = bokList.FindAll(x => x.Author == authorSearch);
                        if (result2.Count > 0)
                        {
                            for (int i = 0; i < result2.Count; i++) { Console.WriteLine("\t" + bokList[i]); }
                        }
                        else
                        {
                            Console.WriteLine("\t" + "Hittade inte någon bok med författaren '" + authorSearch + "'.");
                        }
                        break;
                    case 3:
                        bool årVald = false; int årTal = 0;
                        while (årVald == false)
                        {
                            Console.Write("\t" + "Välj sökår : ");
                            Int32.TryParse(Console.ReadLine(), out årTal); Console.WriteLine();
                            Console.WriteLine();
                            if (årTal > 0) { årVald = true; }
                            else
                            {
                            Console.WriteLine("\t" + "Fel input, försök igen. (endast årtal)"); Console.WriteLine();
                            }
                        }
                        List<Bok> result3 = bokList.FindAll(x => x.Year == årTal);
                        if (result3.Count > 0)
                        {
                            for (int i = 0; i < result3.Count; i++) { Console.WriteLine("\t" + bokList[i]); }
                        }
                        else
                        {
                            Console.WriteLine("\t" + "Hittade inte någon bok med årtalet '" + årTal + "'.");
                        }
                        break;
                    default: 
                        Console.WriteLine("\t" + "Felaktig input"); break;
                }
            }
            else
            {
                Console.WriteLine("Det finns inga böcker i bokhyllan.");
            }
        }
        //============================= kastaBok ====================================
        //en metod som ger användaren tre val, att rensa hela listan, ta bort en specifik Bok, eller avsluta metoden.
        //case 1 tar ut en numrerad lista av Bokhyllan, som låter användaren ta bort enstaka böcker ur inList.
        //case 2 använder .clear för att tömma hela listan.
        //case 3 stänger av metoden genom att tilldela boolen onOff false
        //default : ifall inget alternativen väljs, får man ett felmedelande och blir skickad tillbaka till menyn.
        public void KastaBok()
        {
            bool onOff = true;
            while (onOff)
            {
                Console.WriteLine("\t" + "[1] - Radera en vald bok.");
                Console.WriteLine("\t" + "[2] - Radera alla böcker i hyllan");
                Console.WriteLine("\t" + "[3] - Tillbaka till huvudmenyn");
                Console.Write("\t" + "Välj: ");
                int menySwitch; Int32.TryParse(Console.ReadLine(), out menySwitch); Console.WriteLine();
                switch (menySwitch)
                {
                    case 1:
                        bool finnsBok = false; int antalBöcker = (bokList.Count);
                        if (antalBöcker > 0) finnsBok = true;
                        if (finnsBok == true)
                        {
                            bool bokRaderad = false; while (bokRaderad == false)
                            {
                                for (int i = 0; i < antalBöcker; i++) { Console.WriteLine("\t" + "[" + (i + 1) + "] " + bokList[i]); }
                                Console.Write("\t" + "Välj en bok som ska raderas: ");
                                int bokVal; Int32.TryParse(Console.ReadLine(), out bokVal); if (bokVal > antalBöcker)
                                { Console.WriteLine(); Console.WriteLine("\t" + "Vänligen välj en bok i listan!"); Console.WriteLine(); }
                                else if (bokVal <= 0)
                                { Console.WriteLine(); Console.WriteLine("\t" + "Vänligen välj en bok i listan!"); Console.WriteLine(); }
                                else
                                { bokList.RemoveAt((bokVal - 1)); Console.WriteLine(); Console.WriteLine("\t" + "Boken har blivit raderad!"); onOff = false; bokRaderad = true; }
                            }
                        }
                        if (finnsBok == false)
                        { Console.WriteLine("\t" + "Det finns inga böcker i bokhyllan."); }
                        break;
                    case 2:
                        Console.WriteLine("\t" + "Bokhyllan tömdes!");
                        bokList.Clear(); onOff = false; break;
                    case 3:
                        Console.WriteLine("\t" + "Tillbaka till huvudmenyn!");
                        onOff = false; break;
                    default:
                        Console.WriteLine("\t" + "Felaktig input."); break;
                }
            }
        }
    }
    // Min bok superklass
    public class Bok
    {
        public string Title; public string Author; public int Year; public string Booktype;
        public Bok(string inTitle, string inAuthor, int inYear) { Title = inTitle; Author = inAuthor; Year = inYear; }
        public override string ToString() { return "'" + Title + "'" + " av: " + Author + " releasedatum: " + Year + ". " + Booktype; }
    }
    // Min roman underklass
    public class Roman : Bok
    {
        public Roman(string inTitle, string inAuthor, int inYear) : base(inTitle, inAuthor, inYear) { Booktype = "((Roman))"; }
        public override string ToString()
        {
            return "'" + Title + "'" + " av: " + Author + ", releasedatum: " + Year + ", ligger i Romanhyllan. "+ Booktype;
        }
    }
    // Min Tidsskrift underklass
    public class Tidsskrift : Bok
    {
        public Tidsskrift(string inTitle, string inAuthor, int inYear) : base(inTitle, inAuthor, inYear) { Booktype = "((Tidsskrift))"; }
        public override string ToString()
        {
            return "'" + Title + "'" + " av: " + Author + ", releasedatum: " + Year + ", ligger i Tidsskrifthyllan. " + Booktype;
        }
    }
    // Novellsamling underklassen
    public class Novellsamling : Bok
    {
        public Novellsamling(string inTitle, string inAuthor, int inYear) : base(inTitle, inAuthor, inYear) { Booktype = "((Novellsamling))"; }
        public override string ToString()
        {
            return "'" + Title + "'" + " av: " + Author + ", releasedatum: " + Year + ", ligger i Novellhyllan. " + Booktype;
        }
    }

}
