using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int linhas = int.Parse(vet[0]);
            int colunas = int.Parse(vet[1]);

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            int elemento = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (elemento == mat[i, j])
                    {
                        Console.WriteLine("Position: " + i + ", " + j + " :");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < colunas - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < linhas - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}