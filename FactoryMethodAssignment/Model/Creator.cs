using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodAssignment.Model
{
    abstract class Creator
    {
        public abstract Veiculo criarVeiculo();
    }
}
