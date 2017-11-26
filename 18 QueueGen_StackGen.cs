using System;
using System.Collections.Generic; 

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var que = new Queue<string>();
            que.Enqueue("Hello");
            string queued = que.Dequeue();
            Console.WriteLine(queued);

            var serials = new Stack<double>();
            serials.Push(1);
            double serialNumber = serials.Pop();
            Console.WriteLine("{0}",serialNumber);

            // Delay.
            Console.ReadKey();
        }
    }
}
