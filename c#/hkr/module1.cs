using System;

public class Program
{
    public static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
    }
    public static void Task1()
    {
        string firstString, secondString, concatString;
        Console.WriteLine("Please enter the first string:");
        firstString = Console.ReadLine();
        Console.WriteLine("Please enter the second string:");
        secondString = Console.ReadLine();
        concatString = firstString + " "+ secondString;
        Console.WriteLine("The result is: "+concatString);
        Console.WriteLine("Press RETURN to Quit.");
        Console.ReadKey();
        //Here you will write the code for Task1
    }
    public static void Task2()
    {
        string number;
        Console.WriteLine("Please enter a number:");
        number = Console.ReadLine();
        bool res;
        int a;
//        string myStr = "12";
        res = int.TryParse(number, out a);
        if (!res)
        {
            Console.WriteLine("not a number");
        }
        else
        {
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is an even number");
            }
            else
            {
                Console.WriteLine(a + " is an odd number");
            }
        }
        Console.ReadKey();
        //Here you will write the code for Task2
    }
    public static void Task3()
    {
        string number;
        Console.WriteLine("Please enter a number:");
        number = Console.ReadLine();
        bool res;
        int a;
        //        string myStr = "12";
        res = int.TryParse(number, out a);
        if (!res)
        {
            Console.WriteLine("not a number");
        }
        else
        { }
            //Here you will write the code for Task2
        }
 }