using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pretende-se lendo a base e altura de um triângulo calcular a sua área.
            // area = base * altura / 2

            // ESTRUTURA DE DADOS

            double b, altura, area;

            // ALGORITMO

            Console.WriteLine("Qual o valor da base?");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da altura?");
            altura = double.Parse(Console.ReadLine());

            area = b * altura / 2;

            Console.WriteLine("A área do triângulo é: "+area);

        }
    }
}
