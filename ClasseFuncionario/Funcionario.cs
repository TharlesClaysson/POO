using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Funcionario
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double salario;

        //declaração de método
        public void Mostrar()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário: " + salario);
        }
    }
}
