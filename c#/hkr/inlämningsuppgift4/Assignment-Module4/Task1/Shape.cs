//-----------------------------------------------------------------------
// File:    Shape.cs
// Summary: program for Task 1, write an application create a shape class
//          and subclass circle and cylinder
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-03-28: Created the file
//		2019-04-10: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------

namespace Task1
{
    public class Shape
    {
        //declare an instance variable that holds the x cordinate value
        public double xCordinate = 2;
        //declare an instance variable that holds the y cordinate value
        public double yCordinate = 2;

        public virtual string Display()
        {
            string result = "Shape " + this.xCordinate + " " +
                this.yCordinate;
            return result;
        }
    }
}
