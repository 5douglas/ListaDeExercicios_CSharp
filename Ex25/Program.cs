//  Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, 
// utilizando as seguintes fórmulas: (h = altura) 
// - Para homens: (72.7*h) - 58 
// - Para mulheres: (62.1 *h) - 44.7

using System;

namespace Ex25{
    class ListaDeExercicio
    {
        public static void Main(string[] args)
        {
            Inicio();
        }

        private static void Inicio()
        {
            string? sexo = null;
            bool verdade = true, aux = false;

            Console.Clear();

            Console.WriteLine("Digite a sua altura:");
            float altura = float.Parse(Console.ReadLine());


            while(verdade){
                if (aux == true){
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Tente novamente!");
                }else{
                    Console.Clear();
                }

                Console.WriteLine("Digite a letra correspondente ao seu sexo:");
                Console.WriteLine("F - Feminio");
                Console.WriteLine("M - Masculino");
                sexo = Console.ReadLine().ToLower();

                if(sexo == "f" || sexo == "m"){
                    verdade = false;
                }else{
                    aux = true;
                }
            }

            Verificacao(altura, sexo);

        }

        private static void Verificacao(float altura, string sexo){
            Console.Clear();
            string aux;
            bool verdade = true, aux2 = false;
            int escolha = 0;

            if(sexo == "f"){
                aux = "Feminino";
            }else{
                aux = "Masculino";
            }

            while(verdade){
                if (aux2 == true){
                    Console.Clear();
                    Console.WriteLine($"Altura: {altura}");
                    Console.WriteLine($"Sexo: {aux}");
                    Console.WriteLine("\nOpção inválida. Tente novamente! <<<<<<<<<<");
                }else{
                    Console.Clear();
                    Console.WriteLine($"Altura: {altura}");
                    Console.WriteLine($"Sexo: {aux}\n");
                }

                Console.WriteLine("As informações estão corretas?");
                Console.WriteLine("1 - Sim (Prosseguir para o cálculo)");
                Console.WriteLine("2 - Não (Corrigir informações)");
                escolha = int.Parse(Console.ReadLine());

                if(escolha == 1 || escolha == 2){
                    verdade = false;
                }else{
                    aux2 = true;
                }
            }
            
            if (escolha == 1){
                Calculo(altura, aux);
            }else{
                Inicio();
            }
        }

        private static void Calculo(float altura, string aux){
            Console.Clear();
            double pesoideal;

            if(aux == "Feminino"){
                pesoideal = (62.1 * altura) - 44.7;
            }else{
                pesoideal = (72.7*altura) - 58;
            }

            Console.WriteLine("INFORMAÇÕES");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine($"Sexo: {aux}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso ideal: {Math.Round(pesoideal,1)}");
            
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao inicio");
            Console.ReadKey();
            Inicio();
        }
    }
}