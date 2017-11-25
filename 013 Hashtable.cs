using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("Bill", "Microsoft");
            hashtable.Add("Paul", "Microsoft");
            hashtable.Add("Steve", "Apple");
            hashtable.Add("Mark", "Facebook");

            Console.WriteLine("Bill is the owner of {0}", hashtable["Bill"]);

            if (!hashtable.ContainsKey("Trump"))
                hashtable.Add("Trump", "The Trump Organisation");

            Console.WriteLine(new String('-',30));

            foreach (DictionaryEntry item in hashtable)
                Console.WriteLine("{0} is owner of {1}", item.Key, item.Value);

            Console.WriteLine(new String('-', 30));
            var allValues = hashtable.Values;
            foreach (var item in allValues)
                Console.WriteLine("Company: {0}", item);


            System.Console.ReadKey();
        }
    }
}
