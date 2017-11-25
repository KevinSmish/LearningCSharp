using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue days = new Queue();

            days.Enqueue("Понедельник");
            days.Enqueue("Вторник");
            days.Enqueue("Среда");
            days.Enqueue("Четверг");
            days.Enqueue("Пятница");
            days.Enqueue("Суббота");
            days.Enqueue("Воскресенье");

            Console.WriteLine("Total elements in queue are {0}", days.Count);

            Console.WriteLine("{0}",days.Dequeue());
            Console.WriteLine("{0}", days.Peek());
            Console.WriteLine("{0}", days.Peek());

            Console.WriteLine(new String('-', 30));
            foreach (var item in days)
                Console.WriteLine("Company: {0}", item);


            System.Console.ReadKey();
        }
    }
}
