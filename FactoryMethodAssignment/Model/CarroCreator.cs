﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodAssignment.Model
{
    class CarroCreator: Creator
    {
        public override Veiculo criarVeiculo()
        {
            return new Carro();
        }
    }
}
