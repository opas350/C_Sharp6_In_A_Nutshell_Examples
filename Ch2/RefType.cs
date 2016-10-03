using System;

namespace ReferenceType
{
	class RefType {

		public class Point{ public int X, Y; }

		static void Main() {

			Point p1 = new Point();
			p1.X = 7;

			Point p2 = p1;		// Assigment causes copy

			Console.WriteLine(p1.X);	// 7
			Console.WriteLine(p2.X);	// 7

			p1.X = 9;	//Change p1.X

			Console.WriteLine(p1.X);	// 9
			Console.WriteLine(p2.X);	// 7
		}
	}
}
