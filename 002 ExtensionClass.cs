using System;

public static class ExtensionClass
{
	public static bool isLessThan(this int origin, int compareValue)
	{
		//return true if origin value is less
		return (origin < compareValue);
	}
}

class MainApp 
{
    public static void Main() 
    {
		string s;
		int age = 22;
		bool check = age.isLessThan(30);
		Console.WriteLine(check);

        Console.WriteLine("Input your name, please!");
        s = Console.ReadLine();
        Console.WriteLine("Hello World using C#, {0}!", s);
		Console.ReadKey();
    }
}

