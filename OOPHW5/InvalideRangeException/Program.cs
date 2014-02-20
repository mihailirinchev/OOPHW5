using System;
using System.Linq;

namespace InvalidRangeException
{
	internal class Program
	{
		private static readonly DateTime minDate = new DateTime(1980, 1, 1);
		private static readonly DateTime maxDate = new DateTime(2013,12,31);
		private static readonly Random rand = new Random();

		static void Main(string[] args)
		{
			while (true)
			{
				try
				{
					if (rand.Next(2) == 0)
					{
						AskForAnInt();
					}
					else
					{
						AskForADateTime();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("An error occurred: {0}", ex.Message);
				}
			}
		}

		private static void AskForAnInt()
		{
			Console.Write("Input integer within [0...100]: ");
			var val = int.Parse(Console.ReadLine());

			if (val < 0 || val > 100)
			{
				throw new InvalidRangeException<int>(0, 100);
			}
		}

		private static void AskForADateTime()
		{
			Console.Write("Input datetime within [1.1.1980...31.12.2013]: ");
			var val = DateTime.Parse(Console.ReadLine());

			if (val < minDate || val > maxDate)
			{
				throw new InvalidRangeException<DateTime>(minDate, maxDate);
			}
		}
	}
}