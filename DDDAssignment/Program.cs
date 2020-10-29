using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using System.Diagnostics;

namespace DDDAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Rodrigo", "987654321");
            Conta conta = new Conta(1001, 7495.60f, cliente);
            float valorDeposito = 500f;
            conta.Depositar(valorDeposito);
            Console.WriteLine($"Depósito de {valorDeposito} feito com sucesso.");
            float valorSaque = 10000f;
            bool valorSacado = conta.Sacar(valorSaque);
            if (valorSacado)
            {
                Console.WriteLine($"O valor {valorSaque} foi sacado com sucesso");
            }
            else
            {
                Console.WriteLine($"Fundos insuficientes. Saque de {valorSaque}, porém o saldo é de apenas {conta.saldo}");
            }

            if (Debugger.IsAttached) 
            {
                Console.ReadKey();
            }
        }
    }
}
