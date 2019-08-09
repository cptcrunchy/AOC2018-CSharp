using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace AOC2018_CSharp
{
	public class DayOne
	{
		public DayOne()
		{
		}

		public int GetFrequency(string[] dataArray) => dataArray.Aggregate(0, (sum, val) => sum + Convert.ToInt32(val));
		
		public int GetRepeatingFrequency(string[] dataArray)
		{
			List<int> freqArray = new List<int>();
			int freq = 0;
			int maxSearches = 1000;
			int loopCounter = 1;

			while(loopCounter < maxSearches)
			{
				loopCounter++;
				foreach (string line in dataArray)
				{
					freq += Convert.ToInt32(line);
					if (freqArray.Contains(freq))
					{
						return freq;
					}
					else
					{
						freqArray.Add(freq);
					}

				}
			}

			return freq;
		}
	}
}
