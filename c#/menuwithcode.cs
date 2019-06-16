using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
using System.Windows.Forms;  
  
  
  
namespace MenuTest  
{  
    public partial class MenuTest1 : Form  
    {  
        private MainMenu mainMenu;    
  
	        public Form1()
        {
            Button1 = new Button();
            Button1.Size = new Size(104, 23);
            Button1.Location = new Point(12, 120);
            Button1.Text = "Kontrollera";
            this.Controls.Add(Button1);
            Button1.Click += new EventHandler(Button1_Click);
}
        public MenuTest1()  
        {  
            //InitializeComponent();  
            mainMenu = new MainMenu();  
            MenuItem File = mainMenu.MenuItems.Add("&File");  
            File.MenuItems.Add(new MenuItem("&New"));  
            File.MenuItems.Add(new MenuItem("&Open"));  
            File.MenuItems.Add(new MenuItem("&Exit"));  
            this.Menu = mainMenu;  
            MenuItem About = mainMenu.MenuItems.Add("&About");  
            About.MenuItems.Add(new MenuItem("&About"));  
            this.Menu = mainMenu;  
            mainMenu.GetForm().BackColor = Color.Indigo;    
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