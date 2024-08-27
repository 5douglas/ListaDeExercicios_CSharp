//  Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é 
// positivo ou negativo. Pare a execução do programa quando o usuário requisitar. 

using System;

namespace Ex21
{
    class ListaDeExercicio
    {
        public static void Main(string[] args)
        {
            Inicio();
        }

        private static void Inicio()
        {   
            int opcao;
            bool aux = true, aux2 = true;

                Console.Clear();
                do{
                    if(aux2){
                        Console.Clear();
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Nova operação");
                        Console.WriteLine("2 - Sair"); 
                        opcao = int.Parse(Console.ReadLine());  
                    }else{
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Tente novamente! Escolha uma opção:");
                        Console.WriteLine("1 - Nova operação");
                        Console.WriteLine("2 - Sair"); 
                        opcao = int.Parse(Console.ReadLine());
                    }
                    if(opcao == 1){
                        aux = false;
                        Calculo();
                    }
                    else if(opcao == 2)
                    {
                        aux = false;
                        EncerrarPrograma();
                    }
                    else{
                        aux2 = false;
                    }

                }while(aux == true);
        }       

        private static void Calculo(){
            int opcao;
            bool aux = true, aux2 = true;

            Console.Clear();
            Console.WriteLine("Digite algum número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Número negativo.");
            }
            else if(numero > 0)
            {
                Console.WriteLine("Número positivo.");
            }
            else{
                Console.WriteLine("Neutro.");
            }

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Inicio();
        }
        private static void EncerrarPrograma(){
                for (int i = 3; i > -1; i--)
                {
                    Console.Clear();
                    Console.WriteLine($"Encerrando o programa... {i}");
                    Thread.Sleep(1000);
                }
                Environment.Exit(0);
        }
    }
}