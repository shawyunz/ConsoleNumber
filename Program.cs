using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class Program
	{
		private static readonly List<int> parenthesesNumbers = new()
		{
			11,
			14,
			15,
			22,
			47,
			48,
			50
		};

		private static void Main(string[] args)
		{
			for (int i = 1; i <= 50; i++)
			{
				//Ignore the numbers 31 to 40
				if (SkipNumberRange(i, 30, 40))
				{
					continue;
				}

				//41 to 50 should have a “*” character displayed before the num
				var outputstr = DecorateNumbers(i, 41, 50, "*", "");

				//parentheses needed for specify numbers
				if (parenthesesNumbers.Contains(i))
				{
					outputstr = DecorateNumbers(outputstr, i, i, "(", ")");
				}

				Console.WriteLine(outputstr);
			}
		}

		private static string DecorateNumbers(int num, int min, int max, string prefix, string suffix)
			=> (num >= min && num <= max) ? $"{prefix}{num}{suffix}" : num.ToString();

		private static string DecorateNumbers(string numstr, int min, int max, string prefix, string suffix)
		{
			var num = ExtractIntegerFromString(numstr);
			return (num >= min && num <= max) ? $"{prefix}{numstr}{suffix}" : numstr;
		}

		private static int ExtractIntegerFromString(string input)
		{
			string numericPart = new string(input.Where(char.IsDigit).ToArray());

			if (int.TryParse(numericPart, out int result))
			{
				return result;
			}
			else
			{
				// You can choose how to handle parsing failures here.
				throw new ArgumentException("Input string does not contain a valid integer.");
			}
		}

		private static bool SkipNumberRange(int number, int min, int max) => number >= min && number <= max;
	}
}