// Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a 
// possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.


using System;

namespace Ex11
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Inicio();
        }

        static void Inicio()
        {
            Alteracao();
        }

        static void Alteracao()
        {
            Console.Clear();
            Console.WriteLine("Valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de B");
            int b = int.Parse(Console.ReadLine());
            
            int c = a;
            a = b;
            b = c;

            Console.Clear();
            Console.WriteLine($"Valor de A: {a} \nValor de B: {b}");

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Inicio();
        }
    }

}