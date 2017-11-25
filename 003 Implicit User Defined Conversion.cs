using System;

/*
Implicit User Defined Conversion
A user can define an implicit conversion definition in a type that helps to convert it into another type.
Implicit conversion occurs automatically.
For implicit conversion, a special static method is defined with an implicit and operator keyword
inside the type definition.
Syntax
class MyClass
{
	public static implicit operator returnType(type t)
	{
		//...
	}
}
*/

class Byte
{
	public int bits = 8;
	public static implicit operator int (Byte b)
	{
		return b.bits;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Byte b = new Byte();
		int totalBits = b;
		Console.WriteLine(totalBits);
	}
}
//Output
//8
