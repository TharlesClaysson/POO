using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Conta
    {
        //declaração de atributos/variáveis da estrutura que viram em LP 2º módulo
        public int numero;
        public string titular;
        public double saldo;

        //declaração dos métodos/funções
        public void Sacar(double valorSaque)
        {
            if (saldo >= valorSaque)
                saldo = saldo - valorSaque;
            else
                Console.WriteLine("Saldo insuficiente");
        }
        public void Depositar(double valorDeposito)
        {   
            if (valorDeposito > 0)
                saldo += valorDeposito;
            else
                Console.WriteLine("Valor do depósito não pode ser negativo");
        }
    }
}
