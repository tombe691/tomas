using System;
class Program
    {
        class flip
        {
          public static int run(int a)
            {
                Int32 l = 0;
                for (int j = 1; j <= a; j++) {
                     l += a; }
                return l;
            }
     
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write(flip.run(i) + ", ");
               
            };
            Console.ReadKey();
        }
    }
