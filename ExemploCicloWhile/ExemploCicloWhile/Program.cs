using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0;

            do
            {
                Console.WriteLine("Insira um número para somar! Insira 0 para parar");
                num = int.Parse(Console.ReadLine());

                soma += num;
            } while (num != 0);

            /* while (num != 0)
            {
                Console.WriteLine("Insira um número para somar! Insira 0 para parar");
                num = int.Parse(Console.ReadLine());

                soma += num;
            }*/

            Console.WriteLine("A soma de todos os números inseridos é: " + soma);
        }
    }
}
