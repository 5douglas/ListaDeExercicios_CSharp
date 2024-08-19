// Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.

using System;
using System.Collections.Generic;  // para utilizar as listas

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordenado();
        }

        private static void Ordenado()
        {
            Console.Clear();
            
            List<int> numeros = new List<int>(); //lista para conseguir inserir a entrada do usuario

            Console.WriteLine("ORDEM CRESCENTE DE 3 NÚMEROS INTEIROS");
            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine("Primeiro número");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Segundo número");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Terceiro número:");
            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Sort();
            
            Console.Clear();
            Console.WriteLine("Ordem Crescente");
            Console.WriteLine("---------------");

            foreach(var item in numeros){
                Console.WriteLine(item);
            }

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();

            Ordenado();

        }
    }
}