// Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes 
// entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 



using System;

namespace Ex10
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
            Console.WriteLine("RELACIONAMENTO ENTRE DOIS NÚMEROS");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Primeiro número:");
            int numb1 = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("RELACIONAMENTO ENTRE DOIS NÚMEROS");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Segundo número:");
            int numb2 = int.Parse(Console.ReadLine());

            Verificacao(numb1, numb2);

            
        }

        static void Verificacao(int numb1, int numb2)
        {
            Console.Clear();
            
            // verificar se são iguais
            if (numb1 == numb2)
            {
                Console.WriteLine("São iguais!");
            }else{
                Console.WriteLine("Não são iguais!");
            }

            // verificar qual é o maior e o menor apenas se os números são diferentes
            if(numb1 != numb2){
                if (numb1 > numb2)
                {
                    Console.WriteLine($"Maior número: {numb1} \nMenor número: {numb2}");
                }else{
                    Console.WriteLine($"Maior número: {numb2} \nMenor número: {numb1}");
                }

                if(numb1 >= numb2){
                    Console.WriteLine($"{numb1} é maior ou igual ao número {numb2}");
                }else{
                    Console.WriteLine($"{numb2} é maior ou igual ao número {numb1}");
                }
                if(numb2 <= numb1){
                    Console.WriteLine($"{numb2} é menor ou igual ao número {numb1}");
                }else{
                    Console.WriteLine($"{numb1} é menor ou igual ao número {numb2}");
                }
            }else{
                Console.WriteLine("Não é maior nem menor, são iguais!");
            }

            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Inicio();

        }
    }
}