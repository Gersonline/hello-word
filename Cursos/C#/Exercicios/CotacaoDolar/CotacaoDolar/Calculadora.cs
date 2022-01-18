using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    class Calculadora
    {
        static double IOF = 6;

        public static double ValorAPagar(double cotacao, double dolar) 
        {
            return (cotacao * dolar) + ((IOF/100) * (cotacao * dolar));
        }

    }
}
