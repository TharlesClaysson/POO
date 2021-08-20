using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_manhã
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Informe o ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(    Console.ReadLine( )     );
            int idade = 2021 - anoNascimento;
            Console.WriteLine("\nSua idade é " + idade);
            if (idade >= 18)
            {
                Console.WriteLine("Você é");
                Console.WriteLine("Maior de idade");
            }
            else //if (condição)
                Console.WriteLine("Você é menor de idade");
            */
            char mes = 'J';
            switch (mes) // mes == 1
            {
                case 'J':
                    Console.WriteLine("Janeiro");
                    break;
                case '2':
                    Console.WriteLine("Fevereiro");
                    break;
                default: // else
                    Console.WriteLine("Mês inválido... default");
                    break;
            }
            int mess = 5;
            if (mess == 1)
                Console.WriteLine("Janeiro");
            else if (mess == 2)
                Console.WriteLine("Fevereiro");
            else 
                Console.WriteLine("Mês inválido... if");

            Console.WriteLine("\nExemplo do comando for");
            int i;
            for (i = 0; i < 5; i++) // i++ = i = i + 1 incremento
                Console.WriteLine("Valor de i: " + i);

            Console.WriteLine("\nExemplo do comando while");
            i = 0;//incialização
            while (i < 5) //condição de parada, ou critério de parada
            {
                Console.WriteLine("Valor de i: " + i);
                i++; //incremento sempre deve ser implementado na ÚLTIMA LINHA
            }

            Console.WriteLine("\nExemplo do comando do .. while");
            i = 0;//incialização
            do
            {
                Console.WriteLine("Valor de i: " + i);
                i++; //incremento sempre deve ser implementado na ÚLTIMA LINHA
            } while (i < 5);

            Console.WriteLine("\nExemplo do comando while com condição controlada pelo usuário");
            Console.Write("Digite uma idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());//incialização
            int soma = 0;
            i = 0;
            while (idade > 0) //condição de parada, ou critério de parada
            {
                soma += idade;
                i += 1; // i = i + 1     ou     i++
                Console.Write("Digite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());//incialização
            }
            Console.WriteLine("O resultado é = " + soma / i);

            Console.WriteLine("\nExemplo do comando do .. while com condição controlada pelo usuário");
            soma = 0;
            i = 0;
            do  //condição de parada, ou critério de parada
            {
                Console.Write("Digite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());//incialização
                if (idade > 0)
                {
                    soma += idade;
                    i += 1; // i = i + 1     ou     i++
                }                
            } while (idade > 0);
            Console.WriteLine("O resultado é = " + soma / i);

            Console.WriteLine("\nExemplo do comando while com GAMBIARRA");
            i = 0;
            idade = 1; //forçou ter uma idade válida para não ter que digitar uma idade antes do while
            while (idade > 0) //condição de parada, ou critério de parada
            {
                Console.Write("Digite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());//incialização
                if (idade > 0)
                {
                    soma += idade;
                    i += 1; // i = i + 1     ou     i++
                }
            }
            Console.WriteLine("O resultado é = " + soma / i);
            Console.ReadLine();
        }
    }
}
