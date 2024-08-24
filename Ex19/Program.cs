// Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada 
// lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é 
// eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso 
// contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a 
// ocorrência. 

using System;

namespace Ex19
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

            Console.WriteLine("Lado A:");
            float LadoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Lado B:");
            float LadoB = float.Parse(Console.ReadLine());

            Console.WriteLine("Lado C:");
            float LadoC = float.Parse(Console.ReadLine());

            Console.Clear();
            if(LadoA < (LadoB + LadoC) && LadoB < (LadoA + LadoC) && LadoC < (LadoA + LadoB)){
                if (LadoA == LadoB && LadoB == LadoC)
                {   
                    Console.WriteLine($"Lado A: {LadoA} \nLado B: {LadoB} \nLado C: {LadoC}");
                    Console.WriteLine("É um triângulo equilátero!");
                }
                else if(LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                {
                    Console.WriteLine($"Lado A: {LadoA} \nLado B: {LadoB} \nLado C: {LadoC}");
                    Console.WriteLine("É um triângulo isósceles!");
                }
                else{
                    Console.WriteLine($"Lado A: {LadoA} \nLado B: {LadoB} \nLado C: {LadoC}");
                    Console.WriteLine("É um triângulo escaleno!");
                }

            }
            else
            {
                Console.WriteLine("Pela medidas informadas, isso não é um triângulo!");
            }

            Console.WriteLine("\n------------------");
            Console.WriteLine("Aperte qualquer tecla aí");
            Console.ReadKey();
            Inicio();
        }

    }
}