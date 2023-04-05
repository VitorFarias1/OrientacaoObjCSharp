using System.Diagnostics;
using System.Globalization;


namespace Exercicio6
{
    internal class ConversorDeMoeda
    {
        public static double Dolar;
        public static double Quantidade;
        
        public static double TotalEmDolares()
        {
            return Dolar * Quantidade;
        }
        public static double IOF()
        {
            return TotalEmDolares() * 0.06;
        }
        public static double TotalReais()
        {
            return TotalEmDolares() + IOF();
        }
    }
}
