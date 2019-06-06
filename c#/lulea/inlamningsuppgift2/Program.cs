//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 2, sales data
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-04-10: Created the file
//		2019-04-16: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Sales
{
    class Program
    {
        //Declare constants to access vector elements.
        private const int NAME = 0;
        private const int SOCIALSECURITYNUMBER = 1;
        private const int DISTRICT = 2;
        private const int NROFITEMSSOLD = 3;
        
        //method to Inputs values for the sales person and returs it as a string vector.
        private static string[] DataInput()
        {
            Console.WriteLine("Namn: ");
            //Create the first element name for the vector 
            string name = Console.ReadLine();
            //Create the second element ssn for the vector 
            Console.WriteLine("Personnummer: ");
            string socialSecurityNumber = Console.ReadLine();
            //Create the third element district for the vector 
            Console.WriteLine("Distrikt");
            string district = Console.ReadLine();
            //Create the fourth element numberofitemssold for the vector 
            Console.WriteLine("Antal sålda artiklar");
            string numberOfItemsSold = Console.ReadLine();
            //int.TryParse(numberOfItemsSold, out int number);    
            //Determine an object Record,
            string[] salesPerson = new string[4] { name, socialSecurityNumber, district, numberOfItemsSold };
            //return vector with created sales person 
            return salesPerson;
        }
        // method to print out each level list
        private static void PrintOutput(List<string[]> myList, string text)
        {
            foreach (string[] value in myList)
            {
                // output same text for screen and file 
                string name = value[0] + "\t\t";
                Console.Write(name);
                using (StreamWriter file = new StreamWriter("export3.txt", true))
                {
                    file.Write(name);
                }
                string ssn = value[1] + "\t\t";
                Console.Write(ssn);
                using (StreamWriter file = new StreamWriter("export3.txt", true))
                {
                    file.Write(ssn);
                }
                string district = value[2] + "\t\t\t";
                Console.Write(district);
                using (StreamWriter file = new StreamWriter("export3.txt", true))
                {
                    file.Write(district);
                }
                string amount = value[3] + "\n";
                Console.Write(amount);
                using (StreamWriter file = new StreamWriter("export3.txt", true))
                {
                    file.WriteLine(amount);
                }
            }
            string text1 = myList.Count+text;
            Console.WriteLine(text1);
            using (StreamWriter file = new StreamWriter("export3.txt", true))
            {
                file.WriteLine(text1);
            }
        }
        //Method that checks if there are values saved in the list and if there are, prints them out, no return data (void)
        private static void PrintOutList(List<string[]> myList)
        {
            List<string[]> level1 = new List<string[]>();
            List<string[]> level2 = new List<string[]>();
            List<string[]> level3 = new List<string[]>();
            List<string[]> level4 = new List<string[]>();

                Console.Clear();
            if (myList.Count == 0)
            {
                string text = "Finns inget att visa.";
                Console.WriteLine(text);
                using (StreamWriter file = new StreamWriter("export3.txt"))
                {
                    file.WriteLine(text);
                }
            }
            else
            //Method for goes through all the list and prints out the vector with elements
            {
                string text = "Namn\t\tPersnr\t\tDistrikt\t\tAntal\n";
                Console.WriteLine(text);
                using (StreamWriter file = new StreamWriter("export3.txt"))
                {
                    file.WriteLine(text);
                }
                //using linq to sort vector by amount
                var result = from person in myList
                    orderby person[NROFITEMSSOLD].Length, person[NROFITEMSSOLD]
                    select person;
                // create new list for each level
                foreach (string[] value in result)
                {
                    string[] salesPerson = new string[4]
                    {
                        value[NAME], value[SOCIALSECURITYNUMBER],
                        value[DISTRICT], value[NROFITEMSSOLD]
                    };
		    int number;
                    int.TryParse(value[NROFITEMSSOLD], out number);
                    if (number < 50)
                    {
                        level1.Add(salesPerson);
                    }
                    else if (number < 100)
                    {
                        level2.Add(salesPerson);
                    }
                    else if (number < 200)
                    {
                        level3.Add(salesPerson);
                    }
                    else if (number > 199)
                    {
                        level4.Add(salesPerson);
                    }
                }
                //print out level data and summary
                PrintOutput(level1, " säljare har nått nivå 1: 0-49 artiklar");
                PrintOutput(level2, " säljare har nått nivå 2: 50-99 artiklar");
                PrintOutput(level3, " säljare har nått nivå 3: 100-199 artiklar");
                PrintOutput(level4, " säljare har nått nivå 4: över 199 artiklar");
            }
        }
       //main method
        static void Main(string[] args)
        {   
            // create list for all sales people
            List<string[]> myList = new List<string[]>();
            // loop 6 times for the sales people
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Mata in säljare nr {0}", i);
                string[] salesPerson = DataInput();
                //Add a new vector in the list
                myList.Add(salesPerson);
            }
            PrintOutList(myList);
        }
    }
}

