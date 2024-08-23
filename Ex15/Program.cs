// Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi 
// aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota 
// do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7, 
// apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado, 
// apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do 
// aluno.

using System;

namespace Ex15
{
    class Program 
    { 
        public static void Main(string[] args)
        {
          Inicio();  
        } 

        private static void Inicio()
        {  
            List<float> listadenotas = new List<float>();

            for (var i = 0; i < 4; i++)
            {
                int aux = 1;
                string? numeracao = null;

                switch(aux)
                {
                    case 1: numeracao = "Primeira"; break;
                    case 2: numeracao = "Segunda"; break;
                    case 3: numeracao = "Terceira"; break;
                    case 4: numeracao = "Quarta"; break;
                }

                Console.Clear();
                Console.WriteLine("CALCULADOR DE MÉDIAS");
                Console.WriteLine("--------------------");
                Console.WriteLine($"{numeracao} nota");
                listadenotas.Add(int.Parse(Console.ReadLine()));

                aux++;
            }

            float somaTotalMedias = listadenotas.Sum();
        }
    }
}