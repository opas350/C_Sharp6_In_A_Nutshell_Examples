/*
 * Swap Method
 */

using System;

namespace SwapMethod1
{
	class Test
	{
		static void Swap(ref string a, ref string b)
		{
			string temp = a;
			a = b;
			b = temp;
		}

		static void Main()
		{
			string x = "Penn";
			Console.WriteLine("X = " + x);
			string y = "Teller";
			Console.WriteLine("Y = " + y);
			
			Swap(ref x, ref y);
			Console.WriteLine("New X = " + x);
			Console.WriteLine("New Y = " + y);
			Console.ReadKey();
		}
	}
}
