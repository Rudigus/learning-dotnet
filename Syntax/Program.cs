using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10.5f;
            float b = 15.5f;

            int c = (int)(a + b);
            int d = (int)a + (int)b;
            Console.WriteLine($"a: {a}\nb: {b}\nc: {c}\nd: {d}");

            string[] professors = {"1", "2"};
            foreach (string professor in professors)
            {
                Console.WriteLine(professor);
            }

            if (Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}
