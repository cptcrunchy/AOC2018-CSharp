using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC2018_CSharp
{
	public static class Program
	{
		private static readonly string _rootPath = @"W:\Personal\Advent-of-Code\AOC2018-CSharp\AOC2018-CSharp\Days\";

		static void Main(string[] args)
		{
	
			var dayOneFilePath = string.Concat(_rootPath, @"Inputs\DayOneInput.txt");
			var dayTwoFilePath = string.Concat(_rootPath, @"Inputs\DayTwoInput.txt");
			using StreamReader sr = new StreamReader(dayTwoFilePath);
			var data = sr.ReadToEnd().Split("\r\n").ToArray();
			sr.Dispose();

			//DayOne dayOne = new DayOne();
			//Console.WriteLine(dayOne.GetFrequency(data));
			//Console.WriteLine(dayOne.GetRepeatingFrequency(data));

			DayTwo dayTwo = new DayTwo();
			Console.WriteLine(dayTwo.GetCheckSum(data));
			Console.WriteLine(dayTwo.GetMatchingChars(data));

		}
	}
}
