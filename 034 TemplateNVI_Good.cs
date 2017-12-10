
{
    public class Base
    {
        public void DoWork()
        {
            PreDoWork();
            CoreDoWork();
        }

        void PreDoWork()
        {
            Console.WriteLine("Base.PreDoWork();");
        }

        protected virtual void CoreDoWork()
        {
            Console.WriteLine("Base.DoWork()");
        }
    }

    public class Derived : Base
	{
		protected override void CoreDoWork()
		{
			Console.WriteLine("Derived.DoWork()");
		}
	}

	class Program
	{
		static void Main()
		{
			Base instance = new Derived();
			instance.DoWork();             // = "Derived.DoWork()"

			// Задержка.
			Console.ReadKey();
		}
	}
}
