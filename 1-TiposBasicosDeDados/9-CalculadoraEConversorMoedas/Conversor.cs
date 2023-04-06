using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CalculadoraEConversorMoedas
{
    public static class Conversor
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double qtde, double cotacao)
        {
            double total = qtde * cotacao;
            return total + total * Iof / 100.0;
        }

    }
}
