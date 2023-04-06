using _3_WhileEFor;
using System.Globalization;

Console.WriteLine("Digite três números: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

double resultado = Class1.Maior(n1, n2, n3);

Console.WriteLine("Maior = " + resultado);

Console.WriteLine("Digite um número: ");
double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

while (x >= 0.0)
{
    double raiz = Math.Sqrt(x);
    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("Digite um número: ");
    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
Console.WriteLine("Número Negativo");

Console.WriteLine("Digite a senha: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Senha Inválida");

    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido");

string[] numero = Console.ReadLine().Split(' ');
int x1 = int.Parse(numero[0]);
int y = int.Parse(numero[1]);

while (x1 != 0 && y != 0)
{
    if (x1 > 0 && y > 0)
    {
        Console.WriteLine("Primeiro");
    }
    else if (x1 < 0 && y > 0)
    {
        Console.WriteLine("Segundo");
    }
    else if (x1 < 0 && y < 0)
    {
        Console.WriteLine("Terceiro");
    }
    else
    {
        Console.WriteLine("Quarto");
    }
    numero = Console.ReadLine().Split(' ');
    x1 = int.Parse(numero[0]);
    y = int.Parse(numero[1]);
}

int alcool = 0;
int gasolina = 0;
int diesel = 0;

int tipo = int.Parse(Console.ReadLine());

while (tipo != 4)
{
    if (tipo == 1)
    {
        alcool = alcool + 1;
    }
    else if (tipo == 2)
    {
        gasolina = gasolina + 1;
    }
    else if (tipo == 3)
    {
        diesel = diesel + 1;
    }
    tipo = int.Parse((Console.ReadLine()));
}
Console.WriteLine("Muito Obrigado");
Console.WriteLine($"Alcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");


Console.Write("Quantos números inteiros você vai digitar?");
int N = int.Parse(Console.ReadLine());

int soma = 0;
for (int i = 1; i <= N; i++)
{
    Console.Write("Valor #{0}:", i);
    int valor = int.Parse(Console.ReadLine());
    soma += valor;
}
Console.WriteLine("Soma =" + soma);

int x2 = int.Parse(Console.ReadLine());

for (int i = 1; i < x2; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

int n = int.Parse(Console.ReadLine());
int cont_in = 0;
int cont_out = 0;

for (int i = 0; i < n; i++)
{
    int x3 = int.Parse(Console.ReadLine());
    if (x3 >= 10 && x3 <= 20)
    {
        cont_in = cont_in + 1;
    }
    else
    {
        cont_out = cont_out + 1;
    }
}
Console.WriteLine(cont_in + "in");
Console.WriteLine(cont_out + "out");


int n4 = int.Parse(Console.ReadLine());



for (int i = 0; i < n4; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

    double media = (2.0 * a + 3.0 * b + 5.0 * c) / 10;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}

int n5 = int.Parse(Console.ReadLine());

for (int i = 0; i < n5; i++)
{
    string[] x3 = Console.ReadLine().Split(' ');
    int a = int.Parse(x3[0]);
    int b = int.Parse(x3[1]);

    if (b == 0)
    {
        Console.WriteLine("Divisão Impossível");
    }
    else
    {
        double divisao = (double)a / b;

        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
    }
}

int n6 = int.Parse(Console.ReadLine());

int fat = 1;
for (int i = 1; i <= n6; i++)
{
    fat = fat * i;
}

Console.WriteLine(fat);


int n7 = int.Parse(Console.ReadLine());

for (int i = 1; i <= n7; i++)
{
    if (n7 % i == 0)
    {
        Console.WriteLine(i);
    }
}


int n8 = int.Parse(Console.ReadLine());

for (int i = 1; i <= n8; i++)
{
    int primeiro = i;
    int segundo = i * i;
    int terceiro = i * i * i;

    Console.WriteLine($"{primeiro} {segundo} {terceiro}");
}
