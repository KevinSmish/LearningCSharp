using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(22);
            arrayList.Add("Ali");
            arrayList.Add(true);

            for (int i = 0; i < arrayList.Count; i++)
            {
                System.Console.WriteLine(arrayList[i]);
            }

            System.Console.WriteLine(new String('-',30));
            arrayList.Remove(22);

            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }

            System.Console.ReadKey();
        }
    }
}
