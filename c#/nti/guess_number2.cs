using System;

namespace Project4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random slumpat = new Random();
            int speltal = slumpat.Next(1, 21);
            // saknades värde i slumptalen, 1,20 skulle endast slumpa ut mellan 1-19 och därför valde jag 1-21(läste faktiskt det )

            bool spela = true;

            while (spela) //man kan inte använda "!" för att namnge loop. 
            {
                int tal; //tog bort konverteringen och då blev det fel så var tvungen att ge tal ett värde.
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");

                Int32.TryParse(Console.ReadLine(), out tal);

                if (tal == 0)
                //Anledningen till denna if-sats är för att skriva ut ett svar om användaren skriver bokstäver ELLER siffran 0
                {
                    Console.WriteLine("\tHoppsan! Du angav inte ett heltal mellan 1-20, försök igen!");
                }

                if (tal > 0 && tal < speltal) //jag la till "&& tal < speltal" så att nedan output inte tillkommer om användaren använder 0
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen."); // saknades en "+"
                }

                if (tal == speltal) //behövdes ett till = för att det ska bli ''är lika med''
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    //changed brackets(vet inte vad de kallas på svenska, jag har engelska som modersmål) {} to put spela = false; inside the while loop. 
                    Console.ReadKey(); //behövde skriva ut loopen också.
                    spela = false;

                }


            }
        }
    }
}