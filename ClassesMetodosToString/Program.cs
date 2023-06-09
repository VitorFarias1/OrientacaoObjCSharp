﻿using ClassesMetodosToString;
using System;
using System.Globalization;

namespace CMToString
{
    class Program
    {
        static void Main(string[] args)
        {            

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     

            Produto p = new Produto();

            Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 500.0,
                Quantidade = 20
            };

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.Write("Dados atualizados: " + p);


            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.Write("Dados atualizados: " + p);


        }
    }
}