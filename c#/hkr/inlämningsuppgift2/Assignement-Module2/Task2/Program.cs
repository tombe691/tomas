//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 2, write an application that print volume
//          from separate method
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-01-29: Created the file
//		2019-02-02: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------
using System;

namespace Task2
{
    class Program
    {
        public static double GetVolume(int radius)
        {
            double vol = 4 * Math.PI * Math.Pow(radius, 3) / 3;
            return vol;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a radius: ");
            Int32.TryParse(Console.ReadLine(), out int radius);
            
            for (int value = 1; value <= radius; value++)
            {
                Console.WriteLine("Sphere’s volume with radius "+value+" is " + GetVolume(value));
            }
            Console.ReadKey();
        }
    }
}
