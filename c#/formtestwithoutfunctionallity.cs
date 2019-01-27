using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Globalization;

namespace FormWithButton
{
    public class Form1 : Form
    {
        public Button Button1;
        public TextBox TextBox1;

	List<string> BookList = new List<string>();
        List<string[]> TheList = new List<string[]>();
        List<Book> OldClassList = new List<Book>();

        // Creating a random generator so that the books generate randomly when
        // the user clicks on the button
        Random TheGenerator = new Random();
        
        // Here I tried to make all the first letters to uppercase, the ones
        // presented on the textbox, I noticed the textfile had "true, false"
        // with small first letters, but it didnt work
        public string SetText(Control control)
        {
            TextBox1.Text = control.Text;
            TextBox1.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBox1.Text.ToLower());
            return TextBox1.Text;
        }
	
        public Form1()
        {
            Button1 = new Button();
            Button1.Size = new Size(104, 23);
            Button1.Location = new Point(12, 42);
            Button1.Text = "Click me";
            this.Controls.Add(Button1);
            Button1.Click += new EventHandler(Button1_Click);

	    TextBox1 = new TextBox();
	    TextBox1.Size = new Size(702, 24);
            TextBox1.Location = new Point(12, 12);
            TextBox1.Text = "Click me";
            this.Controls.Add(TextBox1);
            TextBox1.Click += new EventHandler(TextBox1_TextChanged);
	    
        }
        private void Button1_Click(object sender, EventArgs e)
        {
	  //            MessageBox.Show("Hello World");
	    Tipster();
        }
	public void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

	// The main thing for this homework, basically all the code to
        // make the program randomly selecting different books
        void Tipster()
        {
            {   // Streamreader method which helps reading for instance a textfile
                // with the help of "using System.IO", it reads the text and uses
                // enconding with a value of true or false, default is ANSI, theres others like UTF-8
                StreamReader Reader = new StreamReader("C:\\temp\\texter.txt", Encoding.Default, true);
                // The string to read the text and uses a while loop with a read line to
                // see if the textfile exists or not and adds the saved data to BookList
                string TheBook = "";
                while ((TheBook = Reader.ReadLine()) != null)
                {
                    BookList.Add(TheBook);
                }
                // A regular foreach checking every string in the booklist
                foreach (string a in BookList)
                {
                    // Creation of the string array StrVector and splits a string into substrings
                    // based on the strings in an array. Adds the data to the list
                    string[] StrVector = a.Split(new string[] { "###" }, StringSplitOptions.None);
                    //Console.WriteLine(StrVector);
                    TheList.Add(StrVector);
                    {
                        // A switch loop with cases for the 3 subclasses with the use of string array "TheVector"
                        // Using the last list "OldClassList" of the three created, which is a list of the old
                        // "Book" and storing the data into it with the subclasses and all the arrays for
                        // the title, author, booktype and stock availability
                        switch (StrVector[2])
                        {
                            // The Roman subclass case, adding the data into the list with arrays
                            case "Roman":
                                OldClassList.Add(new Roman(StrVector[0], StrVector[1], StrVector[2], StrVector[3]));
                                break;
                            // The Novellsamling subclass case
                            case "Novellsamling":
                                OldClassList.Add(new Novellsamling(StrVector[0], StrVector[1], StrVector[2], StrVector[3]));
                                break;
                            // The Tidskrift subclass case
                            case "Tidskrift":
                                OldClassList.Add(new Tidskrift(StrVector[0], StrVector[1], StrVector[2], StrVector[3]));
                                break;

                            default:
                                break;
                        }
                    }
                    // The method that uses the RNG tool for the textbox so that the user gets presented
                    // with random suggestions. It uses the last list, the rng generator, counting the list
                    // and in the end using the ToString. All in all the textbox presents the result
                    // with the help of this
                    TextBox1.Text = OldClassList[TheGenerator.Next(OldClassList.Count)].ToString();
                }
            }
        }

        // The main class that creates all the public strings which are used frequently later on
        // this class is the main and its the centerstone of everything else used here, like the list, subclasses, objects etc.
        public class Book
        {
            public string StrTitle;
            public string StrAuthor;
            public string StrType;
            public string StrStock;
            public string InStock = "true";
            public string NoStock = "false";

            public Book(string StrTitle, string StrAuthor, string StrType, string StrStock)
            {
                this.StrTitle = StrTitle;
                this.StrAuthor = StrAuthor;
                this.StrType = StrType;
                this.StrStock = StrStock;
            }
            public string TheTitle()
            {
                return StrTitle;
            }
            public string TheAuthor()
            {
                return StrAuthor;
            }
            public string TheType()
            {
                return StrType;
            }
            public string TheStock()
            {
                return StrStock;
            }
            
            // An override string which helps presenting all the objects/items with text describing
            // their uses, which is good thing to have
            public override string ToString()
            {
                return " '' " + StrTitle + " '' " + " written by  " + StrAuthor + ".  " + "((" + StrType + "))" + "   AVAILABILITY : " + StrStock + "!";
            }
        }
         // The first subclass Roman, a subclass has alot of the same properties as the main class
        // but can be used to change different policys and rules. It also includes its own public override string
        public class Roman : Book
        {
            public Roman(string StrTitle, string StrAuthor, string StrType, string StrStock) :
                base(StrTitle, StrAuthor, StrType, StrStock)
            {
                StrType = "Roman";
            }
            public override string ToString()
            {
                return " '' " + StrTitle + " '' " + " written by  " + StrAuthor + ".  " + "((" + StrType + "))" + "   AVAILABILITY : " + StrStock + "!";
            }

        }
        // The second subclass Novellsamling
        public class Novellsamling : Book
        {
            public Novellsamling(string StrTitle, string StrAuthor, string StrType, string StrStock) :
                base(StrTitle, StrAuthor, StrType, StrStock)
            {
                StrType = "Novellsamling";
            }
            public override string ToString()
            {
                return " '' " + StrTitle + " '' " + " written by  " + StrAuthor + ".  " + "((" + StrType + "))" + "   AVAILABILITY : " + StrStock + "!";
            }

        }
        // The third subclass Tidskrift
        public class Tidskrift : Book
        {
            public Tidskrift(string StrTitle, string StrAuthor, string StrType, string StrStock) :
                base(StrTitle, StrAuthor, StrType, StrStock)
            {
                StrType = "Tidskrift";
            }
            public override string ToString()
            {
                return " '' " + StrTitle + " '' " + " written by  " + StrAuthor + ".  " + "((" + StrType + "))" + "   AVAILABILITY : " + StrStock + "!";
            }


        }
	
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
	    Form f = new Form1();
	    f.Size = new System.Drawing.Size(744, 116);  
            Application.Run(f);
        }
    }
}
