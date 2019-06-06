//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 5, write an application to show random results
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-03-28: Created the file
//		2019-04-10: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------
using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); // create a random object

            int grade; 

            for (int i = 0; i < 10; i++)
            {
                grade = rand.Next(1, 10);// call Next method to create a random grade between 1-9
                Console.Write("Student " + (i + 1) + " has got " + grade + " : ");
                for (int j = 0; j < grade; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tryck ned valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
