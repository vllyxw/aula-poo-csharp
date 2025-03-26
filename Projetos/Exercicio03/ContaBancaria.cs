using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class ContaBancaria
    {
        private int numeroConta;
        private double saldo;
        private string titular;

        public ContaBancaria(int numero, string dono)
        {
            this.numeroConta = numero;
            this.saldo = 0;
            this.titular = dono;
        }

        public void Depositar(double valor)
        { 
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Numero da Conta :" + this.numeroConta);
            Console.WriteLine("Titular         :" + this.titular);
            Console.WriteLine("Saldo           :" + this.saldo);
        }

    }
 
}