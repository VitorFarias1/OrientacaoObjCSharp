﻿using ClassesMetodosToString;
using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.0, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
           
        }
    }
}