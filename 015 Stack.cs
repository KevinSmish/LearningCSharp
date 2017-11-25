using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack history = new Stack();

            history.Push("One");									// Push() - добавляет элемент в конец стека.
            history.Push("Two");
            history.Push("Three");
            history.Push("Four");

            Console.WriteLine("Total elements in stack are {0}", history.Count);

            Console.WriteLine("Pop (last): {0}", history.Pop());	// Pop() - возвращает первый элемент стека, удаляя его.
            Console.WriteLine("Peek (last): {0}", history.Peek());	// Peek() - возвращает элемент с вершины стека, не удаляя его.

            Console.WriteLine(new String('-', 30));
            foreach (var item in history)
                Console.WriteLine("Element: {0}", item);

            Console.WriteLine(new String('-', 30));
            // Count - возвращает количество элементов в стеке.
            while (history.Count > 0)
            {
                Console.WriteLine(history.Pop());
            }

            System.Console.ReadKey();
        }
    }
}
