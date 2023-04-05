using System.Globalization;


namespace Exercicio7
{
    internal class Conta
    {
        public int Numero { get; private set;}
        public string Titular { get; set;}
        public double Saldo { get; private set;}
        

      
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
           
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero,titular)
        {
            ValorDeposito(depositoInicial);
        }
        public void ValorDeposito(double deposito)
        {
            Saldo += deposito;
        }

        public void ValorSaque(double saque)
        {
            Saldo -= saque;
            Saldo -= 5.0;
        }
        public override string ToString()
        {
            return "Conta " + Numero + " , Titular: " + Titular + " , Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
