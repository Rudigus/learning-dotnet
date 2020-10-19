using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassAssignment
{
    class Aluno
    {
        public string nome;
        public int matricula;
        public string email;

        public void inserirDisciplina(string nomeDisciplina) 
        {
            Console.WriteLine($"Disciplina {nomeDisciplina} inserida com sucesso.");
        }
        public void removerDisciplina(string nomeDisciplina)
        {
            Console.WriteLine($"Disciplina {nomeDisciplina} removida com sucesso.");
        }

        public void realizarMatricula()
        {
            Console.WriteLine("Matrícula realizada com sucesso.");
        }
    }
}
