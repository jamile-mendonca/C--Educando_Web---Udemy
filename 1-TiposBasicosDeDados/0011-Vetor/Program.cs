using System.Globalization;
using _0011_Vetor;

int n = int.Parse(Console.ReadLine());

//[] para indicar que é vetor
/*double[] vect = new double[n];

for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0.0;
for (int i = 0; i < n; i++)
{
    sum+= vect[i];
}

double avg = sum / n;

Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));*/


Product[] vect = new Product[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product { Name = name, Price = price };
}

double sum = 0.0;
for (int i = 0; i < n; i++)
{
    sum += vect[i].Price;
}

double avg = sum / n;

Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));




Estudante[] vect1 = new Estudante[10];

Console.Write("Quantos quartos serão alugados? ");
int n1 = int.Parse(Console.ReadLine());

for (int i = 1; i <= n1; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Aluguel #{i}: ");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    vect1[quarto] = new Estudante(nome, email);
}

Console.WriteLine();
Console.WriteLine("Quartos ocupados: ");
for (int i = 0; i < 10; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine(i + ": " + vect[i]);
    }
}
