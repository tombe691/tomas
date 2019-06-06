//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 5, write an application that prints celcius
//          to farenheit
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-02-06: Created the file
//		2019-02-08: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------
using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = -30.0;
            double fahrenheit;
            Console.WriteLine("Celsius \tFahrenheit!");
            for (int counter = 1; counter < 18; counter++)
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine(celsius+ "\t\t"+fahrenheit);
                celsius+=5;
            }
            Console.ReadKey();
        }
    }
}
