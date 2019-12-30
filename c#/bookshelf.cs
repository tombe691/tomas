using System;
using System.Collections.Generic;

namespace bookShelf
{
  class Program
  {
    static void Main(string[] args)
    {
      //creating bookShelf.
      List<Book> bookShelf = new List<Book>();

      //init menu variable
      int menuChoice = 0;

      //menu loop
      while (menuChoice != 3)
	{
	  //menu text.
	  Console.WriteLine("\t Bibiloteket");
	  Console.WriteLine("\t[1] Lägg till en ny bok");
	  Console.WriteLine("\t[2] Visa alla böcker som finns i programmet");
	  Console.WriteLine("\t[3] Färdig");
	  Console.Write("\n\t");

	  //menu choice add
	  if (Int32.TryParse(Console.ReadLine(),out menuChoice))
	    {
	      Console.WriteLine();
	      switch (menuChoice)
		{
		case 1: //Add new
		  bookShelf.Add(Add());
		  break;

		case 2: //Show
		  Show(bookShelf);
		  break;

		case 3: //Exit.
		  break;

		default: //error message
		  Console.WriteLine("\tSkriv en siffra (1-3), inget annat.\n");
		  break;
		}
	    }
	  else //felmedelande
	    {
	      Console.WriteLine("\n\tDu måste skriva en siffra (1-3).\n");
	    }
	}
    }

    //sub menu
    public static int SubMenu()
    {
      int choice; //declare choice

      while (true) //input loop
	{

	  //Print sub menu.
	  Console.WriteLine("\n\t Välj nummer, [1] Roman, [2] Tidsskrift, [3] Novellsamling");
	  Console.Write("\n\t");

	  //check int
	  if (Int32.TryParse(Console.ReadLine(), out choice))
	    {
	      if (choice > 0 && choice < 4) 
		{
		  Console.WriteLine("\n\tLagrat\n");
		  return choice;
		}
	      else //error message
		{
		  Console.WriteLine("\n\tDu måste skriva en siffra (1-3)");
		}
	    }
	  else //error message
	    {
	      Console.WriteLine("\n\tDu måste skriva en siffra (1-3)");
	    }
	}
    }

    //method to handle new book
    public static Book Add()
    {
      //title.
      Console.Write("\tTitel: ");
      string title = Console.ReadLine();

      //author
      Console.Write("\n\tFörfattare: ");
      string author = Console.ReadLine();

      int type = SubMenu(); //call sub menu.
      Book newBook; //declare new book object.

      switch (type)
	{
	case 1:
	  newBook = new Novel(title, author); //Novel constructor
	  return newBook;

	case 2:
	  newBook = new Magazine(title, author); //Magazine constructor
	  return newBook;

	case 3:
	  newBook = new Collection(title, author); //Collection constructor
	  return newBook;

	default: //should never happen.
	  newBook = new Book(title, author); //.
	  return newBook;
	}
    }

    //show content
    public static void Show(List<Book> bookShelf)
    {
      if(bookShelf.Count == 0) //empty?
	{
	  Console.WriteLine("\tBibloteket är tomt\n");
	}
      else //print books
	{
	  foreach (Book book in bookShelf)
	    {
	      Console.WriteLine("\t" + book.ToString());
	    }
	}
      Console.WriteLine(); // formatting only
    }
  }

  //book class
  class Book
  {
    //initializing
    protected string title = "";
    protected string author = "";
    protected string type = "";

    //constructor.
    public Book( string title, string author)
    {
      this.title = title;
      this.author = author;
    }

    //make string.
    public override string ToString()
    {
      return "\"" + title + "\" skriven av " + author + ". (" + type + ")";
    }
  }

  //sub class Novel
  class Novel : Book
  {
    //constructor
    public Novel (string title, string author) : base(title, author)
      {
	this.type = "Roman";
      }
  }

  //sub class mag
  class Magazine : Book
  {
    //constructor
    public Magazine(string title, string author) : base(title, author)
      {
	this.type = "Tidskrift";
      }
  }

  //sub class collection
  class Collection : Book
  {
    //constructor
    public Collection(string title, string author) : base(title, author)
      {
	this.type = "Novellsamling";
      }
  }
}
