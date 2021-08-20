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
        public bool Sacar(double valorSaque)
        {
            if (saldo >= valorSaque && valorSaque > 0)
            {
                saldo = saldo - valorSaque;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
        }
        public void Depositar(double valorDeposito)
        {   
            if (valorDeposito > 0)
                saldo += valorDeposito;
            else
                Console.WriteLine("Valor do depósito não pode ser negativo");
        }

        public void Transferir(double valor, Conta xuxu)
        {
            saldo = saldo - valor;
            xuxu.saldo += valor;
        }

        public void Transferir1(double valor, Conta xuxu)
        {
            if (Sacar(valor))
                xuxu.Depositar(valor);
        }

        public void Mostrar()
        {
            Console.WriteLine("Número: " + numero + "\tTitular:: " + titular + "\tSaldo: " + saldo);
        }
    }
}
