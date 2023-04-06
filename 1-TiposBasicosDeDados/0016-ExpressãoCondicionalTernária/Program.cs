using System.Globalization;
//Expressão condicional ternária

double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
/*double desconto;
if (preco < 20.0)
{
    desconto = preco * 0.1;
} else
{
    desconto = preco * 0.05;
}

Console.WriteLine(desconto); */

//leitura: se o preço for menor que 20 a expressão vai valer preço * 0.1 caso contrario vai valer preço * 0.05
double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
Console.WriteLine(desconto);