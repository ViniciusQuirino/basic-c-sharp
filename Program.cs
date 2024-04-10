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
        }
    }
}
