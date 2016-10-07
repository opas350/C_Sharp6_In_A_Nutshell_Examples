/*
 * Implications of passing by refence.
 *
 * When you pass an argument by refence, you alias the storage location of a variable
 * rather than a new memory location.
 */

using System;

namespace PassingReference
{
	class Test
	{
		static int x;

		static void Main() { Foo(out x); }

		static void Foo (out int y)
		{
			Console.WriteLine(x);
			y = 1;
			Console.WriteLine(x);
		}
	}
}
