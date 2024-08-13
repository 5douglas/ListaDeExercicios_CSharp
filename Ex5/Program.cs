// Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 
// 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. 
// Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. 
// Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a 
// fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, 
// tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais


Console.Clear();

Console.WriteLine("Tempo gasto na viagem (em horas):");
float Tempo = float.Parse(Console.ReadLine());

Console.WriteLine("Velocidade média:");
float Velocidade = float.Parse(Console.ReadLine());

float Distancia = Tempo * Velocidade;

float LitrosUsados = Distancia / 12;

Console.Clear();
Console.WriteLine($"Valocidade média: {Velocidade} km/h");
Console.WriteLine($"Tempo gasto: {Tempo} horas");
Console.WriteLine($"Distância percorrida: {Distancia} km");
Console.WriteLine($"Litros utilizados na viagem: {Math.Round(LitrosUsados)} litros");