//-----------------------------------------------------------------------
// File:    Circle.cs
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
    public class Circle : Shape
    {
        //declare an instance variable that holds the radius value
        public double radius = 2;
        //method to calculate area
        public double CalculateArea(double radius)
        {
            double area = (radius * radius) * Math.PI;
            return area;
        }
        public override string Display()
        {
            string result = "Circle "+this.xCordinate + " " + this.yCordinate+" Area: "+CalculateArea(this.radius);
            return result;
        }
    }
}
