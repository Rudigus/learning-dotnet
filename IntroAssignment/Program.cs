using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa para realizar a soma de dois números\n\nInforme o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nA soma de {n1} e {n2} é {n1 + n2}.\n");
            if(Debugger.IsAttached)
            {
                Console.WriteLine("Pressione qualquer tecla para encerrar o programa...");
                Console.ReadKey();
            }
            
        }
    }
}
