using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Conta
    {
        //declaração de atributos/variáveis da estrutura que viram em LP 2º módulo
        public int numero;
        public string titular;
        public double saldo;

        //declaração dos métodos/funções
        
        public void Mostrar()
        {
            Console.WriteLine("Número: " + numero + "\tTitular:: " + titular + "\tSaldo: " + saldo);
        }

    }
}
