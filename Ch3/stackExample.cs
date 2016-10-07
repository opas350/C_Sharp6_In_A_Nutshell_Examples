/* 
 * The Object type
 */
using System;

namespace StackExample1
{
	public class Stack
	{
		int position;
		object[] data = new object[10];
		
		public void Push(object obj) { data[position++] = obj; }
		public object Pop() { return data[--position]; }
	}

	public class Test 
	{
		public static void Main()
		{
			Stack stack = new Stack();
			stack.Push("sausage");
			string s = (string) stack.Pop();	// Downcast, so explicit cast is needed.
			Console.WriteLine(s);	// sausage

			stack.Push(3);
			int three = (int) stack.Pop();

			Console.WriteLine(three);
		}
	}
}
