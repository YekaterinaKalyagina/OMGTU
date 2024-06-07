using System;
using System.Collections.Generic;

namespace Programm
{
    class Program
    {
        static bool CheckBrackets(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in expression)
            {
                switch (ch)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(ch);
                        break;

                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return false;
                        break;

                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return false;
                        break;

                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return false;
                        break;
                }
            }

            return stack.Count == 0;
        }

        static bool CheckPolishNotation(string expression)
        {
            Stack<int> stack = new Stack<int>();
            string[] token = expression.Split(' ');

            foreach (string element in token)
            {
                int number;
                if (int.TryParse(element, out number))
                {
                    stack.Push(number);
                }
                else if (element == "+" || element == "-" || element == "*" || element == "/")
                {
                    if (stack.Count < 2)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 1;
        }

        static void PrintMenu()
        {
            Console.WriteLine("номер 1 - проверка скобок на правильность");
            Console.WriteLine("номер 2 - подсчет выражения, записанного в польской записи");
            Console.WriteLine("номер 3 - информация об авторе");
            Console.WriteLine("номер 0 - выход");
            Console.WriteLine("Введите номер варианта, который вы хотите осуществить");
        }

        static void Main(string[] args)
        {
            string otvet = null;

            while (otvet != "0")
            {
                PrintMenu();
                otvet = Console.ReadLine();

                switch (otvet)
                {
                    case "1":
                        Console.WriteLine("Введите строку пожалуйста:)");
                        string a = Console.ReadLine();
                        Console.WriteLine(CheckBrackets(a));
                        break;
                    case "2":
                        Console.WriteLine("введите польскую запись");
                        int count_chars = 0;
                        string str = Console.ReadLine();
                        string[] myStringBuilder = str.Split(" ");
                        Stack<int> values = new Stack<int>();

                        for (int i = 0; i < myStringBuilder.Length; i++)
                        {

                            if (((myStringBuilder[i] != "/") && (myStringBuilder[i] != "*") && (myStringBuilder[i]) != "-") && (myStringBuilder[i] != "+"))
                            {
                                values.Push(Int32.Parse(myStringBuilder[i]));
                                count_chars++;
                            }
                            else
                            {




                                if ((values.Count >= 2))
                                {
                                    int m = values.Pop();
                                    int b = values.Pop();
                                    switch (myStringBuilder[i])
                                    {
                                        case "/":
                                            if (m == 0)
                                            {
                                                Console.WriteLine("а на ноль то делить нельзя");
                                                break;
                                            }
                                            else if (m != 0)
                                            {
                                                values.Push(b / m);

                                            }


                                            break;
                                        case "*":
                                            values.Push((b * m));
                                            break;
                                        case "-":
                                            values.Push(b - m);
                                            break;
                                        case "+":
                                            values.Push(b + m);
                                            break;

                                        default:
                                            values.Push(b);
                                            values.Push(m);
                                            break;


                                    }
                                }



                            }

                        }

                        if ((myStringBuilder.Length - (myStringBuilder.Length - count_chars) - 1 == myStringBuilder.Length - count_chars) && (values.Count != 0))
                        {
                            Console.WriteLine(values.Pop());

                        }
                        else
                        {
                            Console.WriteLine("Неверно введенная польская запись");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Автор программы: Калягина Екатерина");
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}
