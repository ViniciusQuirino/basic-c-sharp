using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ENTRADA DE DADOS
            // string frase = Console.ReadLine();
            // System.Console.WriteLine(frase);

        
            // string[] vet = Console.ReadLine().Split(' ');
            // System.Console.WriteLine(vet[0]);
            // System.Console.WriteLine(vet[1]);

            // int n1 = int.Parse(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine()); //1 caracter
            // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // System.Console.WriteLine(n2.ToString("F2"));

            string [] arr = Console.ReadLine().Split();
            string nome = arr[0];
            int idade = int.Parse(arr[1]);
            char sexo = char.Parse(arr[2]);
            double altura = double.Parse(arr[3]);

            string resultado = $"{nome} {idade} {sexo}";
            resultado.Replace("%", "");

            System.Console.WriteLine(resultado);
        }
    }
}
