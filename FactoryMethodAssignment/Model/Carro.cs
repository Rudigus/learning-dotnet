using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodAssignment.Model
{
    class Carro: Veiculo
    {
        override public void GetTipo() 
        {
            Console.WriteLine("Veículo do tipo Carro");
        }
    }
}
