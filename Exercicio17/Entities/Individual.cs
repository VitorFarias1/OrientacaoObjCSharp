using System.Globalization;

namespace Exercicio17.Entities
{
    internal class Individual : Contributors
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double annualIncome)
            : base(name,annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Imposto()
        {
            double imposto, saude = 0;
            if (AnnualIncome < 20000.0)
            {
                imposto = AnnualIncome * 0.15;
            }
            else
            {
                imposto = AnnualIncome * 0.25;
            }
            if (HealthExpenditures > 0)
            {
                saude = HealthExpenditures * 0.5;
            }
            return imposto - saude;
        }
    }
}
