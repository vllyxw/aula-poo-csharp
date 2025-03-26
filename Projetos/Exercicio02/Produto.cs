using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = 0;
        }

        public void AdicionarEstoque(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            if (this.quantidade >= quantidade)
            {
                this.quantidade -= quantidade;
            }
        }

        public void ExibirProduto()
        {
            Console.WriteLine("Nome do Produto       : " + this.nome);
            Console.WriteLine("Preço                 : " + this.preco);
            Console.WriteLine("Quantidade em estoque : " + this.quantidade);
        }
    }
}
