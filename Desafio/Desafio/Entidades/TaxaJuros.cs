using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Entidades
{
    public class TaxaJuros
    {
        private static readonly double _valor = 0.01;

        public static double Valor
        {
            get => _valor;
        }

        public static double CalculaJuros(double valorInicial, int meses)
        {
            return Math.Pow(1 + _valor, meses) * valorInicial;
        }
    }
}
