using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    class PetOwnerMain
    {
        static void Main(string[] args)
        {
            Pet petObj = new Pet();

            petObj.Start();
/*            string name, genderStr;
            int age;
            bool gender;
            Console.Write("\nGreetings from a Pet object!\n\n");
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine();
            Console.Write("What is the age of "+name+"? ");
            age = 0;
            string ageStr = Console.ReadLine();
            if (!Int32.TryParse(ageStr, out age)) {
                Console.Write("not a number");
            }
                
            Console.WriteLine("Is your pet a female (y/n)? ");
            genderStr = Console.ReadLine();
            genderStr = genderStr.ToLower();
            gender = (String.Equals(genderStr, "y") ? true : false);

            Console.WriteLine("\n+++++++++++++++++++++++++++++");
            Console.WriteLine("Name: "+name+"Age: "+age);
            Console.WriteLine("Dilly is a good " + (gender == true ? "girl" : "boy"));
            Console.WriteLine("+++++++++++++++++++++++++++++");
            */
            Console.WriteLine("\nPress enter to exit!");
            Console.ReadKey();
        }
    }
}
