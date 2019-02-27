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

	public const int startPosX = 10;
	public const int startPosY = 50;
	public const int textBoxW = 300;
	public const int textBoxH = 24;
	
        public Form1()
        {
            Label1 = new Label();
            Label1.Size = new Size(104, 23);
            Label1.Location = new Point(startPosX, startPosY);
            Label1.Text = "Välkommen";
	    Label1.Size = new Size(250, 50);
	    Label1.Font = new Font("Elephant", 20);
            this.Controls.Add(Label1);
	    
	    TextBox1 = new TextBox();
	    TextBox1.Size = new Size(textBoxW, textBoxH);
            TextBox1.Location = new Point(startPosX, Label1.Location.Y+50);
            TextBox1.Text = "Förnamn";
            this.Controls.Add(TextBox1);
            TextBox1.Click += new EventHandler(TextBox1_TextChanged);

	    TextBox2 = new TextBox();
	    TextBox2.Size = new Size(textBoxW, textBoxH);
            TextBox2.Location = new Point(startPosX, TextBox1.Location.Y+30);
            TextBox2.Text = "Efternamn";
            this.Controls.Add(TextBox2);
            TextBox2.Click += new EventHandler(TextBox2_TextChanged);

	    TextBox3 = new TextBox();
	    TextBox3.Size = new Size(textBoxW, textBoxH);
            TextBox3.Location = new Point(startPosX, TextBox2.Location.Y+30);
            TextBox3.Text = "7009052114";//Personnummer";
            this.Controls.Add(TextBox3);
            TextBox3.Click += new EventHandler(TextBox3_TextChanged);

            Button1 = new Button();
            Button1.Size = new Size(104, 23);
            Button1.Location = new Point(startPosX, TextBox3.Location.Y+30);
            Button1.Text = "Kontrollera";
            this.Controls.Add(Button1);
            Button1.Click += new EventHandler(Button1_Click);

	    TextBox4 = new TextBox();
	    TextBox4.Size = new Size(textBoxW, (textBoxH*3));
            TextBox4.Location = new Point(startPosX, Button1.Location.Y+30);
            TextBox4.Text = "Resultat";
            this.Controls.Add(TextBox4);
            TextBox4.Click += new EventHandler(TextBox4_TextChanged);
	    TextBox4.Multiline = true;
	    TextBox4.AcceptsReturn = true;
            TextBox4.WordWrap = true;	    
	    this.AutoSize = false;
	    // Define the border style of the form to a dialog box.
	    this.FormBorderStyle = FormBorderStyle.FixedDialog;

	    // Set the MaximizeBox to false to remove the maximize box.
	    this.MaximizeBox = false;

	    // Set the MinimizeBox to false to remove the minimize box.
	    this.MinimizeBox = false;
	    
	    // Set the start position of the form to the center of the screen.
	    this.StartPosition = FormStartPosition.CenterScreen;

	    //	    this.Icon = new Icon("Resources/statusnormal.ico");
	    this.Icon = new Icon("my.ico");

	    CreateMenuWithEventAndKey();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
	    CheckInput();
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

        // make the program count control number and check gender
        void CheckInput()
        {
	  Person newPerson = new Person(TextBox1.Text, TextBox2.Text, TextBox3.Text);
	  string firstName = newPerson.GetFirstName();
	  string surName = newPerson.GetSurName();
	  string socialSecurityNumber = newPerson.GetSocialSecurityNumber();
	  bool isFemale = newPerson.Gender();
	  bool validNumber = newPerson.Valid();
	  string gender = (isFemale ? "Kvinna" : "Man");
	  string validStatusString = (validNumber ? "korrekt" : "felaktigt");
	  TextBox4.Text = "Förnamn:\t\t"+firstName+"\r\n"+"Efternamn:\t"+surName;
	  TextBox4.Text += ("\r\nPersonnummer:\t"+socialSecurityNumber+"\r\n");
	  TextBox4.Text += ("Kön:\t\t"+gender+"\r\n");
	  TextBox4.Text += ("Personnumret är :\t"+validStatusString);
        }
	// menu code from
	// https://www.coderslexicon.com/quick-tutorial-building-menus-dynamically-with-the-menustrip-control-in-c/
	private void CreateMenuWithEventAndKey() {
	  MenuStrip strip = new MenuStrip();

	  ToolStripMenuItem fileItem = new ToolStripMenuItem("&File");

	  // Create our first item with an image and wired to a click event
	  // Also sets standard exit command Alt + F4 as the shortcut
	  ToolStripMenuItem itemWithEventAndKey = new ToolStripMenuItem("Exit Event",
									Image.FromFile("c:\\temp\\delete.png"), exitItem_Click, (Keys)Shortcut.AltF4);

	  fileItem.DropDownItems.Add(itemWithEventAndKey);
	  strip.Items.Add(fileItem);
	  this.Controls.Add(strip);
	}

	// Event that is called from menu item.
	private void exitItem_Click(object sender, EventArgs e) {
	  Application.Exit();
	  //	  MessageBox.Show("Delete Event");
	}
        // The main class that creates all the public strings which are used frequently later on
        // this class is the main and its the centerstone of everything else used her.
        public class Person
        {
            public string FirstName;
            public string SurName;
            public string SocialSecurityNumber;
           
            public Person(string FirstName, string SurName, string SocialSecurityNumber)
            {
                this.FirstName = FirstName;
                this.SurName = SurName;
                this.SocialSecurityNumber = SocialSecurityNumber;
            }
            public string GetFirstName()
            {
                return FirstName;
            }
            public string GetSurName()
            {
                return SurName;
            }
            public string GetSocialSecurityNumber()
            {
                return SocialSecurityNumber;
            }
            public bool Valid()
            {
	      string socialSecurityNumber = this.GetSocialSecurityNumber();
	      int sum = 0;
	      int subSum = 0;
	      int modRest = 0;
	      int x = 2;
	      int ssnLength = socialSecurityNumber.Length;
	      
	      if (ssnLength <10 || ssnLength >13) {
		  MessageBox.Show("Personnumret har fel längd, försök igen!");
	      }
	      bool correctFormat = true;
	      int inCorrectFormatPos = 99;//dummy default value, obviously wrong
	      int startValue = 0;
	      if (ssnLength>11){
		startValue = 2;
	      }
	      for (int i = startValue;i < ssnLength-1;i++){
		int posDigit;
		if (!int.TryParse(socialSecurityNumber[i].ToString(), out posDigit))
		{
		  correctFormat = false;
		  inCorrectFormatPos = i;
		  if (inCorrectFormatPos == (ssnLength -5)){
		    ++i;
		    int.TryParse(socialSecurityNumber[i].ToString(), out posDigit);
		  }
		}

		subSum = (posDigit * x);
		if (subSum>9){
		  sum+=1;
		  modRest = subSum %10;
		}
		else {
		  modRest = 0;
		}
		if (modRest > 0) {
		  sum+=modRest;
		}
		else{
		  sum += subSum;
		}
		if (x == 2){
		  x = 1;
		}
		else {
		  x = 2;
		    }
	      }
	      if (!correctFormat &&(inCorrectFormatPos != (ssnLength -5))) {
		MessageBox.Show("Personnumret har fel format på pos "+inCorrectFormatPos+", det ska vara 10 eller 12 siffor med eller utan\n avdelare mellan datum och de sista fyra, försök igen!");
	      }
	      else if (correctFormat && (ssnLength != 10 && ssnLength != 12)) {
		  MessageBox.Show("Personnumret har fel längd, försök igen!");
		}
	      string controlNrString = sum.ToString();
	      char lastDigitChar = controlNrString[1];
	      string lastDigitStr = lastDigitChar.ToString();

	      int lastDigitInt = 0;

	      if (Int32.TryParse(lastDigitStr, out lastDigitInt))
		{
		  int ctrlNr = 10 - lastDigitInt;
		  if (ctrlNr == 10){
		    ctrlNr = 0;
		  }
		}
	      return true;
            }
            public bool Gender()
            {
	      string socialSecurityNumber = this.GetSocialSecurityNumber();
	      int genderDigitPos = socialSecurityNumber.Length-2;
	      char gender = socialSecurityNumber[genderDigitPos];
	      int genderDigit;
	      while (!int.TryParse(gender.ToString(), out genderDigit))
		{
		  MessageBox.Show("Näst sista är inte en siffra, försök igen!");
		}
	      bool female = (gender %2==0);

	      return female;
            }
        }
	
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
	    Form f = new Form1();
	    f.Size = new System.Drawing.Size(350, 350);  
            Application.Run(f);
        }
    }
}
