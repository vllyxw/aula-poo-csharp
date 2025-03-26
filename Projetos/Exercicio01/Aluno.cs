using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class Aluno
    {
        private string nome;
        private int matricula;
        private double nota;


        public Aluno(string nome, int matricula, double nota)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.nota = nota;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Matricula: " + this.matricula);
            Console.WriteLine("Nota: " + this.nota);
        }

        public bool Aprovar()
        {
            if (this.nota < 6)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
