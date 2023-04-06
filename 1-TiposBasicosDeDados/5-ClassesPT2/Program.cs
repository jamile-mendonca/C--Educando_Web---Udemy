
using _5_ClassesPT2;
using System.Globalization;

Funcionário f1 = new Funcionário();
Funcionário f2 = new Funcionário();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome:");
f1.Nome = Console.ReadLine();
Console.Write("Salário: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome:");
f2.Nome = Console.ReadLine();
Console.Write("Salário: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (f1.Salario + f2.Salario) / 2.0;
Console.WriteLine("Salário médio =  " + media.ToString("F2", CultureInfo.InvariantCulture));


Funcionário1 f = new Funcionário1();

Console.Write("Nome: ");
f.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.Write("Funcionário: " + f);


Console.WriteLine();
Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcent);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + f);