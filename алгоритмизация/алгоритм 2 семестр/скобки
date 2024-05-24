public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку пожалуйста:)");
        string a = Console.ReadLine();
        Console.WriteLine(CheckBrackets(a));
    }
    public static bool CheckBrackets(string expression)
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
}
