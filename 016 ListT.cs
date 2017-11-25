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
            List<Person> people = new List<Person>();

            people.Add(new Person { Name = "Ali", Age = 22 });
            people.Add(new Person { Name = "Sundus", Age = 21 });
            people.Add(new Person { Name = "Hogi", Age = 12 });

            Console.WriteLine("Total elements in List<T> are {0}", people.Count);

            Console.WriteLine(new String('-', 30));
            foreach (var person in people)
                Console.WriteLine("Name {0}, Age {1}", person.Name, person.Age);

            List<int> marks = new List<int>
            {
                10,
                25,
                15,
                23
            };

            marks.Remove(25);
            Console.WriteLine(new String('-', 30));
            for (int i=0;i<marks.Count;i++)
                Console.Write(marks[i] + " ");
            Console.WriteLine();

            System.Console.ReadKey();
        }
    }
}
