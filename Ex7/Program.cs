// Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
// temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
// variável C é a temperatura em graus Celsius

 using System;

 namespace Ex7
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
            Console.WriteLine("CONVERSOR FAHRENHEIT PARA CELSIUS");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Digite os graus em Fahrenheit:");
            float grauF = float.Parse(Console.ReadLine());

            Conversor(grauF);
        }

        static void Conversor(float grauF)
        {
            var convertido = (grauF - 32) * 5 / 9;

            Console.Clear();
            Console.WriteLine($"Graus Fahrenheit: {grauF} °F \nGraus Celsius: {Math.Round(convertido, 2)} °C");
            Console.ReadKey();

            Menu();
        }
    }
 }