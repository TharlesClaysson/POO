using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Console.Write("Informe o código: ");
            f1.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome: ");
            f1.nome =Console.ReadLine();
            Console.Write("Informe o salário: ");
            f1.salario = Convert.ToDouble(Console.ReadLine());

            Funcionario f2 = new Funcionario();
            Console.Write("Informe o código: ");
            f2.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Informe o salário: ");
            f2.salario = Convert.ToDouble(Console.ReadLine());

            double xuxu = f1.salario + f2.salario;
            Console.WriteLine("\nTotal de salários pagos: " + xuxu + "\n");

            f1.Mostrar();
            f2.Mostrar();
            Console.ReadKey();
        }
    }
}
