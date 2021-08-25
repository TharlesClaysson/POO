using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    class Aluno
    {
        private int ra;
        private string nome;
        private double p1;
        private double p2;
        private double media;

        public int Ra
        {
            set
            {
                this.ra = value;
            }
            get
            {
                return this.ra;
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
        public double P1
        {
            set
            {
                this.p1 = value;
            }
            get
            {
                return this.p1;
            }
        }

        public double P2
        {
            set
            {
                this.p2 = value;
            }
            get
            {
                return this.p2;
            }
        }

        public double Media
        {
            set
            {
                this.media = value;
            }
            get
            {
                return this.media;
            }
        }

        /*Crie os métodos de encapsulamento de todos os atributos (menbro da classe)
         * Na main crie um vetor de 3 elementos, digite ra, nome, p1, p2, a média deve ser calculada 
         * apresente o vetor na main, sem a função mostrar
         * em outro laço de repetição apresente os alunos aprovados ou reprovaods e seus respectivos nomes e medias */
    }
}
