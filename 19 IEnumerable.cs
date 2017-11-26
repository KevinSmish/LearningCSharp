using System;
using System.Collections; 

namespace ConsoleApp1
{
    class MyArrayList : IEnumerable 
    {
        object[] array = new object[4];
        int index = -1;

        public void Add(object o)
        {
            if (++index < array.Length)
                array[index] = o;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
                yield return array[i]; 
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();

            list.Add("Ali");
            list.Add(22);
            list.Add("Sundus");
            list.Add(21);

            foreach (var item in list)
                Console.WriteLine("{0}",item);

            // Delay.
            Console.ReadKey();
        }
    }
}
