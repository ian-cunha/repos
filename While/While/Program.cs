﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void main(string[] args)
        {
            int soma = 0, numero = 0;

            do
            {
                Console.WriteLine("Digite um número (0 para finalizar)");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            } while (numero != 0);

            Console.WriteLine($"Total da soma dos números digitados é: {soma}");
        }
    }
}
