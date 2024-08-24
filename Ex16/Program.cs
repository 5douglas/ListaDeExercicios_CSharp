// Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do 
// menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.

using System;

namespace Ex16
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float numb1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo número:");
            float numb2 = float.Parse(Console.ReadLine());

            Console.Clear();

            if (numb1 > numb2){
                Console.WriteLine($"Maior número: {numb1}");
                Console.WriteLine($"Menor número: {numb2}");
            }
            else if(numb2 > numb1){
                Console.WriteLine($"Maior número: {numb2}");
                Console.WriteLine($"Menor número: {numb1}");
            }
            else{
                Console.WriteLine("Os dois números são iguais.");
            }

        }
    }
}