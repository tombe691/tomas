using System;
namespace Program1
{
  public class Program
  {
    static void Main(string[] args)
    {
      Biblilotekarie obj = new Biblilotekarie();
      obj.AdderaBok();
      obj.SkrivBoklista();
      Console.ReadLine();
    }
  }
  class Bok
  {
    public string författare;
    public string titel;
  }
  class Biblilotekarie
  {
    public List<Bok> boklista = new List<Bok>();

    public void AdderaBok()
    {
      // Lägger till en bok i boklistan
      Roman nyBok = new Roman();
      nyBok.författare = "Astrid"; nyBok.titel = "Pippi";
      boklista.Add(nyBok);

    }
    public void SkrivBoklista()
    {
      // Här kan jag skriva ut boklistan utan problem
      foreach (var item in boklista)
	{
	  Console.WriteLine(item.författare + " " + item.titel);
	} 
      // Hoppar till metoden Print i klassen Roman
      // och gör samma sak där.
      Roman objRoman = new Roman();
      objRoman.Print();
    }
  }
  class Roman : Bok
  {
    Biblilotekarie objBibliotekarie = new Biblilotekarie();
    public void Print()
    {
      // Skriver ingenting
      foreach (var item in objBibliotekarie.boklista)
	{
	  Console.WriteLine(item.författare + " " + item.titel);
	}
      // Försöker jag det här så kraschar programmet
      Console.WriteLine(objBibliotekarie.boklista[0]);
    }
    // Det verkar som om boken som jag lade in i boklistan i klassen Biliotekarie
  } // inte finns kvar i boklistan när jag försöker skriva ut från klassen Roman.
}
