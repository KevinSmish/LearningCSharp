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
            Dictionary<int,Person> people = new Dictionary<int, Person>();

            people.Add(53, new Person { Name = "Ali", Age = 22 });
            people.Add(11, new Person { Name = "Sundus", Age = 21 });
            people.Add(10, new Person { Name = "Hogi", Age = 12 });

            Console.WriteLine("Total elements in List<T> are {0}", people.Count);
            if (people.ContainsKey(11))
                Console.WriteLine("Element #11 is {0}", people[11].Name);

            Console.WriteLine(new String('-', 30));
            foreach (KeyValuePair<int,Person> person in people)
                Console.WriteLine("Element #{0}: Name {1}, Age {2}", person.Key, person.Value.Name, person.Value.Age);

            Console.WriteLine(new String('-', 30));
            foreach (var item in people.Values)
                Console.WriteLine(item.Name);

            System.Console.ReadKey();
        }
    }
}
