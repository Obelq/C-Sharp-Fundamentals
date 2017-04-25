using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();

            var input = Console.ReadLine().ToCharArray();



            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                switch (currentChar)
                {
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '(':
                        stack.Push(')');
                        break;
                    default:
                        if (currentChar != stack.Pop())
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        break;
                }



            }
            Console.WriteLine("YES");
        }
    }
}
