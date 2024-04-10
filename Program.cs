﻿using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'A';
            char unicode = '\u03b2';
            sbyte x = 127;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Vinicius Quirino"; //IMUTÁVEL
            object obj1 = "Eva"; //GENÉRICOH
            object obj2 = 4.7f;

            double saldo = 10.35785;

            x++;
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(unicode);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.Write(n3);
            Console.Write(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(saldo.ToString("F2")); //QUANTIDADE DE CASAS DECIMAIS
            Console.WriteLine(saldo.ToString("F5", CultureInfo.InvariantCulture)); //FORMATA COM .
        }
    }
}
