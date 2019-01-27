using System;
using System.Collections.Generic;

namespace P2.BokhyllanRevised
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Bok> allBooks = new List<Bok>(); //lista adderas som innehåller referenserna till klassen Bok
      bool loop = true;
      while (loop)
	{
	  Console.WriteLine("\n\tHej och Välkommen till Biblioteket!");
	  Console.WriteLine("\t[1] Registrera ny bok. ");
	  Console.WriteLine("\t[2] Visa böcker.");
	  Console.WriteLine("\t[3] Radera alla böcker.");
	  Console.WriteLine("\t[4] Avsluta");
	  Int32.TryParse(Console.ReadLine(), out int val); //fånga felskrivningar

	  switch (val)
	    {
	    case 1:
	      allBooks.Add(Addera());
	      break; //fall ur case
	    case 2:
	      Console.WriteLine("Alla böcker är listade nedan: ");
	      foreach (Bok item in allBooks) //loopa igenom objekten i listan
		{
		  Console.WriteLine(item.ToString());
		}

	      break; //fall ur case
	    case 3:
	      allBooks.Clear();
	      Console.WriteLine("Raderat och klart.");
	      break; //fall ur case
	    case 4:
	      loop = false; //avsluta menyval-loop
	      break; //fall ur case
	    }
	} //While loop-vinge
    }

    public static Bok Addera() //DENNA FUNGERAR EJ OCH FÖRSTÅR INTE PROBLEMET
    {
      Console.Write("Skriv Titel:\t");
      string titel = Console.ReadLine();
      Console.Write("Skriv Skribent:\t");
      string skribent = Console.ReadLine();
      Console.Write("Välj Typ: [T] Tidskrift, [R] Roman eller [N] Novell: ");
      string typ = Console.ReadLine();
      Bok minBok; // = new Bok; //eget objekt skapas av klassen Bok. 
      switch (typ)
	{
	case "R":
	case "r":
	  minBok = new Roman(titel, skribent);
	return minBok; //VARFÖR SKRIVER MAN RETURN? Metoden har ju ingen utdata i deklarationen?
	case "n":
	case "N":
	  minBok = new Novell(titel, skribent);
	return minBok;
	case "t":
	case "T":
	  minBok = new Tidskrift(titel, skribent);
	return minBok;
	default: //should never happen.
	  minBok = new Bok(titel, skribent);
	  return minBok;
	}
    }
  }
  

  class Bok
  {
    //3 egenskaper nedan som är gemensamma för alla böcker
    public string Titel { get; set; }
    public string Skribent { get; set; }
    public string Typ { get; set; }

    public Bok(string titel, string skribent) //Basklass-konstruktor
    {
      Titel = titel;
      Skribent = skribent;
    }

    public override string ToString()
    {
      return Titel + ", " + Skribent + ", " + Typ;
    }

  }

      
  class Tidskrift : Bok //underklass boktyp
  {
    public Tidskrift(string titel, string skribent) : base(titel, skribent) //ärvda egenskaper från Bok klassen
      {
	Typ = "Tidskrift"; //ger ett värde till ärvd egenskap
      }
  }
  

  class Novell : Bok //underklass boktyp
  {
    public Novell(string titel, string skribent) : base(titel, skribent)
      {
	Typ = "Novell";
      }
  }

  class Roman : Bok //underklass boktyp
  {
    public Roman(string titel, string skribent) : base(titel, skribent)
      {
	Typ = "Roman";
      }


  }
}

