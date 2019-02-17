using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2A
{
    class TemperatureConverter
    {
        public void Start()
        {
            int choice = -1;

            while (choice !=0)      //Loop until the user writes a 0
            {
                WriteMenuText();    //Display the menu

                //Read the user input (0-4)
                choice = Input.ReadIntegerConsole();
            }
            Console.Write("\nGreetings from a Temp object!\n\n");
            //DisplayMenu();
            //ReadAndSavePetData();
            //DisplayPetInfo();
        }
        //class method to get user input and save it
        public void CalculateCelciusToFahrenheit()
        {
        }
        //class method to display info on screen
        public void CalculateFahrenheitToCelcius()
        {
        }
        public void CelciusToFahrenheit(double celcius)
        {
        }
        public void WriteMenuText()
        {
            DisplayMenu();
        }
        public void DisplayMenu()
        {
            Console.Write("\n**************************************\n");
            Console.Write("\n                   MAIN MENU\n\n");
            Console.Write("\n**************************************\n");
            Console.Write("\n     Convert Fahrenheit to Celcius  : 1\n");
            Console.Write("\n     Convert Celsius to Fahrenheit  : 2\n");
            Console.Write("\n     Exit the Converter\n\n");
            Console.Write("\n**************************************\n\n");
            Console.Write("\nYour choice:\n\n");

        }
        //class method to display info on screen
        public void FahrenheitToCelcius(double fahrenheit)
        {
        }
    }
}
