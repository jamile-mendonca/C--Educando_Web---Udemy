using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ClassesPT4
{     public class Produto1
    {
        private string _nome;
        /* private double _preco;
         private int _quantidade;*/

        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //padrão quando usa private -> _e nome com letra minuscula
        public Produto1()
        {

        }
        public Produto1(string nome, double preco, int quantidade)
        {
            _nome = nome;
            /*  _preco = preco;
              _quantidade = quantidade;*/
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        { if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        } 

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        } */

        /*   public double Preco
           {
               get { return _preco; }
           }

           public int Quantidade
           {
               get { return _quantidade; }
           } */

        public double ValorTotalEmEstoque()
        {
            /*return _preco * _quantidade;*/
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            /*  _quantidade += quantidade;*/
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            /* _quantidade -= quantidade;*/
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            /* return _nome + ", $" + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);*/
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }


