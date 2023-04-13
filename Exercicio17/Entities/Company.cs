using System.Globalization;


namespace Exercicio17.Entities
{
    internal class Company : Contributors
    {
        public int EmployeesNumber { get; set; }

        public Company(int employeesNumber, string name, double annualIncome)
            : base (name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Imposto()
        {
            double imposto;
            if (EmployeesNumber > 10)
            {
                imposto = AnnualIncome * 0.14;
            }
            else
            {
                imposto = AnnualIncome * 0.16;
            }
            return imposto;
        }
    }
}
