using System;
namespace Mathematics
{
    class Square
    {
        int side = 2;

        public int area()
        {
            return (side * side);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square();
            Console.WriteLine(mySquare.area());
        }
    }
}
