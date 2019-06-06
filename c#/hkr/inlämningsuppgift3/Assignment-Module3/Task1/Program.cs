using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere newSphere = new Sphere();
            newSphere.SetRadius(2);
            double volume = newSphere.CalculateVolume();

            Console.WriteLine("Hello World! volume is "+ volume);
            Console.ReadKey();

            Sphere newSphere2 = new Sphere(3);
            newSphere2.SetRadius(-2);
            volume = newSphere2.CalculateVolume();

            Console.WriteLine("Hello World! volume is " + volume);
            Console.ReadKey();

        }
    }
}
