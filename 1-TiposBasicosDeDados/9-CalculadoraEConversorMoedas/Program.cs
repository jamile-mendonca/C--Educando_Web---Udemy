using System.Globalization;
using _9_CalculadoraEConversorMoedas;

Console.Write("Qual é a cotação em dólar?: ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar?: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double result = Conversor.DolarParaReal(cotacao, quantia);
Console.Write(@$"Valor a ser pago em reais = R$ {result.ToString("F2", CultureInfo.InvariantCulture)}");
