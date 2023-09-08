using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<int> parenthesesNumbers = new()
			{
				11,
				14,
				15,
				22,
				47,
				48,
				50
			};

			for (int i = 1; i <= 50; i++)
			{
				//Ignore the numbers 31 to 40
				if (i >= 30 && i <= 40)
				{
					continue;
				}

				var outputstr = i.ToString();

				//41 to 50 should have a “*” character displayed before the num
				if (i >= 41 && i <= 50)
				{
					outputstr = $"*{outputstr}";
				}

				//parentheses needed
				if (parenthesesNumbers.Any(x => x == i))
				{
					outputstr = $"({outputstr})";
				}

				Console.WriteLine(outputstr);
			}
		}
	}
}