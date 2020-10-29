using FactoryMethodAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FactoryMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator carroCreator = new CarroCreator();
            Creator motoCreator = new MotoCreator();

            Carro carro = (Carro) carroCreator.criarVeiculo();
            Moto moto = (Moto) motoCreator.criarVeiculo();

            carro.GetTipo();
            moto.GetTipo();

            if(Debugger.IsAttached) 
            {
                Console.ReadKey();
            }


        }
    }
}
