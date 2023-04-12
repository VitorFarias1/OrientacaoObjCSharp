using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17.Entities
{
    abstract class Contributors
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Contributors()
        {
        }

        protected Contributors(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Imposto();
    }
}
