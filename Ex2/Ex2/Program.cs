using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritmo que após ler dois números inteiros apresenta a sua soma.

            // ESTRUTURA DADOS

            int n1, n2;
            //int soma;

            // ALGORITMO

            Console.WriteLine("Insira o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            //soma = n1 + n2;

            //Console.WriteLine("A soma de "+n1+" + "+n2+" = " + soma);
            Console.WriteLine("A soma de " + n1 + " + " + n2 + " = " + (n1 + n2));
        }
    }
}
