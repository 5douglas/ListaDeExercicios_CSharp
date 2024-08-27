//  Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o 
// resultado. 

using System;
using System.Runtime.InteropServices;

namespace Ex22
{
    class ListaDeExercicio
    {
        public static void Main(string[] args)
        {
            Inicio();
        }

        private static void Inicio()
        {

            Console.Clear();

            Console.WriteLine("Digite um número:");
            float numero = float.Parse(Console.ReadLine());

            if (numero > 0)
            {
                float A = numero;
                var B = "vazio";

                Console.Clear();
                Console.WriteLine("Número positivo.");
                Console.WriteLine($"Váriavel A: {A} \nVariavel B: {B}");
            
            }else{
                float B = numero;
                var A = "vazio";

                Console.Clear();
                Console.WriteLine("Número negativo.");
                Console.WriteLine($"Váriavel A: {A} \nVariavel B: {B}");
            }

            Console.WriteLine("\n------------------");
            Console.WriteLine("Enter para continuar");
            Console.ReadKey();
            Inicio();
        }
    }
}