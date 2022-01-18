using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar?");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagarvalor = Calculadora.ValorAPagar(cotacao, dolar);
            Console.Write("Valor a ser pago em reais: " + pagarvalor.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
