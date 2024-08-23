// Escreva um programa que leia dois números e apresente a diferença do maior para o menor

using System;

namespace Ex13_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            NaoOrdenada();    
        }

        private static void NaoOrdenada()
        {
            List<int> numeros = new List<int>();
            short aux = 1;
            string? numeracao = null;

            for (int i = 0; i < 3; i++ ){

                Console.Clear();

                switch(aux){
                    case 1: numeracao = "Primeiro"; break;
                    case 2: numeracao = "Segundo"; break;
                    case 3: numeracao = "Terceiro"; break;
                }
                
                Console.WriteLine("NÚMEROS EM ORDEM DECRESCENTE");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{numeracao} número:");
                numeros.Add(int.Parse(Console.ReadLine()));
                aux++;
            }

            numeros.Sort((a,b) => b.CompareTo(a)); // transformar em decrescente a lista

            Console.Clear();
            Console.WriteLine("ORDEM DECRESCENTE");
            Console.WriteLine("-------------------");
            foreach(var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();

            NaoOrdenada();
        }
    }
}