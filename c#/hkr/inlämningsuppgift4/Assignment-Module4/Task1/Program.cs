//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 1, write an application create a shape class
//          and subclass circle and cylinder
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-03-28: Created the file
//		2019-04-10: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shape newShape = new Shape();
            string result = newShape.Display();
            Console.WriteLine(result);

            Circle newCircle = new Circle();
            result = newCircle.Display();
            Console.WriteLine(result);

            Cylinder newCylinder = new Cylinder();
            result = newCylinder.Display();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
