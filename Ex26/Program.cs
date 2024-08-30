// Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.

using System;

namespace Ex26
{
    class ListaDeExercicio
    {
        public static void Main(string[] args){

            Inicio();
        }
        private static void Inicio()
        {
            Console.Clear();
            for(int i = 100; i > 0 ; i--){
                Console.WriteLine($"{i}");
            }
        }
    }
}