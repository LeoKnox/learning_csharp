using System;

					
public class Program
{
	
	public static void Main()
	{
		Random rnd = new Random();
		for (int i = 0; i < 100; i++)
		{
			int hit = rnd.Next(1, 21);
			int dmg = rnd.Next(1, 9)+2;
			Console.WriteLine("hit: {0}, dmg: {1}", hit, dmg);
		}
	}
}
