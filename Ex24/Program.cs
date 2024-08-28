//  Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja 
// realizar: 
// 1 – Verificar se um dos números lidos é ou não múltiplo do outro 
// 2 – Verificar se os dois números lidos são pares 
// 3 – Verificar se a média dos dois números é maior ou igual a 7. 
// 4 – Sair 

using System;

namespace Ex24
{
    class ListaDeExercicio
    {
        public static void Main(string[] args)
        {
            PegarNumeros();
        }

        private static void PegarNumeros()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            int numb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            int numb2 = int.Parse(Console.ReadLine());

            Menu(false, numb1, numb2);
        }

        private static void Menu(bool aux, int numb1, int numb2)
        {
            if(aux == true){
                Console.Clear();
                Console.WriteLine("Opção inválida. Tente novamente!");
            }else{
                Console.Clear();
            }

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números lidos são pares");
            Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha){    
                case 1: Multiplo(numb1, numb2); break;
                case 2: Pares(numb1, numb2); break;
                case 3: Media(numb1, numb2); break;
                case 4: Environment.Exit(0); break;
                default: Menu(true, numb1, numb2); break;
            }
        }

        private static void Multiplo(int numb1, int numb2){
            Console.Clear();

            Console.WriteLine($"Número escolhidos: {numb1}, {numb2}");

            if(numb1 % numb2 == 0){
                Console.WriteLine($"{numb1} é múltiplo de {numb2}.");
            }else{
                Console.WriteLine($"{numb1} não é múltiplo de {numb2}.");
            }

            Retorno();
        }

        private static void Pares(int numb1, int numb2){
            Console.Clear();

            string respostaNumb1, respostaNumb2;

            Console.WriteLine($"Número escolhidos: {numb1}, {numb2}");

            if(numb1 % 2 == 0){
                respostaNumb1 = "par";
            }else{
                respostaNumb1 = "impar";
            }

            if (numb2 % 2 == 0){
                respostaNumb2 = "par";
            }else{
                respostaNumb2 = "impar";
            }

            Console.WriteLine($"\n{numb1} é {respostaNumb1}. \n{numb2} é {respostaNumb2}.");

            Retorno();
        }

        private static void Media(int numb1, int numb2){
            Console.Clear();

            Console.WriteLine($"Número escolhidos: {numb1}, {numb2}");

            int media = (numb1 + numb2) / 2;

            if (media >= 7){
                Console.WriteLine($"\nMédia: {media} \nÉ maior ou igual a 7.");
            }else{
                Console.WriteLine($"\nMédia: {media} \nNão é maior e nem igual a 7.");
            }

            Retorno();
        }

        private static void Retorno(){
            Console.WriteLine("\n------------------------");
            Console.WriteLine("1- Voltar ao inicio do programa");
            Console.WriteLine("2- Encerrar");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha != 1 && escolha != 2){
                Console.Clear();
                Console.WriteLine("Opção inválida. Tente novamente!");
                Retorno();
            }
        
            switch(escolha){
                case 1: PegarNumeros(); break;
                case 2: Environment.Exit(0); break;
            }

        }

    }
}