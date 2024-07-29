Console.WriteLine("Digite o valor da cotação do dólar:");
float cotacao = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Digite um valor em dólares:");
float dolares = Convert.ToSingle(Console.ReadLine());

float reais = dolares * cotacao;

Console.WriteLine($"Cotação: R$ {cotacao} \nDólares: $ {dolares} \nValor em reais: R$ {reais}");