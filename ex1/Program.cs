float quantMin = 0, quantMax = 0, medio = 0;

 Console.WriteLine("ESTOQUE MÈDIO");

 Console.WriteLine("Digite a quantidade mínima: ");
quantMin = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Digite a quantidade máxima");
quantMax = Convert.ToSingle(Console.ReadLine());

medio = (quantMin + quantMax) / 2;

Console.WriteLine($"Resultado: {medio}");

