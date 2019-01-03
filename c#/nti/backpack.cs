using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2___Ryggsäcken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> things = new List<string>();   // Skapar en lista för att senare lagra innehåll i.

            while (true)    // Skapar en while-loop som visar alternativen nedan tills dess att användaren gör ett val.
            {
                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
                // START: HUVUDMENY!
                // Tecken inom [] visar vad användaren ska skriva för att komma vidare.
                Console.WriteLine("[S]toppa något i ryggsäcken:");
                Console.WriteLine("[V]isa innehåll:");
                Console.WriteLine("[T]öm ryggsäck eller ta ur något:");
                Console.WriteLine("[A]vsluta:");
                Console.Write("Välj vad du vill göra: ");   // Användaren får välja vad hen vill göra genom.

                string input = Console.ReadLine(); // Strängen choise initieras och tilldelas det användaren skrev. Detta kommer användas i nedanstående rader.
                string choise = input.ToUpper();
                // SLUT: HUVUDMENY!
                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/

                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
                // START: STOPPA NÅGOT I RYGGSÄCKEN.
                if (choise == "S" || choise == "s") // OM användaren har skrivit S eller s i huvudmenyn händer följande.
                {
                    Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                    Console.Write("Vad vill du stoppa i ryggsäcken?: ");    // Användaren får här skriva in vad som ska läggas i ryggsäcken.

                    string a = Console.ReadLine();  // Strängvariabeln a initieras här och tilldelas det som användaren skrev.
                    things.Add(a);  // Strängvariabeln a läggs till listan things.
                    Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                }   // Återgår till huvudmenyn.
                // SLUT: STOPPA NÅGOT I RYGGSÄCKEN.
                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/

                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
                // START: VISA INNEHÅLL.
                else if (choise == "V" || choise == "v")     // OM användaren har skrivit V eller v i huvudmenyn händer följande.
                {
                    if (things.Count == 0)  //OM användaren inte har något i ryggsäcken händer följande.
                    {
                        Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                        Console.WriteLine("--------------------Du har ännu ingenting i ryggsäcken--------------------");    // Textraden förklarar att ryggsäcken är tom.
                        Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                    }
                    else    // ANNARS finns det saker i ryggsäcken och följande händer.
                    {
                        Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                        Console.WriteLine("--------------------Du har följande saker i ryggsäcken--------------------");    // Textrad som rubrik för innehållet.
                        for (int i = 0; i < things.Count; i++)  // Går igenom samtliga index i listan, med start index 0 och ökar med 1 tills den har gått igenom alla.
                            Console.WriteLine(i + ": " + things[i]);    // Skriver ut index "i" enligt for-loopen för varje ökat värde så att användaren kan se innehållet.
                        Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                    }
                }   // Återgår till att visa huvudmenyn.
                // SLUT: VISA INNEHÅLL.
                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/

                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
                // START: TÖM RYGGSÄCKEN ELLER TA UR NÅGOT.
                else if (choise == "T" || choise == "t")    // ANNARS OM användaren har skrivit T eller t i huvudmenyn händer följande.
                {
                    if (things.Count == 0)  // OM användaren inte har något i ryggsäcken händer följande.
                    {
                        Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                        Console.WriteLine("--------------------Du har ännu ingenting i ryggsäcken--------------------");    // Textraden säger att ryggsäcken är tom.
                        Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                    }
                    else    // ANNARS finns det saker i ryggsäcken och följande händer.
                    {
                        Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                        bool goBack = true;     // Programmet kommer gå tillbaka hit så länge goBack = true. Är goBack = false kommer man till huvudmenyn.

                        do  // Följande kommer göras så länge goBack = true.
                        {
                            Console.Write("Vill du tömma [h]ela ryggsäcken, bara [e]n sak eller [g]å tillbaka till huvudmenyn?: "); // Frågar vad man vill göra.

                            string emptyChoise = Console.ReadLine();    // Strängen emptyChoise läser in användarens svar för att tolka i nedanstående rader.

                            if (emptyChoise == "H" || emptyChoise == "h")   // OM användaren har skrivit H eller h kommer allt innehåll i ryggsäcken raderas.
                            {
                                int x = things.Count;   // int x blir antalet saker som finns i listan för saker i ryggsäcken.
                                things.RemoveRange(0, x);   // Med RemoveRange raderas varje index i listan things, från index 0 till x. Det vill säga samtliga.
                                goBack = false; // goBack sätts till false, vilket kommer avbryta do while-loopen vilket leder till att man kommer till huvudmenyn.
                                Console.Clear();    // Innan loopen avbryts rensas all text i konsollen.
                                Console.WriteLine("---------------------------Ryggsäcken är nu tom---------------------------");
                                Console.WriteLine("--------------------------------------------------------------------------");
                            }
                            else if (emptyChoise == "E" || emptyChoise == "e")  // ANNARS OM användaren har skrivit E eller e får man välja vad man vill ta bort.
                            {
                                Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                                bool deleteLoop = true; // Programmet kommer gå tillbaka hit så länge deleteLoop = true. Är deleteLoop = false kommer man till "Töm"-menyn.

                                do  // Följande komer göras så länge deleteLoop = true.
                                {
                                    if (things.Count == 0)  // OM användaren inte har något i ryggsäcken händer följande.
                                    {
                                        Console.WriteLine("--------------------Du har ingenting kvar i ryggsäcken--------------------");    // Textraden säger att ryggsäcken är tom.
                                        Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                                        deleteLoop = false; // Eftersom man inte kan ta bort någonting avbryts do while-loopen vilket leder till att man kommer till "Töm"-menyn.
                                        goBack = false; // Eftersom man inte kan ta bort någonting avbryts även denna do while-loop, varpå man kommer till huvudmenyn.
                                    }
                                    else    // ANNARS sker följande.
                                    {
                                        Console.WriteLine("--------------------Du har följande saker i ryggsäcken--------------------");    // Textrad som rubrik för innehållet.    
                                        for (int i = 0; i < things.Count; i++)  // Går igenom samtliga index i listan, med start index 0 och ökar med 1 tills den har gått igenom alla.
                                            Console.WriteLine(i + ": " + things[i]);    // Skriver ut index "i" enligt for-loopen för varje ökat värde så att användaren kan se innehållet.
                                        Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                                        Console.Write("Välj vilken sak du vill ta bort: "); // Användaren uppmanas skriva in vilket index den vill ta bort.

                                        string delete = Console.ReadLine(); // Strängvariabeln delete initieras här och tilldelas det som användaren skrev.
                                        int deleteNr;   // int deleteNr deklareras för att senare användas i try catch metoden nedan.

                                        try     // Programmet försöker nu konvertera deleteNr till ett heltal och radera det indexet från listan.
                                        {
                                            deleteNr = Convert.ToInt32(delete); // Konverterar string delete till ett heltal.
                                            things.RemoveAt(deleteNr);  // Med RemoveAt raderas det index som skrivs inom parentesen.
                                            deleteLoop = false; // deleteLoop sätts till false, vilket leder till att man kommer till "Töm"-menyn.
                                            Console.Clear();    // Innan loopen avbryts rensas all text i konsollen.
                                        }

                                        catch   // Skulle inte string delete gå att konvertera till Int32 kommer loopen startas om när man når while eftersom deleteLoop fortfarande är true.
                                        {
                                            Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                                            Console.WriteLine("-----------Ogiltigt val. Var vänlig svara med siffror i heltal!-----------");    // Textrad som förklarar felet.
                                            Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                                        }
                                    }
                                } while (deleteLoop);   // Programmet återgår till deleteLoop och man hamnar i "Töm"-menyn. 
                            }

                            else if (emptyChoise == "G" || emptyChoise == "g")  // ANNARS OM användaren har skrivit G eller g återgår man till huvudmenyn.
                            {
                                goBack = false; // goBack sätts till false, vilket kommer avbryta do while-loopen vilket leder till att man kommer till huvudmenyn.
                                Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                            }

                            else    // ANNARS får användaren veta att hen har angett ett ogiltigt val.
                            {
                                Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                                Console.WriteLine("-------------------------------Ogiltigt val-------------------------------");    // Textrad som förklarar felet.
                                Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                            }

                        } while (goBack);   // Programmet återgår till goBack. Om goBack fortfarande är true hamnar man i "Töm"-menyn, annars kommer man till huvudmenyn.
                    }
                }
                // SLUT: TÖM RYGGSÄCKEN ELLER TA UR NÅGOT.
                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/

                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
                // START: AVSLUTA.
                else if (choise == "A" || choise == "a")    // ANNARS OM användaren har skrivit A eller a avslutas programmet.
                {
                    break;  // Avbryter pågående loop, vilket kommer avsluta programmet.
                }
                // SLUT: AVSLUTA.
                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/

                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
                // START: OGILTIGT VAL.
                else    // ANNARS kommer följande meddelande visas.
                {
                    Console.Clear();    // All tidigare text i konsollen rensas för att göra programmet mer lättläst.
                    Console.WriteLine("-------------------------------Ogiltigt val-------------------------------");    // Textrad som förklarar felet.
                    Console.WriteLine("--------------------------------------------------------------------------");    // Endast till för att rama in ovanstående rad.
                }   // Återgår till att visa huvudmenyn.
                // SLUT: OGILTIGT VAL.
                /*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
            }
        }
    }
}