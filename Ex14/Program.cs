// Escreva um programa que leia dois números e apresente a diferença do maior para o menor. 


using System;

namespace Ex14
{
    class Program
    {
        public static void Main(string[] args)
        {
            Inicio();
        }

        private static void Inicio()
        {   
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float numb2 = float.Parse(Console.ReadLine());

            if (numb1 > numb2){
                var diferenca = numb1 - numb2;

                Console.Clear();
                Console.WriteLine($"A diferença entre {numb1} e {numb2} é ({Math.Round(diferenca,2)})");
            }
            else{
                var diferenca = numb2 - numb1;

                Console.Clear();
                Console.WriteLine($"A diferença entre {numb2} e {numb1} é ({Math.Round(diferenca,2)})");
            }

            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Inicio();
        }
    }
}