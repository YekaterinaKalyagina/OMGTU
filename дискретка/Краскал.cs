using System;

namespace KruskalAlgorithm
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

            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        edges.Add(new Edge(i, j, matrix[i, j]));
                    }
                }
            }

            Kruskal(edges, n);
        }

        static void Kruskal(List<Edge> edges, int n)
        {
            edges.Sort();

            DisjointSetSet dsu = new DisjointSetSet(n);

            int mstWeight = 0;
            List<Edge> mst = new List<Edge>();

            foreach (Edge edge in edges)
            {
                int u = edge.V1;
                int v = edge.V2;

                if (dsu.Find(u) != dsu.Find(v))
                {
                    dsu.Union(u, v);
                    mst.Add(edge);
                    mstWeight += edge.Weight;
                }
            }

            Console.WriteLine("Минимальное остовное дерево:");
            foreach (Edge edge in mst)
            {
                Console.WriteLine("(" + (edge.V1 + 1) + ", " + (edge.V2 + 1) + ") " + edge.Weight);
            }
            Console.WriteLine("Вес минимального остовного дерева: " + mstWeight);
        }
    }

    class Edge : IComparable<Edge>
    {
        public int V1 { get; set; }
        public int V2 { get; set; }
        public int Weight { get; set; }

        public Edge(int v1, int v2, int weight)
        {
            V1 = v1;
            V2 = v2;
            Weight = weight;
        }

        public int CompareTo(Edge other)
        {
            return Weight.CompareTo(other.Weight);
        }
    }

    class DisjointSetSet
    {
        public int[] Rank { get; set; }
        public int[] Parent { get; set; }

        public DisjointSetSet(int size)
        {
            Rank = new int[size];
            Parent = new int[size];

            for (int i = 0; i < size; i++)
            {
                Parent[i] = i;
                Rank[i] = 1;
            }
        }

        public int Find(int u)
        {
            if (u != Parent[u])
            {
                Parent[u] = Find(Parent[u]);
            }

            return Parent[u];
        }

        public void Union(int u, int v)
        {
            int uRoot = Find(u);
            int vRoot = Find(v);

            if (uRoot != vRoot)
            {
                if (Rank[uRoot] < Rank[vRoot])
                {
                    Parent[uRoot] = vRoot;
                }
                else if (Rank[uRoot] > Rank[vRoot])
                {
                    Parent[vRoot] = uRoot;
                }
                else
                {
                    Parent[vRoot] = uRoot;
                    Rank[uRoot]++;
                }
            }
        }
    }
}
