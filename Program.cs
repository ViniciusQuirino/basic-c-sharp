using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          bool c1 = 2 > 3 && 4 != 5;
          bool c2 = 2 <= 3 && 4 != 5;
          bool c3 = 2 > 3 || 4 != 5;
          bool c4 = !(2 > 3) && 4 != 5;
          bool c5 = 2 > 3 && 4 == 5;
          System.Console.WriteLine(c1);
          System.Console.WriteLine(c2);
          System.Console.WriteLine(c3);
          System.Console.WriteLine(c4);
          System.Console.WriteLine(c5);
        }
    }
}

