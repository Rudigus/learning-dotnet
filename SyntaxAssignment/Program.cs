using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular a média aritmética de uma determinada quantidade de números");
            Console.Write("\nInforme a quantidade de números: ");
            int quantNumeros = Convert.ToInt32(Console.ReadLine());
            double media = 0;
            Console.Write("\n");
            for (int i = 0; i < quantNumeros; i++) 
            {
                Console.Write($"Informe o {i + 1}º número: ");
                media += Convert.ToDouble(Console.ReadLine()) / quantNumeros;
            }
            Console.WriteLine($"\nA média aritmética dos números informados é, aproximada com duas casas decimais, igual a {media:0.00}");
            if (Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}
