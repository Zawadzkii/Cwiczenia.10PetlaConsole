using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Podaj pierwszą liczbę:");
		int number1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Podaj drugą liczbę:");
		int number2 = Convert.ToInt32(Console.ReadLine());

		int lcm = FindLCM(number1, number2);

		Console.WriteLine($"Najmniejsza wspólna wielokrotność dla {number1} i {number2} to: {lcm}");
	}

	static int FindLCM(int a, int b)
	{
		return (a * b) / FindGCD(a, b);
	}

	static int FindGCD(int a, int b)
	{
		while (b != 0)
		{
			int temp = b;
			b = a % b;
			a = temp;
		}
		return a;
	}
}