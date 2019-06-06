using System;

//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 3, write an application that print  a square
//          
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-02-02: Created the file
//		2019-02-04: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the square (2-16): ");
            bool number = Int32.TryParse(Console.ReadLine(), out int size);

            if (number == false)
            {
                Console.WriteLine("Not a number, exit program");
            }
            else if (size < 2)
            {
                size = 2;
                Console.WriteLine("Size is to small, setting it to minimum size 2");
            }
            else if (size > 16)
            {
                size = 16;
                Console.WriteLine("Size is to big, setting it to maximum size 16");
            }
            else
            {
                //correct value, keeping size
            }

            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
