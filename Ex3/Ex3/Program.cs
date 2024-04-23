using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritmo que após ler dois números inteiros apresenta sua diferença.

            // ESTRUTURA DE DADOS

            int n1, n2;
            // int dif;

            // ALGORITMO

            Console.WriteLine("Insira o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            n2 = int.Parse(Console.ReadLine());

            //dif = n1 = n2;

            Console.WriteLine("A diferença de " + n1 + " e " + n2 + " é " + (n1 - n2));
        }
    }
}
