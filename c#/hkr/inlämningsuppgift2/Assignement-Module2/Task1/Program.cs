//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 1, write an application that print square
//          and qube
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-01-28: Created the file
//		2019-02-02: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------

using System;

namespace Task1
{
    class Program
    {
        public static int GetNumber(int value)
        {
            return value;
        }
        public static int GetSquare(int value)
        {
            return value * value;
        }
        public static int GetCube(int value)
        {
            return value * value * value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number \tSquare \tCube");
            int value;
            for (value = 1; value < 11; value++)
            {
                Console.WriteLine(GetNumber(value) + "\t" + GetSquare(value) + "\t" + GetCube(value));
            }
            Console.ReadKey();
        }
    }
}
