using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<int> fullNumbers = new();
			List<int> parenthesesNumbers = new List<int>()
			{
				11, 14, 15, 22, 47, 48, 50
			};

			for (int i = 1; i < 51; i++)
			{
				fullNumbers.Add(i);
			}

			Console.WriteLine("Output:");
			foreach (var item in fullNumbers)
			{
				//Ignore the numbers 31 to 40
				if (item < 41 && item > 30)
				{
					continue;
				}

				var outputstr = item.ToString();

				//41 to 50 should have a “*” character displayed before the num
				if (item >= 41 && item <= 50)
				{
					outputstr = "*" + outputstr;
				}

				//bool CheckParentheses(item);

				//parentheses needed
				if (parenthesesNumbers.Any(x => x == item))
				{
					outputstr = $"({outputstr})";
				}

				Console.WriteLine(outputstr);
			}
		}
	}
}