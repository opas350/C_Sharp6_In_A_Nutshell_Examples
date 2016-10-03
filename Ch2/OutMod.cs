/*
 * The out modifiers is used when is necessary to get multiple return values
 * from a method call.
 */

using System;

namespace OutModifier
{
	class Test
	{
		static void Split(String name, out string firstNames, out string lastName)
		{
			int i = name.LastIndexOf(' ');
			firstNames = name.Substring(0,i);
			lastName = name.Substring(i+1);
		}

		static void Main()
		{
			string a, b;
			Split("Stevie Ray Vaughan", out a, out b);

			Console.WriteLine(a);	// Stevie Ray
			Console.WriteLine(b);	// Vaughan
		}
	}
}
