using System;
					
public class Program
{
	public static int sumup(int i)
	{
		int sum = 0;
		return(sum);
	}
	public static void Main()
	{
		int[] nums = {3, 13, 32, 51, 124, 2311};
		foreach (int n in nums)
		{
			Console.WriteLine(sumup(n));
		}
	}
}
