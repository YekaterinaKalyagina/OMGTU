using System;
using System.Collections.Generic;

namespace DijkstraAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Считываем количество вершин и ребер
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            // Создаем список смежности
            Dictionary<int, List<Tuple<int, int>>> graph = new Dictionary<int, List<Tuple<int, int>>>();
            for (int i = 1; i <= n; i++)
            {
                graph.Add(i, new List<Tuple<int, int>>());
            }

            // Считываем ребра и добавляем их в список смежности
            for (int i = 0; i < m; i++)
            {
                int u = int.Parse(Console.ReadLine());
                int v = int.Parse(Console.ReadLine());
                int w = int.Parse(Console.ReadLine());
                graph[u].Add(new Tuple<int, int>(v, w));
                graph[v].Add(new Tuple<int, int>(u, w));
            }

            // Считываем стартовую вершину
            int start = int.Parse(Console.ReadLine());

            // Вызываем функцию Dijkstra и выводим результат
            int[] dist = Dijkstra(graph, start);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {dist[i]}");
            }
        }

        static int[] Dijkstra(Dictionary<int, List<Tuple<int, int>>> graph, int start)
        {
            // Инициализируем массив расстояний и массив посещенных вершин
            int n = graph.Count;
            int[] dist = new int[n + 1];
            bool[] used = new bool[n + 1];
            for (int i = 1; i <= n; i++)
            {
                dist[i] = int.MaxValue;
            }
            dist[start] = 0;

            // Реализуем алгоритм Дейкстры
            for (int i = 0; i < n - 1; i++)
            {
                int v = -1;
                for (int j = 1; j <= n; j++)
                {
                    if (!used[j] && (v == -1 || dist[j] < dist[v]))
                    {
                        v = j;
                    }
                }
                used[v] = true;
                foreach (var edge in graph[v])
                {
                    int to = edge.Item1;
                    int weight = edge.Item2;
                    if (dist[v] + weight < dist[to])
                    {
                        dist[to] = dist[v] + weight;
                    }
                }
            }

            return dist;
        }
    }
}
