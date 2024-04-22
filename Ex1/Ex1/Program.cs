using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. 
             * Crie um algoritmo que lê o nome de uma pessoa e escreve "Olá" 
             * seguido do nome da pessoa. 
             */

            // ESTRUTURA DADOS

            string nome;

            // ALGORITMO

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome);
        }
    }
}
