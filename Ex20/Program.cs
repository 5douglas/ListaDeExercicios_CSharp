// Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada 
// variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido 
// multiplicado pelo maior e o maior valor dividido pelo menor.

using System;
using System.Threading.Tasks;

namespace Ex20
{
    class ListaDeExercicio
    {
        public static void Main(string[] args)
        {
            Inicio();
        }

        private static void Inicio()
        {
            int letraA = 0, letraB = 0 , letraC = 0;
            
            PrimeiroValor(ref letraA);
            SegundoValor(ref letraB);
            TerceiroValor(ref letraC);
            Calculo(letraA, letraB, letraC);
        }

        // pegar e verificar primeiro numero
        private static void PrimeiroValor(ref int letraA){
            Console.Clear();

            Console.WriteLine("MENOR * MAIOR - MAIOR / MENOR");
            Console.WriteLine("-----------------------------");

            do{
                Console.WriteLine("Primeiro número:");
                letraA = int.Parse(Console.ReadLine());

                if (letraA <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Número inválido. Tente novamente:");
                    Console.WriteLine("---------------------------------");
                }
            }while(letraA <= 0);
        }

        // pegar e verificar segundo numero
        private static void SegundoValor(ref int letraB){
            Console.Clear();

            Console.WriteLine("MENOR * MAIOR - MAIOR / MENOR");
            Console.WriteLine("-----------------------------");

            do{
                Console.Clear();

                Console.WriteLine("MENOR * MAIOR - MAIOR / MENOR");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Segundo número:");
                letraB = int.Parse(Console.ReadLine());

                if (letraB <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Número inválido. Tente novamente:");
                    Console.WriteLine("---------------------------------");
                }
            }while(letraB <= 0);
        }

        //pegar e verificar terceiro numero
        private static void TerceiroValor(ref int letraC){
            Console.Clear();

            Console.WriteLine("MENOR * MAIOR - MAIOR / MENOR");
            Console.WriteLine("-----------------------------");
            do{
                Console.WriteLine("Terceiro número:");
                letraC = int.Parse(Console.ReadLine());

                if (letraC <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Número inválido. Tente novamente:");
                    Console.WriteLine("---------------------------------");
                }

            }while(letraC <= 0);
        }

        //calculo
        private static void Calculo(int letraA, int letraB, int letraC){
            Console.Clear();

            int maior = Math.Max(letraA, Math.Max(letraB, letraC));
            int menor = Math.Max(letraA, Math.Min(letraB, letraC));
            int meio = (letraA + letraB + letraC) - (menor + maior);

            Console.WriteLine($"Número escolhidos: maior: {maior} , menor: {menor} , meio: {meio}");

            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine($"Multiplicação: {menor} * {maior} = {menor*maior}");
            Console.WriteLine($"Divisão: {maior} / {menor} = {maior/menor}");

            Retorno();
        }

        //loop do programa
        private static void Retorno()
        {
            string escolha;
            bool aux2 = false;
            
            Console.WriteLine("\n");
            do{
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Novo calculo? S = sim ou N = não");
                escolha = (Console.ReadLine()).ToLower();

                if (escolha == "s" || escolha == "n"){
                    aux2 = true;
                }
                else{
                    LimparLinha(4);
                    Console.WriteLine("Opção inválida. Tente novamente!");
                }
            }while(aux2 == false);

            if(escolha == "s"){
                
                Inicio();

            }else{

                for (int i = 3; i > -1; i--)
                {
                    Console.Clear();
                    Console.WriteLine($"Encerrando o programa em... {i}");
                    Thread.Sleep(1000);
                }

                Environment.Exit(0);
            }
    
        }
        
        // limpar linhas (com ajuda do chatgpt)
        private static void LimparLinha(int numLinhas)
        {
            // Move o cursor para a linha que você deseja começar a limpar
            Console.SetCursorPosition(0, Console.CursorTop - numLinhas);

            // Limpa as linhas
            for (int i = 0; i < numLinhas; i++)
            {
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop + 1);
            }

            // Move o cursor de volta para a linha original
            Console.SetCursorPosition(0, Console.CursorTop - numLinhas);
        }
    }
}