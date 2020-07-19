using System;
					
public class Program
{
	public static void Main()
	{
		var rand = new Random();
		int sum = 0;
		int crit = 0;
		for (int i = 0; i < 100; i++)
		{
			int x = rand.Next(1,20);
			if (x >= 14)
			{
				sum += rand.Next(1,10);
				crit = sum;
			}
			if (x >= 18)
			{
				crit += rand.Next(1,10);
			}
		}
		Console.WriteLine(sum);
		Console.WriteLine(crit);
	}
}
