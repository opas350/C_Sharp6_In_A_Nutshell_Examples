using System;

namespace InheritanceExample1
{
	public class Asset
	{
		public string Name;
	}

	public class Stock : Asset // inherits from Asset
	{
		public long SharesOwned;
	}

	public class House : Asset // inheirts from Asset
	{
		public decimal Mortgage;
	}

	public class Test
	{
		public static void Main() 
		{
			Stock msft = new Stock { Name = "MSFT", SharesOwned = 1000 };

			Console.WriteLine("Name = " + msft.Name);
			Console.WriteLine("SharesOwned = " + msft.SharesOwned);
			
			House mansion = new House { Name = "Mansion", Mortgage = 250000 };

			Console.WriteLine("Name = " + mansion.Name);
			Console.WriteLine("Mortgage = " + mansion.Mortgage);
			Console.WriteLine("Press any key to exit...");

			Console.ReadKey();

		}
	}
}
