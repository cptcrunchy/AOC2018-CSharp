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
			using StreamReader sr = new StreamReader(dayOneFilePath);
			var dayOneData = sr.ReadToEnd().Split("\r\n").ToArray();
			sr.Dispose();

			DayOne dayOne = new DayOne();
			Console.WriteLine(dayOne.GetFrequency(dayOneData));
			Console.WriteLine(dayOne.GetRepeatingFrequency(dayOneData));
	
		}
	}
}
