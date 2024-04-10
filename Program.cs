using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            sbyte x = 127;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;

            x++;
            Console.WriteLine(completo);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            
        }
    }
}
