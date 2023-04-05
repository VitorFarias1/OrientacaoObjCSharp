using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do Dólar? ");
            double cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ConversorDeMoeda.Dolar = cotDolar;

            Console.Write("Quantos Dólares você vai comprar? ");
            double quantDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ConversorDeMoeda.Quantidade = quantDolar;

            Console.Write("Valor a ser pago em reais " + ConversorDeMoeda.TotalReais().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}