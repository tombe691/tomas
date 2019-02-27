using System;

namespace Assignment2A
/// <summary>
/// TemperatureConverter.cs
/// 
/// Created:    By: C# student Tomas Berggren, Feb 2nd 2019
/// Purpose:    This class contains the menu and methods to print and 
/// calculate the conversions between celsius and fahrenheit.
/// </summary>
{
    /// <summary>
    /// The Start method call the menu, read the user choice and call
    /// the function containing the user choose. 
    /// </summary>
    class TemperatureConverter
    {
        public void Start()
        {
            int choice = -1;
            //Loop until the user writes a 0
            while (choice !=0)
            {
                //Display the menu
                WriteMenuText();    
                //Read the user input (0-2)
                choice = Input.ReadIntegerConsole("Your choice: ");
                switch (choice)
                {
                    case 1:
                        CalculateCelsiusToFahrenheit();
                        break;
                    case 2:
                        CalculateFahrenheitToCelsius();
                        break;
                    default:
                        Console.WriteLine("Not a valid choice, please try again");
                        break;
                }
            }
        }
        //class method to get user input and save it
        public void CalculateCelsiusToFahrenheit()
        {
            Console.WriteLine("\n");
            for (double celsius = 0; celsius <= 100; celsius += 5)
            {
                double fahrenheit = CelsiusToFahrenheit(celsius);
                Console.Write($"{celsius,16:N}");
                Console.Write(" C = ");
                Console.Write($"{fahrenheit,6:N}");
                Console.WriteLine(" F");
            }
        }
        //class method to display info on screen
        public void CalculateFahrenheitToCelsius()
        {
            double celsius = 0;
            Console.WriteLine("\n");
            for (double fahrenheit = 0; fahrenheit <= 212; fahrenheit += 4)
            {
                celsius = FahrenheitToCelcius(fahrenheit);
                Console.Write($"{fahrenheit,12:N}");
                Console.Write(" C = ");
                Console.Write($"{celsius,6:N}");
                Console.WriteLine(" F");
            }
        }
        /// <summary>
        /// class method to display Main Menu
        /// </summary>
        public void WriteMenuText()
        {
            Console.Write("\n****************************************");
            Console.Write("\n                   MAIN MENU");
            Console.Write("\n****************************************");
            Console.Write("\n     Convert Fahrenheit to Celcius  : 1");
            Console.Write("\n     Convert Celsius to Fahrenheit  : 2");
            Console.Write("\n     Exit the Converter             : 0");
            Console.Write("\n****************************************\n\n");
        }
        /// <summary>
        /// class method to convert fahrenheit to celsius
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns>celsius</returns>
        public double FahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }
        /// <summary>
        /// class method to convert celsius to fahrenehit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns>fahrenheit</returns>
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8 + 32);
        }
    }
}
