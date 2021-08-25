using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vetProd = new Produto[3];
            double soma_preco_antigo = 0;
            for (int i = 0; i< vetProd.Length; i++)
            {
                vetProd[i] = new Produto();
                Console.Write("DIgite o código do produto:");
                vetProd[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("DIgite o tipo de produto:");
                vetProd[i].descricao = Console.ReadLine();
                Console.Write("DIgite o preço do produto:");
                vetProd[i].preco = Convert.ToInt32(Console.ReadLine());
                soma_preco_antigo += vetProd[i].preco;
            }
            for (int i = 0; i < vetProd.Length; i++)
                vetProd[i].Mostrar();
            double soma_preco_novo = 0;
            Console.Write("\nQual é o percentual de aumento dos produtos?: ");
            double percentual = Convert.ToDouble(Console.ReadLine());
            foreach (Produto p in vetProd)
            {
                p.preco = p.preco + (p.preco * percentual / 100);
                soma_preco_novo += p.preco;
                p.Mostrar();
            }
            double diferenca = soma_preco_novo - soma_preco_antigo;
            Console.WriteLine("\nSoma dos preços antes do aumento: " + soma_preco_antigo);
            Console.WriteLine("Soma dos preços após o aumento: " + soma_preco_novo);
            Console.WriteLine("A diferença entre os preços foi de R$: " + diferenca);
            Console.ReadKey();
        }
    }
}
