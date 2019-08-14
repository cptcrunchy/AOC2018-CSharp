using System;
using System.Collections.Generic;
using System.Text;

namespace AOC2018_CSharp
{
	public class DayThree
	{
		public DayThree()
		{

		}

		public int GetCountOfOverlaps(string[] lines)
		{
			int overlapCount = 0;

			var fabricGrid = new Dictionary<int, Dictionary<int, int>>();

			foreach(var line in lines)
			{
				string[] details = line.Split(" ");
				var coordinates = details[2].Remove(details[2].Length - 1, 1).Split(",");
				int xCoordinate = int.Parse(coordinates[0]);
				int yCoordinate = int.Parse(coordinates[1]);

				string[] dimensions = details[3].Split('x');
				int width = int.Parse(dimensions[0]);
				int height = int.Parse(dimensions[1]);
				int maxXCoordinate = xCoordinate + width;
				int maxYCoordinate = yCoordinate + height;

				for(int x = xCoordinate; x < maxXCoordinate; x++)
				{
					for(int y = yCoordinate; y < maxYCoordinate; y++)
					{
						if(!fabricGrid.TryGetValue(x, out var gridDictY))
						{
							gridDictY = new Dictionary<int, int>();
							fabricGrid[x] = gridDictY;
						}

						if(!gridDictY.TryGetValue(y, out var gridAtLocation))
						{
							gridAtLocation = 0;
						}
						gridAtLocation++;
						gridDictY[y] = gridAtLocation;
					}
				}
			}


			for(int x = 0; x < 999; x++)
			{
				for (int y = 0; y < 1000; y++)
				{
					var isClaimOnFabric = fabricGrid.TryGetValue(x, out var gridDictY);
					var isClaimOnGrid = gridDictY.TryGetValue(y, out var gridAtLocation);

					if (isClaimOnFabric && isClaimOnGrid && gridAtLocation > 1)
					{
						overlapCount++;
					}
				}
			}

			return overlapCount;
		}
	}
}
