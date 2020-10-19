using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObjectClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nome = "Arnoldo";
            aluno.matricula = 202012001;
            aluno.email = "arnoldo67@hotmail.com";
            aluno.realizarMatricula();

            Professor professor = new Professor();
            professor.nome = "Anaxágoras";
            professor.numCarteiraTrabalho = 2222222;
            professor.salario = 10000;
            professor.postarConteudo("Como criar um projeto no Multisim");

            Aluno outroAluno = new Aluno();
            outroAluno.nome = "Sérgio";
            outroAluno.matricula = 202009987;
            outroAluno.email = "sergiomalandro@aluno.ifce.edu.br";
            outroAluno.inserirDisciplina("Cálculo II");

            Professor outroProfessor = new Professor();
            outroProfessor.nome = "Geovanni";
            outroProfessor.numCarteiraTrabalho = 0470020;
            outroProfessor.salario = 1500;
            outroProfessor.realizarChamada();

            if (Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}
