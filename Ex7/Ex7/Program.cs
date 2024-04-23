using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba 2 valores e retorne o maior entre eles.

            // ESTRUTURA DE DADOS

            int n1, n2;

            // ALGORITMO

            Console.WriteLine("Insira o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine("O maior é: " + n1);
            else if (n1 < n2)
                Console.WriteLine("O maior é: " + n2);
            else
                Console.WriteLine("São iguais: " + n1);
        }
    }
}
