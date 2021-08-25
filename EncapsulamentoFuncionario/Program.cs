using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Codigo = 1;
            f1.Nome = "Ana";
            f1.Salario = 1100;
            Console.WriteLine("Código do funcionário: " + f1.Codigo);
            Console.WriteLine("Nome do funcionário: " + f1.Nome);
            Console.WriteLine("Salário do funcionário: " + f1.Salario);
            f1.Mostrar();
            if (f1.Salario >= 1100)
                Console.WriteLine("Acima do Salário Mínimo!");
            Console.ReadKey();
        }
    }
}
