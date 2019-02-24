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
	public Label Label1;
        public TextBox TextBox1;
        public TextBox TextBox2;
        public TextBox TextBox3;
        public TextBox TextBox4;

	//	List<string> BookList = new List<string>();
	
        public Form1()
        {
            Button1 = new Button();
            Button1.Size = new Size(104, 23);
            Button1.Location = new Point(12, 120);
            Button1.Text = "Kontrollera";
            this.Controls.Add(Button1);
            Button1.Click += new EventHandler(Button1_Click);

            Label1 = new Label();
            Label1.Size = new Size(104, 23);
            Label1.Location = new Point(12, 10);
            Label1.Text = "Välkommen";
	    Label1.Size = new Size(250, 50);
	    //	    Label1.Font = new System.Drawing.Font(Label1.Font.Name, 24F);
	    Label1.Font = new Font("Elephant", 20);
            this.Controls.Add(Label1);
	    
	    TextBox1 = new TextBox();
	    TextBox1.Size = new Size(300, 24);
            TextBox1.Location = new Point(12, 35);
            TextBox1.Text = "Förnamn";
            this.Controls.Add(TextBox1);
            TextBox1.Click += new EventHandler(TextBox1_TextChanged);

	    TextBox2 = new TextBox();
	    TextBox2.Size = new Size(300, 24);
            TextBox2.Location = new Point(12, 65);
            TextBox2.Text = "Efternamn";
            this.Controls.Add(TextBox2);
            TextBox2.Click += new EventHandler(TextBox2_TextChanged);

	    TextBox3 = new TextBox();
	    TextBox3.Size = new Size(300, 24);
            TextBox3.Location = new Point(12, 95);
            TextBox3.Text = "Personnummer";
            this.Controls.Add(TextBox3);
            TextBox3.Click += new EventHandler(TextBox3_TextChanged);

	    TextBox4 = new TextBox();
	    TextBox4.Size = new Size(300, 48);
            TextBox4.Location = new Point(12, 150);
            TextBox4.Text = "Resultat";
            this.Controls.Add(TextBox4);
            TextBox4.Click += new EventHandler(TextBox4_TextChanged);
	    TextBox4.Multiline = true;
	    TextBox4.AcceptsReturn = true;
            TextBox4.WordWrap = true;	    
	    
        }
        private void Button1_Click(object sender, EventArgs e)
        {
	    Tipster();
        }
	public void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
	public void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
	public void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
	public void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

	// The main thing for this homework, basically all the code to
        // make the program randomly selecting different books
        void Tipster()
        {
	  Person newPerson = new Person(TextBox1.Text, TextBox2.Text, TextBox3.Text);
	  string firstName = newPerson.GetFirstName();
	  MessageBox.Show("Hello World "+firstName);
	  TextBox4.Text = firstName+"\r\n"+firstName;
	  TextBox4.Text += ("brown\r\n");
	  TextBox4.Text += ("brwn");
        }

        // The main class that creates all the public strings which are used frequently later on
        // this class is the main and its the centerstone of everything else used her.
        public class Person
        {
            public string FirstName;
            public string SureName;
            public string SocialSecurityNumber;
           
            public Person(string FirstName, string SureName, string SocialSecurityNumber)
            {
                this.FirstName = FirstName;
                this.SureName = SureName;
                this.SocialSecurityNumber = SocialSecurityNumber;
            }
            public string GetFirstName()
            {
                return FirstName;
            }
            public string GetSureName()
            {
                return SureName;
            }
            public string GetSocialSecurityNumber()
            {
                return SocialSecurityNumber;
            }
            public bool Valid()
            {
                return true;
            }
            public int Gender()
            {
                return 1;
            }
        }
	
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
	    Form f = new Form1();
	    f.Size = new System.Drawing.Size(444, 250);  
            Application.Run(f);
        }
    }
}
