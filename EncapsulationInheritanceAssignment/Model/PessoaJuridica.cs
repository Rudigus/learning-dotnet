using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritanceAssignment.Model
{
    class PessoaJuridica: Pessoa
    {
        public string cnpj { get; set; }
    }
}
