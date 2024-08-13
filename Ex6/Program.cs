// Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de 
// temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus 
// Fahrenheit e a variável C representa é a temperatura em graus Celsius. 

using System;

namespace Ex6
{
    class Program 
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CONVERSOR CELSIUS PARA FAHRENHEIT");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Digite em Graus Celsius:");
            float grauC = float.Parse(Console.ReadLine());

            Convertor(grauC);
        }

        static void Convertor(float grauC)
        {
            var convertido = (9 * grauC + 160) / 5;

            Console.Clear();
            Console.WriteLine($"Celsius: {grauC} °C \nFahrenheit: {Math.Round(convertido, 2)} °F");
            Console.ReadKey();

            Menu();
        }
    }
}