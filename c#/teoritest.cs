using System;

namespace ConsoleApp6
{
  class Program
  {
    static void Main(string[] args)
    {
      string msg = "test";
      bool villkor = false;
      if (villkor)
	msg = "Všlkommen";
      else
	Console.WriteLine(msg);
    }
  }
}
