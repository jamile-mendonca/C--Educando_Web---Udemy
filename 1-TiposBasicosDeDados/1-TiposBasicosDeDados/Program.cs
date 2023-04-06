
using System.Globalization;

int idade = 32;
double saldo = 10.35784;
string nome = "Maria";
//Placeholders
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
//interpolação
Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
//concatenação
Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");



string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade1 = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine($"{produto1}, cujo preço é R${preco1}");
Console.WriteLine($"{produto2}, cujo preço é R${preco2}");

Console.WriteLine($"Registro: {idade1} anos de idade, código {codigo} e gênero {genero}");

Console.WriteLine($"Medida com oito casas decimais: {medida}");
Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

//Báscara

double a = 1.0, b = -3.0, c = -4.0;

double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);

string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

/*string s = Console.ReadLine();

string[] v = s.Split(' ');
string a = v[0];
string b = v[1];
string c = v[2]; */

string[] v = Console.ReadLine().Split(' ');
string a1 = v[0];
string b1= v[1];
string c1 = v[2];

Console.WriteLine("Você digitou: ");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(a1);
Console.WriteLine(b1);
Console.WriteLine(c1);

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(' ');
string nome1 = vet[0];
char sexo = char.Parse(vet[1]);
int idade2 = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome1);
Console.WriteLine(sexo);
Console.WriteLine(idade2);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("Entre com o seu nome completo: ");
string nome2 = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
string[] vet1 = Console.ReadLine().Split(' ');
string sobrenome = vet1[0];
int idade3 = int.Parse(vet1[1]);
double altura1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome2);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(sobrenome);
Console.WriteLine(idade3);
Console.WriteLine(altura1.ToString("F2", CultureInfo.InvariantCulture));