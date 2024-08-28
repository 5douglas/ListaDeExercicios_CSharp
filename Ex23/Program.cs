// Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
// 1 – Adição 
// 2 – Subtração 
// 3 – Multiplicação 
// 4 – Divisão

using System;
using System.Runtime.InteropServices;

namespace Ex23
{
    class ListaDeExercicio
    {
        public static void Main(string[] args)
        {
            Menu(false);
        }

        private static void Menu(bool aux)
        {

            if (aux == true){
                Console.WriteLine("Opção inválida. Tente novamente!");
            }else{
                Console.Clear();
            }

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha){
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 0: Environment.Exit(0); break;
                default: Console.Clear(); Menu(true); break;
            }
        }

        private static void Adicao(){
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {numb1} + {numb2} = {numb1+numb2}");

            Retorno();

        }

        private static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {numb1} - {numb2} = {numb1-numb2}");

            Retorno();
        }

        private static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {numb1} * {numb2} = {numb1*numb2}");

            Retorno();
        }

        private static void Divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            float numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {numb1} / {numb2} = {numb1/numb2}");

            Retorno();
        }

        private static void Retorno()
        {
            int escolha = 0;
            bool aux = true;

            Console.WriteLine("\n------------------------");
            Console.WriteLine("1- Voltar ao menu");
            Console.WriteLine("2- Encerrar");
            while(aux){
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1 || escolha == 2){
                    aux = false;
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Tente novamente!");
                    Retorno();
                }
            }

            switch(escolha){
                case 1: Menu(false); break;
                case 2: Environment.Exit(0); break;
            }
            
        }

    }
}