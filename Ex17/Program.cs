// Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa 
// entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”. 
// Caso contrário, apresentar a mensagem “valor inválido”.

using System;

namespace Ex17
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

            Console.WriteLine("Número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            Console.Clear();

            if (numero >= 0 && numero <= 9)
            {   
                Console.WriteLine("Número Válido.");
            }
            else
            {
                Console.WriteLine("Número Inválido");
            }

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Aperta qualquer tecla aí");
            Console.ReadKey();
            Inicio();
        }
    }

}