using System;

/*
A user can define an explicit conversion definition in a type that helps to convert it into another type. Casting
is required to convert a type into another. Data can be lost in explicit conversion.
For explicit conversion, a special static method is defined with an explicit and operator keyword
inside the type definition.
Syntax
Listing 2-25. Define explicit type conversion definition
class MyClass
{
	public static explicit operator returnType(type t)
	{
		//...
	}
}

• returnType tells which type of data would get returned in implicit conversion.
• type t tells which type would get converted implicitly.

*/

class Person
{
	public int Age { get; set; }
	public string Name { get; set; }

	public static explicit operator string (Person per)
	{
		return per.Name;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Person per = new Person { Age = 22, Name = "Ali" };
		string name = (string)per;
		Console.WriteLine(name);
	}
}

//Output
//Ali
