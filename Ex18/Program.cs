// Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou 
// igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é 
// um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou 
// seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch).

using System;

namespace Ex18
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
            int codigo = int.Parse(Console.ReadLine());

            Console.Clear();
            switch(codigo){
                case 1: Console.WriteLine("Número válido. \nUm"); break;
                case 2: Console.WriteLine("Número válido. \nDois"); break;
                case 3: Console.WriteLine("Número válido. \nTrês"); break;
                default: Console.WriteLine("Número inválido."); break;
            }
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Aperte qualquer tecla aí");
            Console.ReadKey();
            Inicio();

        }
    }
}