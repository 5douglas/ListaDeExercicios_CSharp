// Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os 
// valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis 
// A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B 
// com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo, 
// devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as 
// multiplicações.


Console.WriteLine("Primeiro valor:");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Segundo valor:");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Terceiro valor:");
int C = int.Parse(Console.ReadLine());

Console.WriteLine("Quarto valor:");
int D = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Valores escolhidos: {A}, {B}, {C}, {D} \n");
Console.WriteLine($"{A} + {B} = {A+B}");
Console.WriteLine($"{A} * {B} = {A*B}");
Console.WriteLine($"{A} + {C} = {A+C}");
Console.WriteLine($"{A} * {C} = {A*C}");
Console.WriteLine($"{A} + {D} = {A+D}");
Console.WriteLine($"{A} * {D} = {A*D}");
Console.WriteLine($"{B} + {C} = {B+C}");
Console.WriteLine($"{B} * {C} = {B*C}");
Console.WriteLine($"{B} + {D} = {B+D}");
Console.WriteLine($"{B} * {D} = {B*D}");
Console.WriteLine($"{C} + {D} = {C+D}");
Console.WriteLine($"{C} * {D} = {C*D}");









