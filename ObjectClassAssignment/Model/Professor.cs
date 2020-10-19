using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassAssignment
{
    class Professor
    {
        public string nome;
        public int numCarteiraTrabalho;
        public decimal salario;

        public void postarConteudo(string descricaoConteudo) 
        {
            Console.WriteLine($"O conteúdo '{descricaoConteudo}' foi postado e disponibilizado com sucesso.");
        }

        public void realizarChamada() 
        {
            Console.WriteLine($"Todos façam silêncio e prestem atenção, a chamada irá começar!");
        }

    }
}
