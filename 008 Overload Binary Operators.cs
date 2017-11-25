using System;

class Student
{
	public int Marks { get; set; }
	// + Operator Overloading Method
	public static Student operator + (Student s1, Student s2)
	{
		Student std = new Student();
		std.Marks = s1.Marks + s2.Marks;
		return std;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Student s1 = new Student { Marks = 10 };
		Student s2 = new Student { Marks = 20 };
		Student s3 = s1 + s2;
		Console.WriteLine(s3.Marks);
		Console.ReadKey();
	}
}
//Output
//30
