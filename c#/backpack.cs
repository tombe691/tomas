using System;

namespace Ryggsäcken
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Här initieras en bool för att vi ska kunna använda oss av en loop,
             * i annat fall skulle menyn endast synas en gång*/
            bool isRunning = true;
            /* vi behöver initsiera vår sträng(str) "content" här för att den ska vara synlig för alla
             * nedanstående kodblock*/          
            string content = Console.ReadLine();
            //här är själva loopen, dvs så länge detta är sant kommer menyn att visas omoch om igen
            while (isRunning)
            {
                /*här är själva programmets meny*/
                Console.WriteLine("\n Välkommen till ryggsäcken!");
                Console.WriteLine("\t[1] Lägg till ett föremål");
                Console.WriteLine("\t[2] Skriv ut innehållet");
                Console.WriteLine("\t[3] Rensa Innehållet");
                Console.WriteLine("\t[4] Avsluta");
                Console.Write("\n Gör ett val ");


                                int selection = Convert.ToInt32(Console.ReadLine());
                //Här är olika utfall eroende på vilket val användaren gör
                if (selection == 1)
                {
                    Console.Write("Lägg till ett föremål: ");
                    /* genom att använda "+=" operatorn läggs det nya inmatade värdet till det gamla
                     * i annat fall visar den endast det senast inmatade värdet*/
                      content += Console.ReadLine();
                    // om val 1 får användare mata in vad den vill lägga i ryggsäcken
                }
                else if (selection == 2)
                    //om val 2 skrivs  det som användaren har lagt till i ryggsäcken ut.
                {
                    Console.WriteLine(content);
                }
                else if (selection == 3)
                    //om val 3 tilldelas conten ett "tomt" värde dvs ryggsäcken töms
                {
                    content = "";
                }
                else if (selection == 4)
                    /*ger att bool är false och avslutar loopen, detta eftersom
                     * att while loopen endast körs så länge  den är sann.
                     * detta gör att menyn inte kommer att visas om du anger  val 4*/                    
                {
                    isRunning = false;
                }
                else
                { //Raden under kommer upp om du väljer utanför sifferspannet.
                    Console.WriteLine(" Ogiltigt val, välj mellan [1] [2] [3] [4]");
                    /* slutkommentar precis som ni anger i videon hade det genom att använda 
                     *switch istället för else och if else gett en elegantare kod, men ville testa 
                     *på detta sätt för att se hur det blev.
                     För att motverka krasch vid felaktig inmatning, tänker jag att man kunde
                     ha löst genom en tryParse, antar att vi kommer gå igenom det senare.*/
                }


            }
        }
    }
}
