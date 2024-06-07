using System;

namespace PrimAlgorithm
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

            int[] mst = new int[n];
            bool[] used = new bool[n];

            mst[0] = 0;
            used[0] = true;

            for (int i = 1; i < n; i++)
            {
                int minWeight = int.MaxValue;
                int minVertex = -1;

                for (int j = 0; j < n; j++)
                {
                    if (used[j])
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (!used[k] && matrix[j, k] > 0 && matrix[j, k] < minWeight)
                            {
                                minWeight = matrix[j, k];
                                minVertex = k;
                            }
                        }
                    }
                }

                mst[minVertex] = minWeight;
                used[minVertex] = true;
            }

            Console.WriteLine("Минимальное остовное дерево:");
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("(" + (mst[i] / i) + ", " + (mst[i] % i) + ") " + mst[i]);
            }
            Console.WriteLine("Вес минимального остовного дерева: " + mst.Sum(x => x));
        }
    }
}
