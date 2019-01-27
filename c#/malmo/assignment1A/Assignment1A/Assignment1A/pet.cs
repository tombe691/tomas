//-----------------------------------------------------------------------
// File:    pet.cs
// Summary: program for first assignment, write a class pet.
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-01-15: Created the file, Mats!
//		2019-01-23: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------

using System;

namespace Assignment1A
{
    class Pet
    {
        //class variables
        private string name;
        private int age;
        private bool isFemale;

        //class method to start the application
        public void Start()
        {
            Console.Write("\nGreetings from a Pet object!\n\n");
            ReadAndSavePetData();
            DisplayPetInfo();
        }
        //class method to printe age quwstion (used twice instead of copy paste the code twice
        public void PrintAgeQuestion()
        {
            Console.Write("What is the age of " + name + "? ");
        }
        //class method to get user input and save it
        public void ReadAndSavePetData()
        {
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine();
            PrintAgeQuestion();
            age = 0;

            //check to see if input had correct format
            bool correctAge = false;
            //loop to ask for correct format if not entered correctly
            while (!correctAge)
            {
                string ageStr = Console.ReadLine();
                //tryparse to make sure the user have inputed a number that can be converted to an int
                if (!Int32.TryParse(ageStr, out age))
                {
                    Console.WriteLine("not a number, please try again");
                    PrintAgeQuestion();
                }
                else
                {
                    correctAge = true;
                }
            }
            Console.WriteLine("Is your pet a female (y/n)? ");
            String genderStr = Console.ReadLine();
            //change input to lower case to only have to check once
            genderStr = genderStr.ToLower();
            isFemale = (String.Equals(genderStr, "y") ? true : false);

        }
        //class method to display info on screen
        public void DisplayPetInfo()
        {
            Console.WriteLine("\n+++++++++++++++++++++++++++++");
            Console.WriteLine("Name: " + name + " Age: " + age);
            Console.WriteLine(name+ " is a good " + (isFemale == true ? "girl" : "boy"));
            Console.WriteLine("+++++++++++++++++++++++++++++");

        }
    }
}
