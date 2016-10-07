/*
 * Params Modifier
 *
 * The params parameter modifier can be used as the last parameter specified
 * so taht the method accepts any number of arguments.
 *
 */

using System;

namespace ParamModifierEx1
{
	class Test
	{
		static int Sum(params int[] ints)
		{
			int sum = 0;
			for(int i = 0; i < ints.Length; i++)
				sum += ints[i];
			
			return sum;
		}

		static void Main()
		{
			int total = Sum(1, 2, 3, 4);
			Console.WriteLine(total);
		}
	}
}
