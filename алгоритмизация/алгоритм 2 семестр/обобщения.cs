using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим работы:");
            Console.WriteLine("1 - Работа с целыми числами");
            Console.WriteLine("2 - Работа с вещественными числами");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WorkWithIntegers();
                    break;
                case "2":
                    WorkWithDoubles();
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }

        static void WorkWithIntegers()
        {
            MathOperations<int> lala = new MathOperations<int>();
            Console.WriteLine("Введите первое целое число:");
            lala.First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            lala.Second = Convert.ToInt32(Console.ReadLine());

            lala.Add();
            lala.Subtract();
            lala.Multiply();
            lala.Divide();
        }

        static void WorkWithDoubles()
        {
            MathOperations<double> lala = new MathOperations<double>();
            Console.WriteLine("Введите первое вещественное число:");
            lala.First = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе вещественное число:");
            lala.Second = Convert.ToDouble(Console.ReadLine());

            lala.Add();
            lala.Subtract();
            lala.Multiply();
            lala.Divide();
        }
    }

    class MathOperations<T> where T : struct
    {
        public T First { get; set; }
        public T Second { get; set; }

        public void Add()
        {
            dynamic a = First, b = Second;
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtract()
        {
            dynamic a = First, b = Second;
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Multiply()
        {
            dynamic a = First, b = Second;
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public void Divide()
        {
            dynamic a = First, b = Second;
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя.");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
        }
    }
}
