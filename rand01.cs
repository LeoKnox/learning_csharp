using System;
					
public class Program
{
	public static void Main()
	{
		var rand = new Random();
		int sum = 0;
		int crit = 0;
		for (int i = 0; i < 1000; i++)
		{
			int x = rand.Next(1,21);
			if (x >= 14)
			{
				int y = rand.Next(1,10);
				sum += y;
				crit += y;
			}
			if (x >= 20)
			{
				int t = rand.Next(1,10);
				sum += t;
				sum += rand.Next(1,10);
				sum += rand.Next(1,10);
				sum += rand.Next(1,10);
				crit += t;
				crit += rand.Next(1,10);
				crit += rand.Next(1,10);
				crit += rand.Next(1,10);
				crit += rand.Next(1,10);
			}
		}
		Console.WriteLine(sum);
		Console.WriteLine(crit);
	}
}
