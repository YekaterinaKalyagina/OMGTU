using System;
using System.Collections.Generic;
using System.Linq;

namespace Sety
{
    class Program
    {
        static void Main()
        {
            SortedSet<int> set1 = new SortedSet<int>();//создание множеств
            SortedSet<int> set2 = new SortedSet<int>();
            SortedSet<int> set3 = new SortedSet<int>();
            Console.WriteLine("Введите количество элементов 1-го множества: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите {n1} элементов множества: ");
            for (int i = 0; i < n1; i++)
            {
                int element1 = Convert.ToInt32(Console.ReadLine());
                set1.Add(element1);
            }
            Print(set1);
            Console.WriteLine("Введите количество элементов 2-го множества: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите {n2} элементов множества: ");
            for (int i = 0; i < n2; i++)
            {
                int element2 = Convert.ToInt32(Console.ReadLine());
                set2.Add(element2);
            }
            Print(set2);
            Console.WriteLine("Введите количество элементов 3-го множества: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите {n3} элементов множества: ");
            for (int i = 0; i < n3; i++)
            {
                int element3 = Convert.ToInt32(Console.ReadLine());
                set3.Add(element3);
            }
            Print(set3);

            var peresechset12 = set1.Intersect(set2);//возвращение уникальных строк у 1 и 2
            var peresechset123 = peresechset12.Intersect(set3);// а тут уже наше уникальное из 1, 2 и 3
            Console.WriteLine("Пересечение: ");
            foreach (int i in peresechset123)
                Console.Write($"{i} ");

            Console.Write("\n");
            var obedinset12 = set1.Union(set2);//исключение повторяющихся строк
            var obedinset123 = obedinset12.Union(set3);
            Console.WriteLine("Объединение: ");
            foreach (int i in obedinset123)
                Console.Write($"{i} ");
            Console.Write("\n");

            var dopolnenieset1 = obedinset123.Except(set1);//возвращение уникальных строк 
            Console.WriteLine("Дополнение 1 множества: ");
            foreach (int x in dopolnenieset1)
                Console.Write($"{x} ");
            Console.Write("\n");
            var dopolnenieset2 = obedinset123.Except(set2);
            Console.WriteLine("Дополнение 2 множества: ");
            foreach (int x in dopolnenieset2)
                Console.Write($"{x} ");
            Console.Write("\n");
            var dopolnenieset3 = obedinset123.Except(set3);
            Console.WriteLine("Дополнение 3 множества: ");
            foreach (int x in dopolnenieset3)
                Console.Write($"{x} ");
            Console.Write("\n");
        }
        static void Print(SortedSet<int> set)
        {
            foreach (int el in set)
                Console.Write(el + " ");
            Console.WriteLine("\n");
        }

    }

}
