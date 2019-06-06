//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 4, write an application that calculate and
//          print when population reach 10.000.000.000
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-01-04: Created the file
//		2019-02-06: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double population = 6500000000;
            int year = 2019;

            while (population<10000000000)
            {
                population *= 1.014;
                year++;
            }
            Console.WriteLine(year+" will the population be "+
                Math.Floor(population));
            Console.ReadKey();
        }
    }
}
