using EntityFrameworkAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EntityFrameworkAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContextoLoja()) 
            {
                Console.WriteLine("Programa que adiciona vendedores a um banco de dados\n");
                Console.Write("Informe o nome do vendedor: ");
                var nomeVendedor = Console.ReadLine();

                var vendedor = new Vendedor()
                {
                    Nome = nomeVendedor
                };

                db.Vendedores.Add(vendedor);
                db.SaveChanges();

                var query = from c in db.Vendedores
                            select c;

                Console.WriteLine("\nIDs e nomes dos vendedores: \n");
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
