using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ClassesPT4
{
    //Construtor
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Para utilizar o construtor padrão
        public Produto()
        {
            Quantidade = 10;
        }
        /*  public Produto (string nome, double preco, int quantidade)
                  {
              Nome = nome;
              Preco = preco;
              Quantidade = quantidade;
          }*/

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;//não precisa colocar a quantidade por iniciar com zero
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) { }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}