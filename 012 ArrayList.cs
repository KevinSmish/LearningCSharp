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

            // Добавление в набор групп элементов используя метод AddRange.
            var anArray = new [] { "more", "or", "less" };
            arrayList.AddRange(anArray);

            var anotherArray = new[] { new object(), new ArrayList() };
            arrayList.AddRange(anotherArray);

            // Вставка элементов в заданное положение используя метод Insert.
            arrayList.Insert(3, "Hey All");

            // Вставка элементов в заданное положение используя метод InsertRange.
            var moreString = new[] { "goodnight", "see ya" };
            arrayList.InsertRange(4, moreString);

            // Вставка элементов в заданное положение используя индексатор.
            // (!) При использовании индексатора элемент не вставляется в набор, а перезаписывается прежний объект, бывший в этом элементе.
            arrayList[2] = "Ali (Second)";

            foreach (var item in arrayList)
            {
	            // Never do this!!!
                // arrayList.Remove(item);

                System.Console.WriteLine(item);
            }

            // Удаление из набора одиночных элементов используя метод Remove.
            arrayList.Add("Hello");			// Добавим второе Hello
            arrayList.Remove("Hello");		// Удалим первое Hello
       
            // Удаление из набора одиночных элементов с заданным индексом используя метод RemoveAt.
            arrayList.RemoveAt(0);

            // Удаление из набора, группы элементов с заданным диапазоном используя метод RemoveRange.
            arrayList.RemoveRange(0, 4);

            // Другие методы для добавления и удаления элементов набора - Contains, IndexOf, Clear.
            string myString = "Hello";

            if (arrayList.Contains(myString))
            {
                int index = arrayList.IndexOf(myString);
                arrayList.RemoveAt(index);
            }

            System.Console.WriteLine(new String('-',30));
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }

			arrayList.Clear();
            System.Console.WriteLine(new String('-',30));
            System.Console.WriteLine("Count:{0}",arrayList.Count);

            System.Console.ReadKey();
        }
    }
}
