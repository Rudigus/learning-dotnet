using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Conta
    {
        public int numero { get; set; }
        public float saldo { get; set; }
        public Cliente cliente { get; set; }

        public Conta(int numero, float saldo, Cliente cliente)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.cliente = cliente;
        }

        public void Depositar(float valor) 
        {
            saldo += valor;
        }

        public bool Sacar(float valor) 
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
