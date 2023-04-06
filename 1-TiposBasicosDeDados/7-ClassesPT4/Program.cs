using _7_ClassesPT4;
using System;
using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto: ");
Console.Write("Nome: ");
//p.Nome = Console.ReadLine();
string nome = Console.ReadLine();
Console.Write("Preço: ");
//p.Preco = double. Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
/*Console.Write("Quantidade: ");
//p.Quantidade = int.Parse(Console.ReadLine());
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco, quantidade);*/
//Produto p = new Produto(nome, preco);

Produto p2 = new Produto();


Produto p3 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 20 };

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int qtde = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qtde);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido do estoque: ");
qtde = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtde);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Produto p4 = new Produto("Tv", 500.00, 10);

/*p.SetNome("TV 4K");
Console.WriteLine(p.GetNome());
Console.WriteLine(p.GetPreco());*/

p4.Nome = ("TV 4K");
Console.WriteLine(p4.Nome);
Console.WriteLine(p4.Preco);