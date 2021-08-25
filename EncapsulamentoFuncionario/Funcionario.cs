using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;
        public int Codigo
        {
            set
            {
                this.codigo = value;
            }
            get
            {
                return this.codigo;
            }
        }
        public string Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        public double Salario
        {
            set
            {
                this.salario = value;
            }
            get
            {
                return this.salario;
            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário: " + salario);
        }

    }
}
