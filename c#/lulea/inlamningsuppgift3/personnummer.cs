// File:    Personnummer.cs
// Task:    Inlämningsuppgift 3
// Summary: This is a social security number
//          checking program
//          The program uses two .ico-files
// Version: 1.0
// Owner:   Tomas Berggren 700905-2114   L0002B
// ----------------------------------------------
// Log: 2019-02-14 Created the file. 

using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormWithButton
{
  /*class to build form with 4 textBoxes, 1 button
    and a small menu to exit the program*/
  public class Form1 : Form
  {
    public Button Button1;
    public Label Label1;
    public TextBox TextBox1;
    public TextBox TextBox2;
    public TextBox TextBox3;
    public TextBox TextBox4;
    //common constants for size and postion of controls
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

      TextBox2 = new TextBox();
      TextBox2.Size = new Size(textBoxW, textBoxH);
      TextBox2.Location = new Point(startPosX, TextBox1.Location.Y+30);
      TextBox2.Text = "Efternamn";
      this.Controls.Add(TextBox2);

      TextBox3 = new TextBox();
      TextBox3.Size = new Size(textBoxW, textBoxH);
      TextBox3.Location = new Point(startPosX, TextBox2.Location.Y+30);
      TextBox3.Text = "Personnummer";
      this.Controls.Add(TextBox3);

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
      TextBox4.Multiline = true;
      TextBox4.AcceptsReturn = true;
      TextBox4.WordWrap = true;	    
      this.AutoSize = false;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      // program icon, must be in the same folder for compilation
      this.Icon = new Icon("my.ico");

      CreateMenuWithEventAndKey();
    }
    // method called when button is clicked
    private void Button1_Click(object sender, EventArgs e)
    {
      // the control code is placed in a separate method
      CheckInput();
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
      if (validNumber) {
	TextBox4.Text += ("Kön:\t\t"+gender+"\r\n");
      }
      else
	{
	  TextBox4.Text += ("Kön:\t\t"+"okänt"+"\r\n");
	}
      TextBox4.Text += ("Personnumret är :\t"+validStatusString);
    }
    // menu code from
    // https://www.coderslexicon.com/quick-tutorial-building-menus-dynamically-with-the-menustrip-control-in-c/
    private void CreateMenuWithEventAndKey() {
      MenuStrip strip = new MenuStrip();
      ToolStripMenuItem fileItem = new ToolStripMenuItem("&File");
      // Create our first item with an image and wired to a click event
      // Also sets standard exit command Alt +F4 as the shortcut
      ToolStripMenuItem itemWithEventAndKey =
	new ToolStripMenuItem("Exit", Image.FromFile("exit.ico"),
			      exitItem_Click, (Keys)Shortcut.AltF4);
      fileItem.DropDownItems.Add(itemWithEventAndKey);
      strip.Items.Add(fileItem);
      this.Controls.Add(strip);
    }
    // Event that is called from menu item.
    private void exitItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }
    // The main class that creates all the public strings and methods used later
    public class Person
    {
      private string FirstName;
      private string SurName;
      private string SocialSecurityNumber;
      //constructor, creating a person with values for name and number     
      public Person(string FirstName, string SurName, string SocialSecurityNumber)
      {
	this.FirstName = FirstName;
	this.SurName = SurName;
	this.SocialSecurityNumber = SocialSecurityNumber;
      }
      // method to return firstName from class
      public string GetFirstName()
      {
	return FirstName;
      }
      // method to return surName from class
      public string GetSurName()
      {
	return SurName;
      }
      // method to return social security number from class
      public string GetSocialSecurityNumber()
      {
	return SocialSecurityNumber;
      }
      // method to calculate the control algoritm, mulitply
      //each digit with 2 or 1
      public int calculateSum(int sum, int posDigit, int x)
      {
	int subSum = 0;
	int modRest = 0;
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
	return sum;
      }
      // method to swap x value between 1 and 2
      public int getXValue(int x)
      {
	if (x == 2){
	  x = 1;
	}
	else {
	  x = 2;
	}
	return x;
      }
      /* method to check if the social security number is correct
	 this method check length,10-13 depending on divider or not
	 The method also calculate the control number and compare
	 with the one written. It become much more complicated and
	 time consuming than planned */
      public bool Valid()
      {
	string socialSecurityNumber = this.GetSocialSecurityNumber();
	int sum = 0;
	int x = 2;
	int ssnLength = socialSecurityNumber.Length;
	if (ssnLength <10 || ssnLength >13) {
	  MessageBox.Show("Personnumret har fel längd, försök igen!");
	}
	bool correctFormat = true;
	int inCorrectFormatPos = 99;//dummy default value, obviously wrong
	int startValue = 0;
	int lastDigit = 0;
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
		//correctFormat = true;
	      }
	    }
	  else
	    {
	      int.TryParse(socialSecurityNumber[ssnLength-1].ToString(),
			   out lastDigit);
	  }
	  sum = calculateSum(sum, posDigit, x);
	  x = getXValue(x);
	}
	bool correctDivider = false;
	if (!correctFormat &&(inCorrectFormatPos == (ssnLength -5))) {
	  correctDivider = true;
	}
	else if (!correctFormat &&(inCorrectFormatPos != (ssnLength -5))) {
	  string wrongFormat = "Personnumret har fel format på pos ";
	  string tenOrTwelve = ", det ska vara 10 eller 12 siffor ";
	  string withOrWithoutDivider =  "med eller utan\n avdelare mellan datum och de sista fyra, ";
	  string tryAgain = "försök igen!";
	  MessageBox.Show(wrongFormat+inCorrectFormatPos+tenOrTwelve+withOrWithoutDivider+tryAgain);
	}
	else if (correctFormat && (ssnLength != 10 && ssnLength != 12)) {
	  MessageBox.Show("Personnumret har fel längd, försök igen!");
	}
	if (correctDivider && !correctFormat)
	  {
	    correctFormat = true;
	  }
	string controlNrString = sum.ToString();
	char lastDigitChar = (sum>9 ? controlNrString[1] : controlNrString[0]);
	string lastDigitStr = lastDigitChar.ToString();
	int lastDigitInt = 0;

	int ctrlNr = 0;
	if (Int32.TryParse(lastDigitStr, out lastDigitInt))
	  {
	    ctrlNr = 10 - lastDigitInt;
	    if (ctrlNr == 10){
	      ctrlNr = 0;
	    }
	  }
	bool correctNumber = (correctFormat && ctrlNr == lastDigit);
	return correctNumber;
      }
      //method to check the gender by modulus divsion on the second last
      //digit
      public bool Gender()
      {
	string socialSecurityNumber = this.GetSocialSecurityNumber();
	int genderDigitPos = socialSecurityNumber.Length-2;
	char gender = socialSecurityNumber[genderDigitPos];
	int genderDigit = 0;
	bool correctFormat = true;
	while (!int.TryParse(gender.ToString(), out genderDigit))
	  {
	    correctFormat = false;
	    break;
	  }
	if (!correctFormat) {
	  MessageBox.Show("Näst sista är inte en siffra, försök igen!");
	}
	bool female = (genderDigit %2==0);
	return female;
      }
    }
    static void Main()
    {
      Application.EnableVisualStyles();
      Form f = new Form1();
      f.Size = new System.Drawing.Size(350, 350);  
      Application.Run(f);
    }
  }
}
