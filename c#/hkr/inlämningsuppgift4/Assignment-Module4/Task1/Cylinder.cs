//-----------------------------------------------------------------------
// File:    Cylinder.cs
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
    class Cylinder : Shape
    {
        //declare an instance variable that holds the radius value
        public double radius = 2;
        //declare an instance variable that holds the height value
        public double height = 2;
        // method to calculate area
        public double CalculateArea(double radius)
        {
            double area = 2 * Math.PI * radius * (radius + height);
            return area;
        }
        // method to calculate volume
        public double CalculateVolume(double radius, double height)
        {
            double volume = (radius * radius) * Math.PI * height;
            return volume;
        }
        public override string Display()
        {
            string result = "Cylinder " + this.xCordinate + " " + 
                this.yCordinate +" Area: " + CalculateArea(this.radius) + 
                " Volume: " + CalculateVolume(this.radius, this.height);
            return result;
        }
    }
}
