using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a -= 2;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 4;
            Console.WriteLine(a);
            int b = 100;
            b %= 3; //RESTO DA DIVISÃO
            Console.WriteLine(b);

            string letras = "ABC";
            System.Console.WriteLine(letras += "DEF");

            int number = 1;
            number++;
            System.Console.WriteLine(number);

            number--;
            System.Console.WriteLine(number);

            float a1 = 4.5F;

            double a2 = a1;

            System.Console.WriteLine(a2);

            double a3 = 4.5F;

            float a4 = (float)a3;

            System.Console.WriteLine(a4);

            double a5;
            int a6;
            a5 = 4.1;
            a6 = (int)a5;
            System.Console.WriteLine(a6);


            int c = 5;
            int d = 2;

            double e = (double) c/d;

            System.Console.WriteLine(e);

            
        }
    }
}
