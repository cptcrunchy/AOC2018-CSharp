using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOC2018_CSharp
{
	public class DayTwo
	{
		public DayTwo()
		{
		}

		public int GetCheckSum(string[] dataArray)
		{
			int wordsWithDoubles = 0;
			int wordsWithTriples = 0;

			foreach (var word in dataArray)
			{
				var letterCounts = new Dictionary<char, int>();

				bool doubleFound = false;
				bool tripleFound = false;

				foreach (char c in word)
				{
					letterCounts.TryGetValue(c, out int current);
					letterCounts[c] = current + 1;
				}

				foreach (int count in letterCounts.Values)
				{
					if (count == 2 && !doubleFound)
					{
						doubleFound = true;
						wordsWithDoubles++;
					}

					if (count == 3 && !tripleFound)
					{
						tripleFound = true;
						wordsWithTriples++;
					}
				}
			}

			return wordsWithDoubles * wordsWithTriples;
		}

		public string GetMatchingChars(string[] words)
		{
			int smallestDiff = int.MaxValue;
			string firstWord = string.Empty;
			string secondWord = string.Empty;

			foreach(var wordOne in words)
			{
				foreach(var wordTwo in words)
				{
					if (wordOne != wordTwo)
					{

						var diff = wordOne.Where((c, i) => c != wordTwo[i]).Count();

						if (diff < smallestDiff)
						{
							firstWord = wordOne;
							secondWord = wordTwo;
							smallestDiff = diff;
						}
					}
					
				}
			}

			return string.Join("", firstWord.Intersect(secondWord));
		}
	}
}
