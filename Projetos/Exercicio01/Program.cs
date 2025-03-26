using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno ("Ze colmeia", 123, 6.7);

            aluno1.ExibirDados();

            Console.WriteLine(aluno1.Aprovar());

            Console.ReadLine();
        }
    }
}
