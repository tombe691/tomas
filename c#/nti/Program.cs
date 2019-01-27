using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Är det fint väder? j/n: ");
            string mittSvar = Console.ReadLine();

            if (mittSvar == "j" || mittSvar == "J")
            {
                Console.WriteLine("Vi går på picknick!");
            }

                        Console.ReadLine();
        }
    }
}
