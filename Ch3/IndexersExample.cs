/*
 * Example to understand the indexers
 */

using System;

namespace indexerTry1
{
	class Test
	{
		static void Main() 
		{
			string s = "Hello";
			Console.WriteLine(s[0]); // 'h'
	 		Console.WriteLine(s[1]); // 'l'
			Console.WriteLine("Press any key...");

			Console.ReadKey();

			s = null;
			Console.WriteLine(s?[0]); // Writes nothing but no error
			Console.WriteLine("Press any key to exit");
			Console.Read();

		}
	}
}
