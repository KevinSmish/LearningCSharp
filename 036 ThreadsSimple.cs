using System;
using System.Threading;

namespace ThreadSimple
{
	class Program
	{
        //[ThreadStatic] 
		public static int counter;

		public static void Method()
		{
			if (counter++ < 100)
			{
				Console.WriteLine(counter + " - СТАРТ --- " + Thread.CurrentThread.GetHashCode());
				var thread = new Thread(Method);
				thread.Start();
			    //thread.Join(); // Закомментировать.               
			}
			Console.WriteLine("Поток {0} завершился.", Thread.CurrentThread.GetHashCode());
		}

		static void Main()
		{
			var thread = new Thread(Method);
			thread.Start();
			thread.Join();

			Console.WriteLine("Основной поток завершил работу...");
			
			Console.ReadKey();
		}
	}
}
