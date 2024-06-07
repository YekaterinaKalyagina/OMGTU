using System;

namespace FloydAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вершин в графе:");
            int n = int.Parse(Console.ReadLine());

            int[,] graph = new int[n, n];

            Console.WriteLine("Введите матрицу смежности графа (используйте -1, чтобы обозначить отсутствие ребра). Вводите по строке:");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    graph[i, j] = int.Parse(input[j]);
                    if (graph[i, j] == -1)
                    {
                        graph[i, j] = int.MaxValue;
                    }
                }
            }

            Floyd(graph);

            Console.WriteLine("Матрица кратчайших расстояний:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (graph[i, j] == int.MaxValue)
                    {
                        Console.Write(" -1 ");
                    }
                    else
                    {
                        Console.Write(" " + graph[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Floyd(int[,] graph)
        {
            int n = graph.GetLength(0);

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (graph[i, k] + graph[k, j] < graph[i, j])
                        {
                            graph[i, j] = graph[i, k] + graph[k, j];
                        }
                    }
                }
            }
        }
    }
}
