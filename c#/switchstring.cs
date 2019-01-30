using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsMoth("Ash Pug"));
        Console.WriteLine(IsMoth("Dot Net Perls"));
    }

    static bool IsMoth(string value)
    {
        switch (value)
        {
            case "Atlas Moth":
            case "Beet Armyworm":
            case "Indian Meal Moth":
            case "Ash Pug":
            case "Latticed Heath":
            case "Ribald Wave":
            case "The Streak":
                return true;
            default:
                return false;
        }
    }
}