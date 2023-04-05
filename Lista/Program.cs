using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Joao");
            list.Add("Maria");
            list.Add("Marcos");
            list.Add("Bruno");
            list.Insert(1, "Amanda");

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("O número de elementos na lista é: " + list.Count);

            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("O primeiro nome que começa com M é: " + s1);

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("O último  nome que comaça com M é: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("A posicção do primeiro nome que inicia com M é: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("A posicção do primeiro nome que inicia com M é: " + pos2);

            List<string> lista2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            foreach(string nome in lista2)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------------------------");
            list.RemoveRange(2, 2); //O primeiro número indica a partir de que posição iniciará a remoção e o segundo a quantidade de elementos.
            foreach(string nome in list)
            {
                Console.WriteLine(nome);
            }
        }
    }
}