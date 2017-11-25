using System;

class GrandParent
{
	public GrandParent()
	{
		Console.WriteLine("Grand Parent");
	}
}

class Parent : GrandParent
{
	public Parent()
	{
		Console.WriteLine("Parent");
	}
}

class Child : Parent
{
	public Child()
	{
		Console.WriteLine("Child");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Child child = new Child();
	}
}

//Output
//Grand Parent
//Parent
//Child
