using System;
using System.Transactions;

public class TestComplex
{
	public const double epsilon = 1E-6;
	public static void Test(Complex actual, Complex expected, String test)
	{
		double helpReal = Math.Abs(actual.real) - Math.Abs(expected.real);
		double helpIm = Math.Abs(actual.imaginary) - Math.Abs(expected.imaginary);

		if (helpReal < epsilon && helpIm < epsilon)
		{
			Console.WriteLine("Test {0}: OK", test);
		}
		else
		{
			Console.WriteLine("Test {0}: Failed", test);
			Console.WriteLine("Expected value: {0}", expected);
			Console.WriteLine("Actual valuse: {0}", actual);
		}
	}
}
