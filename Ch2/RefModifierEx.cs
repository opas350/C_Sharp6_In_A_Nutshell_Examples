using System;

namespace ReferenceModifierExample1
{
	class Test {

		static void Foo(ref int p)
		{
			p = p + 1;	// Increment p by 1
			Console.WriteLine(p);	// Write p to screen
		}

		static void Main()
		{
			int x = 8;
			Foo(ref x);	// Ask Foo to deal directly with x
			Console.WriteLine(x);	// x is now 9
		}
	}
}
