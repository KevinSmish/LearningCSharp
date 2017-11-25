using System;

class MainApp 
{
    public static void Main() 
    {
		string[] friend = new string[2];
		string[] friend1 = {"123","456"};
		string s;

		friend[0] = "123";
		friend[1] = "456";
		Console.WriteLine("{0},{1}",friend[0],friend[1]);
		Console.WriteLine("{0},{1}",friend1[0],friend1[1]);

        Console.WriteLine("Input your name, please!");
        s = Console.ReadLine();
        Console.WriteLine("Hello World using C#, {0}!", s);
    }
}

