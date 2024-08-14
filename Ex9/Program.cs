// Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa 
// pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.

using System;

namespace Ex9
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {   
            Anos();
        }

        static void Anos()
        {
            Console.Clear();
            Console.WriteLine("SAIBA OS SEUS DIAS DE VIDA");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Anos:");
            int anos = int.Parse(Console.ReadLine());

            int anosEmDias = anos * 365;
            
            Meses(anosEmDias);

        }

        static void Meses(int anosEmDias)
        {
            Console.Clear();
            Console.WriteLine("SAIBA OS SEUS DIAS DE VIDA");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Meses:");
            int meses = int.Parse(Console.ReadLine());

            int mesesEmDias = meses * 30;

            Calculo(anosEmDias, mesesEmDias);
        }

        static void Calculo(int anosEmDias, int mesesEmDias)
        {
            Console.Clear();
            Console.WriteLine("SAIBA OS SEUS DIAS DE VIDA");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Dias:");
            int dias = int.Parse(Console.ReadLine());

            int resultado = anosEmDias + mesesEmDias + dias;

            Console.Clear();
            Console.WriteLine($"Dias de vida: {resultado}");

            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Aperte enter para continuar");
            Console.ReadKey();
            
            Menu();
        }
    }
}