using System;
namespace Program1

{
 public class Program
 {
   static void Main(string[] args)
   {
    int a = 15, b = 5, c = 2, d = 0;

    a = c - d;
    b = f1(b + 5, a);
    c = f2(ref d, b);
    Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
}

   static int f1(int x, int y)
   {
     x++;
     return y + 1;
   }

   static int f2(ref int d, int b)
   {
     d = b;
     return 0;
   }
 }
}
