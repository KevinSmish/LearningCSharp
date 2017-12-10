using System;

namespace NVI
{
	public class BaseClass
	{
	    public virtual void DoWork()
	    {
            Console.WriteLine("Base.DoWork()");
	    }
		// В этот библиотечный класс нельзя ничего добавить, т.к. придется переписывать все классы-наследники
	}

	public sealed class Derived : BaseClass
	{
		// Переопределение виртуального метода.
		public override void DoWork()
		{
			Console.WriteLine("Derived.DoWork()");
		}
	}
	
	class Program
	{
		static void Main()
		{
			BaseClass instance = new Derived();
			instance.DoWork();             // = "Derived.DoWork()"

			// Задержка.
			Console.ReadKey();
		}
	}
}
