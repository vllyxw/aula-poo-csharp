using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Produto p1 = new Produto("Garrafa", 2.00);
            p1.AdicionarEstoque(10);
            p1.RemoverEstoque(3);
            p1.ExibirProduto();

            Console.ReadKey();
        }
    }
}
