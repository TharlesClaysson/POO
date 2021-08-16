﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Program
    {
        static void Main(string[] args)
        {// int x
            Conta objetoConta; //declaração de uma variável
            objetoConta = new Conta(); // instanciando o objeto
            objetoConta.numero = 10;
            objetoConta.titular = "Cléo";
            objetoConta.saldo = 500.00;
            Console.WriteLine("Nome do correntista 1: " + objetoConta.titular);

            // outra forma de instanciação de objetos e mais utilizada
            //classe   objeto = alocação de memória     método construtor da classe
            Conta      chuchu = new                     Conta();
            chuchu.numero = 11;
            chuchu.titular = "Lara";
            chuchu.saldo = 300.00;
            Console.WriteLine("Nome do correntista 2: " + chuchu.titular);

            Conta c3 = new Conta();
            c3.numero = 12;
            c3.titular = "Lia";
            c3.saldo = 450.12;
            Console.WriteLine("Nome do correntista 3: " + c3.titular);

            Conta c4 = new Conta();
            Console.Write("Digite o número da conta: ");
            c4.numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            c4.titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            c4.saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual valor deseja sacar? ");
            double x = Convert.ToDouble(Console.ReadLine());
            c4.Sacar(x);
            Console.WriteLine("Nome do correntista 4: " + c4.titular);
            Console.WriteLine("Saldo atualizado após o saque 4: " + c4.saldo);

            Console.Write("Qual valor deseja depositar? ");
            x = Convert.ToDouble(Console.ReadLine());
            c4.Depositar(x);
            Console.WriteLine("Saldo atualizado após o depósito 4: " + c4.saldo);

            Console.ReadKey();
        }
    }
}
