using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_отгадай_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                switch (s[0])
                {
                    case "+":
                        if (s[1] == "x")
                        {
                            x += 1;
                            break;
                        }
                        else
                        {
                            z += Convert.ToInt32(s[1]);
                            break;
                        }
                    case "-":
                        if (s[1] == "x")
                        {
                            x -= 1;
                            break;
                        }
                        else
                        {
                            z -= Convert.ToInt32(s[1]);
                            break;
                        }
                    case "*":
                        z *= Convert.ToInt32(s[1]);
                        x *= Convert.ToInt32(s[1]);
                        break;
                }
            }
            int R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((R - z) / x);
            Console.ReadKey();

        }
    }
}
