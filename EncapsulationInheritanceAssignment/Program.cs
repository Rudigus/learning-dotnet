using EncapsulationInheritanceAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EncapsulationInheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaJuridica jur = new PessoaJuridica();
            jur.nome = "Pastelaria do Seu João";
            Console.WriteLine(jur.nome);

            PessoaFisica fis = new PessoaFisica();
            fis.telefone = 987654321;
            Console.WriteLine(fis.telefone);

            if (Debugger.IsAttached)
            {
                Console.ReadKey();
            }
        }
    }
}
