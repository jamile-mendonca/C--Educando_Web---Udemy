using System.Globalization;

int x1 = 10;
int x2 = 30;

int soma = x1 + x2;

Console.WriteLine($"Soma é igual a {soma}");



Console.WriteLine("Qual a hora atual?");
int hora = int.Parse(Console.ReadLine());

if (hora < 12)
{
    Console.WriteLine("Bom dia!");

}
else if (hora < 18)
{
    Console.WriteLine("Boa tarde!");
}
else
{
    Console.WriteLine("Boa noite");
}

double area = 3.14159 * Math.Pow(2.00, 2.0);
Console.WriteLine($"A = {area:F3}");

int A = 5, B = 6, C = 7, D = 8;
int diferenca = (A * B - C * D);
Console.WriteLine(diferenca);

int funcionario = 25;
int horas = 100;
double valorHora = 5.50;

double salario = horas * valorHora;
Console.WriteLine(funcionario);
Console.WriteLine($"U${salario:F2}");

int codigo1 = 12;
int pecas1 = 1;
double valorUn1 = 5.30;
int codigo2 = 16;
int pecas2 = 2;
double valorUn2 = 5.10;

double valorPagar = (pecas1 * valorUn1) + (pecas2 * valorUn2);
Console.WriteLine($"Valor a Pagar: R$ {valorPagar:F2}");

double A1 = 3.0, B1 = 4.0, C1 = 5.2;

double triangulo = (A1 * C1) / 2;
double circulo = 3.14159 * (Math.Pow(5.2, 2.0));
double trapezio = ((3.0 + 4.0) * 5.2) / 2;
double quadrado = Math.Pow(4.0, 2.0);
double retangulo = 3.0 * 4.0;

Console.WriteLine($"Triangulo {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Circulo {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Trapezio {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Quadrado {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Retangulo {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");


int numero = -10;

if (numero >= 0)
{
    Console.WriteLine("Não Negativo");
}
else
{
    Console.WriteLine("Negativo");
}


int numero1 = int.Parse(Console.ReadLine());

if (numero1 % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Impar");
}

string[] valores = Console.ReadLine().Split(' ');
int A2 = int.Parse(valores[0]);
int B2 = int.Parse(valores[1]);

if (A2 % B2 == 0 || B2 % A2 == 0)
{
    Console.WriteLine("São Múltiplos");
}
else
{
    Console.WriteLine("Não são Múltiplos");
}


string[] horas1 = Console.ReadLine().Split(' ');
int horaInicial = int.Parse(horas1[0]);
int horaFinal = int.Parse(horas1[1]);

int tempoJogo;

if (horaInicial < horaFinal)
{
    tempoJogo = horaFinal - horaInicial;
}
else
{
    tempoJogo = 24 - horaInicial + horaFinal;
}

Console.WriteLine($"O jogo durou {tempoJogo} horas");


string[] valores1 = Console.ReadLine().Split(' ');
int codigo = int.Parse(valores1[0]);
int quantidade = int.Parse(valores1[1]);

double valorPagar1;

if (codigo == 1)
{
    valorPagar1 = quantidade * 4.00;
}
else if (codigo == 2)
{
    valorPagar1 = quantidade * 4.50;
}
else if (codigo == 3)
{
    valorPagar1 = quantidade * 5.00;
}
else if (codigo == 4)
{
    valorPagar1 = quantidade * 2.00;
}
else
{
    valorPagar1 = quantidade * 1.50;
}

Console.WriteLine($"O valor a pagar é R$ {valorPagar1}");

double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (valor < 0 || valor > 100)
{
    Console.WriteLine("Fora de intervalo");
}
else if (valor <= 25)
{
    Console.WriteLine("Intervalo [0,25]");

}
else if (valor <= 50)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (valor <= 75)
{
    Console.WriteLine("Intervalo (50,75]");
}
else
{
    Console.WriteLine("Intervalo (75,100]");
}

string[] valores2 = Console.ReadLine().Split(' ');
double x = double.Parse(valores2[0], CultureInfo.InvariantCulture);
double y = double.Parse(valores2[1], CultureInfo.InvariantCulture);

if (x == 0.0 && y == 0.0)
{
    Console.WriteLine("Origem");
}
else if (x == 0.0)
{
    Console.WriteLine("Eixo y");
}
else if (y == 0.0)
{
    Console.WriteLine("Eixo x");
}
else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}
else if (x < 0.0 && y > 0.0)
{
    Console.WriteLine("Q2");

}
else if (x < 0.0 && y < 0.0)

{
    Console.WriteLine("Q3");
}
else

{
    Console.WriteLine("Q4");
}


double salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double imposto;

if (salario1 < 2000.0)
{
    imposto = 0.0;
}
else if (salario1 < 3000.00)
{
    imposto = (salario1 - 2000.00) * 0.08;
}
else if (salario1 < 4500.00)
{
    imposto = (salario1 - 3000.00) * 0.18 + 1000.00 * 0.08;
}
else
{
    imposto = (salario1 - 4500) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
}

if (imposto == 0)
{
    Console.WriteLine("Isento");
}
else
{
    Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
}