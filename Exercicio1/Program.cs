using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeira, segunda;

            primeira = new Pessoa();
            segunda = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            primeira.nome = Console.ReadLine();
            primeira.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            segunda.nome = Console.ReadLine();
            segunda.idade = int.Parse(Console.ReadLine());

            if (primeira.idade > segunda.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + primeira.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + segunda.nome);
            }
        }
    }
}