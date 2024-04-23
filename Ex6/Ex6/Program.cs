using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba o valor do quilo de um produto e a
            // quantidade de quilos do produto e retorne o troco a ser dado.

            // ESTRUTURA DE DADOS

            double pKg, quantidade, vPago;

            // ALGORITMO

            Console.WriteLine("Qual o preço do kg do produto?");
            pKg = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos kg comprou?");
            quantidade = double.Parse(Console.ReadLine());

            vPago = pKg * quantidade;

            Console.WriteLine("O valor a pagar é: " + vPago);

        }
    }
}
