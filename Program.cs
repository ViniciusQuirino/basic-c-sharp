using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = 10;
           bool c1 = a < 10;
           bool c2 = a < 20;
           bool c3 = a > 10;
           bool c4 = a > 5;
           bool c5 = a == 10;
           bool c6 = a <= 10;
           bool c7 = a >= 10;
           bool c8 = a != 10;

           System.Console.WriteLine(c1);
           System.Console.WriteLine(c2);
           System.Console.WriteLine(c3);
           System.Console.WriteLine(c4);
           System.Console.WriteLine(c5);
           System.Console.WriteLine(c6);
           System.Console.WriteLine(c7);
           System.Console.WriteLine(c8);
        }
    }
}
