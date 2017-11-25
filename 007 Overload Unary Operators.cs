using System;

class Distance
{
	public int meter { get; set; }
	public static Distance operator ++ (Distance dis )
	{
		dis.meter += 1;
		return dis;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Distance distance = new Distance() {meter = 5};
		distance++;
		Console.WriteLine(distance.meter);
	}
}
