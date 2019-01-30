using System;

namespace Uppgift2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            bool myBackpack = true;
            //Det här är benämningen till ryggsäckens variabel. 
            string item = "ingenting";
            //detta är till för att om användaren trycker på val2 från början måste outputen visa att ryggsäcken inte innehåller något.

            while (myBackpack) 
            {
                Console.WriteLine("\nVälkommen till ryggsäcken!\n \nVälj bland följande alternativ: ");
                Console.Write("[1] Lägg till ett föremål\n[2] Skriv ut innehållet\n[3] Rensa innehållet\n[4] Avsluta\n");
                //Med tanke på att det kan bli väldigt mycket rader i koden pga all text har jag valt att endast använda 1 rad för menyn och 1 för välkomstmeddelandet. 

                int menuOption = Convert.ToInt32(Console.ReadLine());
                //Detta är nödvändigt för att konvertera användarens input till en integer då den automatiskt blir en string under Console.Write();

                switch(menuOption)
                {

                    case 1:
                        Console.WriteLine("Ange ett föremål att stoppa i ryggsäcken: ");
                        item = Console.ReadLine(); 
                        break;


                    case 2:
                        Console.WriteLine("Ryggsäcken innehåller " + item);
                        break;

                    case 3:
                        item = "ingenting";
                        Console.WriteLine("Du har tömt ryggsäcken.");
                        break;

                    case 4:
                        myBackpack = false;
                        break;


                    default://försäkringen om användaren råkar skriva fel i menyvalet
                        Console.WriteLine("Det alternativet finns inte, vänligen välj mellan 1 - 4");
                        break;

                }
            }




        }
    }
}
