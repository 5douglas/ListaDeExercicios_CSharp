// Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
// V = 3.14159 * R * R * A
// Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.

using System;

namespace Ex8
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CALCULADOR DE VOLUME DA LATA DE ÓLEO");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Valor do raio:");
            float raio = float.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine("Valor da altura:");
            float altura = float.Parse(Console.ReadLine());

            Calculador(raio, altura);
            

        }

        static void Calculador(float raio, float altura)
        {
            var volume = 3.14159 * raio * raio * altura;

            Console.Clear();
            Console.WriteLine($"Volume da lata de óleo: {Math.Round(volume, 2)}");

            Console.ReadKey();
            Menu();
        }

    }
}