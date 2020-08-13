using System;
					
public class Program
{
	public static int sumup(int i)
	{
		int sum = 0;
		while (i > 9)
		{
			sum += i%10;
			i /= 10;
			//Console.WriteLine("i = {0}", i);
		}
		sum += i;
		return(sum);
	}
	public static void Main()
	{
		int[] nums = {3, 13, 32, 51, 124, 2312};
		foreach (int n in nums)
		{
			Console.WriteLine(sumup(n));
		}
	}
}
