using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta[] vetConta = new Conta[3];
            for (int i = 0; i < vetConta.Length; i++)
            {
                vetConta[i] = new Conta();
                Console.Write("Digite o número da conta: ");
                vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o titular da conta: ");
                vetConta[i].titular = Console.ReadLine();
                Console.Write("Digite o saldo da conta: ");
                vetConta[i].saldo = Convert.ToInt32(Console.ReadLine());
            }

            double total = 0;
            Console.WriteLine("\nExemplo com for............................");
            for (int i = 0; i < vetConta.Length; i++)
            {
                vetConta[i].Mostrar();
                total += vetConta[i].saldo;
            }
            Console.WriteLine("\nTOTAL DOS SALDOS: " + total);

            total = 0;
            Console.WriteLine("\nExemplo com for............................");
            foreach (Conta c in vetConta)
            {
                c.Mostrar();
                total += c.saldo;
            }
            Console.WriteLine("\nTOTAL DOS SALDOS: " + total);

            Console.ReadKey();
        }
    }
}
