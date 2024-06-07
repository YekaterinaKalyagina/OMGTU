using System;

namespace FordBellmanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вершин в графе:");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Введите матрицу весов графа (в формате 'вес1 вес2 ... весN'). Вводите по строке:");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            Console.WriteLine("Введите номер стартовой вершины:");
            int start = int.Parse(Console.ReadLine()) - 1;

            int[] dist = new int[n];
            bool[] used = new bool[n];

            for (int i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
            }

            dist[start] = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (matrix[j, k] > 0 && dist[j] != int.MaxValue && dist[j] + matrix[j, k] < dist[k])
                        {
                            dist[k] = dist[j] + matrix[j, k];
                        }
                    }
                }
            }

            Console.WriteLine("Кратчайшие расстояния от стартовой вершины до всех остальных:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("(" + (start + 1) + ", " + (i + 1) + ") " + dist[i]);
            }
        }
    }
}
