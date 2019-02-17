using System;

namespace Assignment2A
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            temperatureConverter.Start();
            Console.WriteLine("\nPress enter to exit!");
            Console.ReadKey();
        }
    }
}
