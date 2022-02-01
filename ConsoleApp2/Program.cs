using System;

public class Class1
{
	public static void Main()
	{
		Console.WriteLine("Enter Number");
		int num = Convert.ToInt32(Console.ReadLine());
		int temp = 0;
		for (int i = 1; i < num; i++)
		{
			if (num % i == 0)
				temp++;
		}
		if (temp > 1)
		{
			Console.WriteLine("Not Prime Number");
		}
		else
		{
			Console.WriteLine("{0} is a Prime Number", num);
		}
	}
}