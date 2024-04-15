using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          if(10 > 9){
            System.Console.WriteLine("10 > 9 = VERDADEIRO");
          } else if (10 < 9){
            System.Console.WriteLine("10 < 9 = FALSO");
          } else if (10 == 10) {
            System.Console.WriteLine("10 == 10 = VERDADEIRO");
          } else {
            System.Console.WriteLine("SE NÃO");
          }

          if(10 == 9){
            System.Console.WriteLine("10 > 9 = VERDADEIRO");
          } else if (10 < 9){
            System.Console.WriteLine("10 < 9 = FALSO");
          } else if (10 == 10) {
            System.Console.WriteLine("10 == 10 = VERDADEIRO");
          } else {
            System.Console.WriteLine("SE NÃO");
          }

          if(10 == 9){
            System.Console.WriteLine("10 > 9 = VERDADEIRO");
          } else if (10 < 9){
            System.Console.WriteLine("10 < 9 = FALSO");
          } else if (10 > 10) {
            System.Console.WriteLine("10 == 10 = VERDADEIRO");
          } else {
            System.Console.WriteLine("SE NÃO");
          }
        }
    }
}

