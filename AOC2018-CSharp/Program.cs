using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC2018_CSharp
{
	public class Program
	{
		private const string V = @"W:\Personal\Advent-of-Code\AOC2018-CSharp\AOC2018-CSharp\Days\";

		protected Program() {}

		static void Main(string[] args)
		{
			string rootPath = V;
			string dayOneFilePath = @"Inputs\DayOneInput.txt";
			using StreamReader sr = new StreamReader(string.Concat(rootPath, dayOneFilePath));
			string[] data = sr.ReadToEnd().Split("\r\n").ToArray();
			sr.Dispose();

			var dayOne = new DayOne();
			Console.WriteLine(dayOne.GetFrequency(data));
			Console.WriteLine(dayOne.GetRepeatingFrequency(data));


	
		}
	}
}
