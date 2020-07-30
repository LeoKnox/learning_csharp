using System;
					
public class Program
{
	static int SumDigit(int digit)
	{
		int sum = 0;
		sum += digit%10;
		sum += digit/10;
		return sum;
	}
	public static void Main()
	{
		int[] info = { 99, 41, 14, 32, 22, 31, 23, 67, 43, 25,73,22,87,32,11,44};
		int total = 0;
		int one = 0;
		int two = 0;
		for (int i=0; i < info.Length; i++)
		{
			for (int j=i; j < info.Length; j++)
			{
				if (SumDigit(info[i]) == SumDigit(info[j]))
				{
					if ((info[i] + info[j]) > total)
					{
						//Console.WriteLine("in {0} in {1} sum {2} sum {3}", info[i], info[j], SumDigit(i), SumDigit(j));
						if (info[i] != info[j])
						{
							one = info[i];
							two = info[j];
							total = one + two;
						}
					}
				}
			}
		}
		Console.WriteLine("{0} + {1} = {2} is greatest", one, two, total);
	}
}
