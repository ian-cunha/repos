using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que receba um valor que é pago, um segundo
            // valor que é o preço do produto e retorne o troco a ser dado.

            // ESTRUTURA DE DADOS

            double vPago, preco, troco;

            // ALGORITMO

            Console.WriteLine("Qual o preço do produto?");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor pago?");
            vPago = double.Parse(Console.ReadLine());

            troco = vPago - preco;

            if(troco>0)
                Console.WriteLine("O troco é: " + troco);
            else if(troco<0)
                Console.WriteLine("Ainda falta pagar: "+Math.Abs(troco));
            else
                Console.WriteLine("Não há troco");
        }
    }
}
