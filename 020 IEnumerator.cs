using System;
using System.Collections; 

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class People : IEnumerable, IEnumerator
    {
        Person[] people;
        int size = -1;
        int index = -1;


        public People(int max_size)
        {
            people = new Person[max_size];
        }

        public void Add(Person per)
        {
            if (++size < people.Length)
                people[size] = per;
        }

        public bool MoveNext()
        {
            return (++index < people.Length);
        }

        public void Reset()
        {
            index = -1;
        }
        public object Current
        {
            get
            {
                return people[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this; 
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            People people = new People(3)
            {
                new Person { Name = "Ali", Age = 22 },
                new Person { Name = "Sundus", Age = 21 },
                new Person { Name = "Hogi", Age = 12 }
            };

            foreach (var item in people)
            {
                Person person = (Person)item;
                Console.WriteLine("Name:{0}, age:{1}", person.Name, person.Age);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
