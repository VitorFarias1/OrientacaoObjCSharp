using Exercício_5;
using System;
using System.Globalization;

namespace Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double final = aluno.NotaFinal();

            Console.WriteLine("NOTA FINAL = " + final.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(aluno);            

        }
    }
}
