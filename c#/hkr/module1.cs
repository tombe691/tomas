using System;

public class Program
{
    public static void Main(string[] args)
    {
        //        Task1();
        //        Task2();
        //        Task3();
        //        Task4();
        //        Task5();
        Task6();
    }

    public static void Task1()
    {
        string firstString, secondString, concatString;
        Console.WriteLine("Please enter the first string:");
        firstString = Console.ReadLine();
        Console.WriteLine("Please enter the second string:");
        secondString = Console.ReadLine();
        concatString = firstString + " " + secondString;
        Console.WriteLine("The result is: " + concatString);
        Console.WriteLine("Press RETURN to Quit.");
        Console.ReadKey();
        //Here you will write the code for Task1
    }

    public static void Task2()
    {
        int number = GetNumber("Please enter a number!:", true);
        /*string number;
        Console.WriteLine("Please enter a number:");
        number = Console.ReadLine();
        bool res;
        int a;
        res = int.TryParse(number, out a);
        if (!res)
        {
            Console.WriteLine("not a number");
        }
        else
        {*/
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is an even number");
        }
        else
        {
            Console.WriteLine(number + " is an odd number");
        }

        Console.ReadKey();
    }

    public static double GetNumber(string question)
    {
        string number1;
        bool res = false;
        double a = 0;

        while (!res)
        {
            Console.WriteLine(question);
            number1 = Console.ReadLine();
            res = double.TryParse(number1, out a);
            if (!res)
            {
                Console.WriteLine("not a number, try again, only digits");
            }
        }
        return a;
    }

    public static int GetNumber(string question, bool isInt)
    {
        string number1;
        bool res = false;
        int a = 0;

        while (!res)
        {
            Console.WriteLine(question);
            number1 = Console.ReadLine();
            res = int.TryParse(number1, out a);
            if (!res)
            {
                Console.WriteLine("not a number, try again, only digits");
            }
        }
        return a;
    }

    public static void Task3()
    {
        double number1, number2, number3;
        number1 = GetNumber("Enter the first number!");
        number2 = GetNumber("Enter the second number!");
        number3 = GetNumber("Enter the third number!");

        Console.WriteLine(number1 + "\t" + number2 + "\t" + number3);
    }

    public static void Task4()
    {
        Console.WriteLine("TTTTTTT");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("   T     ");
        }
        Console.WriteLine("BBBBBB");
        for (int j = 0; j < 2; j++)
        {
            Console.WriteLine("B     B");
            Console.WriteLine("BBBBBB");
        }
    }

    public static void Task5()
    {
        double number1 = GetNumber("Enter the first number!");
        double number2 = GetNumber("Enter the second number!");

        Console.WriteLine("The sum of xValue with yValue is " + (number1 + number2));
        Console.WriteLine("The difference of xValue with yValue is " + (number1 - number2));
        Console.WriteLine("The product of xValue with yValue is " + (number1 * number2));
        Console.WriteLine("The quotient of xValue with yValue is " + (number1 / number2));
        Console.WriteLine("The remainder of xValue with yValue is " + (number1 % number2));
    }

    public static void Task6()
    {
        int number1 = GetNumber("Enter a radius!:", true);
        double myPi = Math.PI;
        Console.WriteLine("The Diameter of the circle is " + (number1 * 2));
        Console.WriteLine("The Diameter of the circle is " + (number1 * myPi));
    }
}