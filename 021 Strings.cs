using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clone ----------------------------------------------
            string text = "Ali Asad";
            string cln = (string)text.Clone();
            Console.WriteLine(cln);
            Console.WriteLine(new string('-', 30));
            // CompareTo ------------------------------------------

            string text1 = "Ali";
            string text2 = "Asad";
            if (text1.CompareTo(text2) == 0)
            {
                Console.WriteLine("The same");
            }
            else
            {
                Console.WriteLine("Nothing the same");
            }
            Console.WriteLine(new string('-', 30));
            // StartsWith, EndWith ------------------------------------------
            string text3 = "Ali";
            Console.WriteLine("Is the first symbol of '{0}' 'i'? {1}", text3, text3.StartsWith("i"));
            Console.WriteLine("Is the last symbol of '{0}' 'i'? {1}",text3,text3.EndsWith("i"));
            Console.WriteLine(new string('-', 30));
            // ToLower ------------------------------------------
            string text4 = "Hello, World!";
            Console.WriteLine("Original:{0}", text4);
            Console.WriteLine("ToUpper:{0}", text4.ToUpper());
            Console.WriteLine("ToLower:{0}", text4.ToLower());
            Console.WriteLine(new string('-', 30));
            // IndexOf, LastIndexOf ------------------------------------------
            string text5 = "Ali Asad";
            Console.WriteLine("Original:{0}", text5);
            Console.WriteLine("IndexOf 'A':{0}", text5.IndexOf('A'));
            Console.WriteLine("LastIndexOf 'A':{0}", text5.LastIndexOf('A'));
            Console.WriteLine(new string('-', 30));
            // Insert ------------------------------------------
            string text6 = "12345";
            Console.WriteLine("Original:{0}", text6);
            Console.WriteLine("Insert in position number 3:{0}", text6.Insert(3,"o-la-la"));
            Console.WriteLine(new string('-', 30));
            // Remove ------------------------------------------
            string text7 = "12345";
            Console.WriteLine("Original:{0}", text7);
            Console.WriteLine("Remove from 3 to end:{0}", text7.Remove(3));
            Console.WriteLine(new string('-', 30));
            // Replace ------------------------------------------
            string text8 = "папа";
            Console.WriteLine("Original:{0}", text8);
            Console.WriteLine("Replace 'п' to 'м':{0}", text8.Replace('п','м'));
            Console.WriteLine(new string('-', 30));
            // Split ------------------------------------------
            string text9 = "Ali Asad";
            string[] sub = text9.Split(' ');
            Console.WriteLine("Original:{0}", text9);
            foreach (var item in sub)
                Console.WriteLine(item);
            Console.WriteLine(new string('-', 30));
            // Substring ------------------------------------------
            string text10 = "Ali Asad";
            Console.WriteLine("Original:{0}", text10);
            Console.WriteLine("Substring(2,5):{0}", text10.Substring(2,5));
            Console.WriteLine(new string('-', 30));
            // Trim ------------------------------------------
            string text11 = "             Ali         ";
            Console.WriteLine("Original:{0}", text11);
            Console.WriteLine("TrimEnd:'{0}'", text11.TrimEnd());
            Console.WriteLine("TrimStart:'{0}'", text11.TrimStart());
            Console.WriteLine("Trim:'{0}'", text11.Trim());
            Console.WriteLine(new string('-', 30));
            // Format ------------------------------------------
            string text12 = "Ali";
            int i = 22;
            Console.WriteLine(string.Format("Format string: Name '{0,10}', Age '{1}'", text12, i));

            // Delay.
            Console.ReadKey();
        }

    }
}
