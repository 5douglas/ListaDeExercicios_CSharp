// Escreva um programa que leia um número inteiro e exiba o seu módulo. 
// O módulo de um número x é: 
// x se x é maior ou igual a zero 
// x * (-1) se x é menor que zero



using System;

namespace Ex12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Inicio();
        }

        static void Inicio()
        {
            Console.Clear();
            Console.WriteLine("DESCUBRA O MÓDULO DE UM NÚMERO INTEIRO");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            Calculo(numero);
        }

        static void Calculo(int numero)
        {
            Console.Clear();
            Console.WriteLine("RESULTADO");
            switch(numero){
                case 0: Console.WriteLine($"O módulo do número {numero} é 0."); break;
                case < 0: Console.WriteLine($"O módulo do número {numero} é {numero * -1}"); break;
                default: Console.WriteLine($"O módulo do número {numero} é {numero}"); break;
            }

            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Inicio();
        }
    }
}