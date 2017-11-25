using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack history = new Stack();

            history.Push("One");
            history.Push("Two");
            history.Push("Three");
            history.Push("Four");

            Console.WriteLine("Total elements in stack are {0}", history.Count);

            Console.WriteLine("Pop (last): {0}", history.Pop());
            Console.WriteLine("Peek (last): {0}", history.Peek());

            Console.WriteLine(new String('-', 30));
            foreach (var item in history)
                Console.WriteLine("Element: {0}", item);

            System.Console.ReadKey();
        }
    }
}
