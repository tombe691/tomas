using System;


namespace Uppgift_4
{
    class Program
    {

       // Här ifrån börjar programmen
        static void Main(string[] args)
        {
            bool spela = true;
            Random slumpat = new Random();// det saknades en klammerparentes för att få ihop kodstycke som utför slumpa tal.
            int speltal = slumpat.Next(1, 21);//I detta fall så har jag lagt till inne i paranteserna värderna som overload metoden ska slumpa tal i mellan.I detta fall så värderna som skall sluppas är mellan 1 och 20.
            while (spela)//I detta fall så har jag upptäck ett fel. Felet bestog av att ett utropstecken var med inne paranteserna vilket i slut ändan gjorde att while loopen hittade inte bool spela.
                
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");//Här fanns det ett fel och det bestog av att programmen fick inte använda den rätta biblioteket. user system är fel den rätta biblioteken är using System. Där ifrån använder vi Console.Write(); och detta felet uppstog i alla delarna där vi behövde använda Console.WriteLine(); samt Console.Write();
                int tal;
                Int32.TryParse(Console.ReadLine(), out tal);// Med TryParse så gör man att programmen inte kraschar under körtid. Detta händer genom att när man matar in text istället siffror så att programmen fortsätter att fungera.
                if (tal == 0)// För att användaren ska inte få information om att värdet är 0 vid fel inmatning så anväder jag if sats med continue så att programmet fortsätter fungera.
                {
                    Console.WriteLine("\n\tSkriv in siffra!");// Med denna kod säger jag till användaren om att det skall matas in siffror inte text.
                    //continue;
                }
                else {
                    if (tal < speltal)
                    {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                    }

                    else if (tal > speltal)//det som var fel idetta fall var "else if" istället endast "if".För att if,else if sats ska fungera  så behöver vi använda oss av den rätta formen först if sedan else if.
                    {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för stort,försök igen.");// i kod saknades + tecken för att plussa ihop innehållet annars får vi fel meddelande.
                    }

                    else if (tal == speltal)//saknades likamed tecken för att satsen ska vara rätt.
                    {   
                        Console.WriteLine("\tGrattis, du gissade rätt!");
                        spela = false;// här slutar programmet fungera på grund av att bool spel är inte sant. Detta gör man genom att bool spel blir inte sant.
                    }
                }
            }
            Console.ReadLine();//koden saknades för att kunna visa innehållet på skärmen samt skärmen inte stängs ner direkt när man har startat programmet.


        }
    }
}


