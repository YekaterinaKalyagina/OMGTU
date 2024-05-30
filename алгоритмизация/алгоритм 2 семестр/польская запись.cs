class Program
{
    static int Main(string[] args)
    {

        Stack<int> stack = new Stack<int>();
        Console.WriteLine("Введите выражение в польской обратной записи:");
        string expression;
        expression = Console.ReadLine();
        string[] token = expression.Split(' ');

        foreach (string element in token)
        {
            int a = 0; int b = 0; int number;
            if (int.TryParse(element, out number))
            {
                if (stack.Count > 1)
                {
                    Console.WriteLine("Неверный ввод");
                    Console.ReadKey();
                    return 1;
                }
                else
                {
                    stack.Push(number);
                }
            }
            else if (element == "+" || element == "-" || element == "*" || element == "/")
            {
                switch (element)
                {
                    case "+":
                        if (stack.TryPop(out a))
                        {
                            if (stack.TryPop(out b))
                            {
                                stack.Push(b + a);
                            }
                            else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        }
                        else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        break;
                    case "-":
                        if (stack.TryPop(out a))
                        {
                            if (stack.TryPop(out b))
                            {
                                stack.Push(b - a);
                            }
                            else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        }
                        else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        break;
                    case "*":
                        if (stack.TryPop(out a))
                        {
                            if (stack.TryPop(out b))
                            {
                                stack.Push(b * a);
                            }
                            else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        }
                        else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        break;
                    case "/":
                        if (stack.TryPop(out a))
                        {
                            if (stack.TryPop(out b))
                            {
                                if (a != 0)
                                {
                                    stack.Push(b / a);
                                }
                                else
                                {
                                    Console.WriteLine("Невозможно разделить на 0");
                                    Console.ReadKey();
                                    return 0;
                                }

                            }
                            else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        }
                        else { Console.WriteLine("Недостаточно чисееееееел"); Console.ReadKey(); return 1; }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный Ввод");
                return 1;
            }
        }
        Console.WriteLine(stack.Pop());
        Console.ReadKey();

        return 0;
    }

}
