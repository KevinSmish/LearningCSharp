using System;

class Student
{
	public int mark;
	static public bool operator <(Student st1, Student st2)
	{
		return st1.mark < st2.mark;
	}
	static public bool operator >(Student st1, Student st2)
	{
		return st1.mark > st2.mark;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Student s1 = new Student { mark = 10 };
		Student s2 = new Student { mark = 20 };
		Console.WriteLine(s1<s2);
		Console.WriteLine(s1>s2);
		Console.ReadKey();
	}
}
