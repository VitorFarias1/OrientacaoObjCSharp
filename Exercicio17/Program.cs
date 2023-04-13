using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio17.Entities;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributors> list = new List<Contributors>();

            Console.Write("Enter number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, annualIncome));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(numberEmployees, name, annualIncome));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Contributors contributor in list)
            {
                Console.WriteLine(contributor.Name + ": $ " + 
                contributor.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }
            double sum = 0;
            foreach (Contributors imposto in list)
            {
                sum += imposto.Imposto();                
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}