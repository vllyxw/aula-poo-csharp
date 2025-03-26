using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria t1 = new ContaBancaria(20202, "Victoria");
            t1.Depositar(500);
            t1.Sacar(600);
            t1.Sacar(200);
            t1.ConsultarSaldo();

            Console.ReadKey();
        }
    }
}
