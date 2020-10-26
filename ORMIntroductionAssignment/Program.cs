using ORMIntroductionAssignment.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ORMIntroductionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContextoLoja())
            {
                Console.WriteLine("Programa que adiciona clientes a um banco de dados\n");
                Console.Write("Informe o nome do cliente: ");
                var nomeCliente = Console.ReadLine();

                var cliente = new Cliente()
                {
                    Nome = nomeCliente
                };

                db.Clientes.Add(cliente);
                db.SaveChanges();

                var query = from c in db.Clientes
                            select c;

                Console.WriteLine("\nIDs e nomes dos clientes: \n");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.ID} | {item.Nome}");
                }

                if (Debugger.IsAttached) 
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
