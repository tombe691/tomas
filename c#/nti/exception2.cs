using System;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpat = new Random();
                     
            
            /* The numbers 1-20 were missing bewteen (), they were needed cause otherwise
            the main function of the game (guess a number 1-20) wouldnt function */
            int speltal = slumpat.Next(1, 20);


            bool spela = true;

            
            // The symbol "!" was present before the word "spela" and was removed
            while (spela)
            {

                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");

                                
                /* Removed the code line "int tal = Convert.ToInt32(Console.ReadLine());"
                and replaced it with the TryParse code below. The reason for this is that, 
                if the user typed a letter or a number that is not a whole number/integer, 
                then the program would crash, now it continues until guessing the right number */
                int tal = 0;
				
		//int oddOrEven = 0;
		string text = Console.ReadLine();

		bool notNumber = true;
		while (notNumber) {
			try
			{	
				tal = Convert.ToInt32(text);
			}

			catch
			{
				Console.WriteLine("You must enter a number, please try again");
				notNumber = false;
			}
		}

        //		
				//Int32.TryParse(Console.ReadLine(), out tal);



                if (tal < speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }



                if (tal > speltal)
                {                                
                    
                    // The symbol "+" was missing between "tal" and "text line"
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                }
                


                // There should be two "=" symbols between tal and speltal
                if (tal == speltal)



                {   /* <-- There should be a "{" here otherwise the "while (spela)" loop                
                    would just stop cause of the last code line below "spela = false" 
                    not being inside of a code block */


                    Console.WriteLine("\tGrattis, du gissade rätt!");


                    
                    /* Added the ReadKey line, cause if the user guessed the right number, 
                    the program would close without giving out a message that he or she completed the game */
                    Console.ReadKey();



                    spela = false;
                }   /* <-- As described above, there should be a "}" here, otherwise 
                       the "while (spela)" loop would just stop cause of "spela = false"
                       not being inside of a code block */
            }
        }
    }
}
