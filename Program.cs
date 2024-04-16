using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantos numeros inteiros você vai digitar: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                System.Console.Write($"Valor {i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            System.Console.WriteLine(soma);
        }
    }
}

