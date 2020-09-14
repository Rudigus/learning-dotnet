using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;
            while ((linha = Console.ReadLine()) != null)
            {
                linha = "Linha digitada: " + linha;
                Console.WriteLine(linha);
            }
        }
    }
}
