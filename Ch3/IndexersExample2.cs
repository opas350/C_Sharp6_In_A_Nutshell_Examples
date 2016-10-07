/*
 * Implementing an indexer
 */
using System;

namespace IndexerExample2
{
	class Sentence
	{
		string[] words = "The quick brown fox".Split();

		public string this [int wordNum]	// indexer
		{
			get { return words[wordNum]; }
			set { words[wordNum] = value; }
		}

	}

	class Test {

		public static void Main()
		{
			Sentence s = new Sentence();
			Console.WriteLine(s[0] + s[1] + s[2] + s[3]);
			Console.WriteLine(s[3]);	// fox
			s[3]= "Kangaroo";
			Console.WriteLine(s[3]);	// kangaroo
			Console.WriteLine(s[0] + s[1] + s[2] + s[3]);
		}
	}
}
