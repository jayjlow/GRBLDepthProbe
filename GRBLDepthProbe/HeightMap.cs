using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRBLDepthProbe
{
	class HeightMap
	{
		public decimal[,] values;
		public decimal grid;

		public int sizeX, sizeY;

		public int total;
		public int currentreadings = 0;

		public HeightMap(int sizeX, int sizeY, decimal grid)
		{
			values = new decimal[sizeX, sizeY];
			
			for(int x = 0; x < sizeX; x++)
			{
				for (int y = 0; y < sizeY; y++)
					values[x, y] = decimal.MinValue;
			}

			this.grid = grid;
			this.sizeX = sizeX;
			this.sizeY = sizeY;
			this.total = sizeX * sizeY;
		}

		public void SaveToFile(string path)
		{
			StringBuilder s = new StringBuilder();

			for (int y = sizeY - 1; y >= 0; y--) 
			{
				for (int x = 0; x < sizeX; x++)
				{
					if (x != 0)
						s.Append(';');
					if (values[x, y] != decimal.MinValue)
						s.Append(values[x, y]);
					else
						s.Append(';');
				}
				s.AppendLine();
			}

			File.WriteAllText(path, s.ToString());
		}

		public Bitmap ToBitmap()
		{

			Bitmap i = new Bitmap(sizeX, sizeY);

			decimal min = decimal.MaxValue;
			decimal max = decimal.MinValue;

			foreach (decimal d in values)
			{
				if (d == decimal.MinValue)
					continue;
				if (d > max)
					max = d;
				if (d < min)
					min = d;
			}

			if(min == decimal.MinValue)
				return i;

			if(min == max)
			{
				min -= 1;
				max += 1;
			}

			for (int x = 0; x < sizeX; x++)
			{
				for (int y = 0; y < sizeY; y++)
				{
					if(values[x, y] != decimal.MinValue)
						i.SetPixel(x, sizeY - y - 1, GetColor(values[x, y], min, max));
				}
			}
			return i;
		}

		private Color GetColor(decimal value, decimal min, decimal max)
		{
			int red = 0, green = 0, blue = 0;

			value -= min;
			if (max == min)
				max += 1.0m;

			value /= (max - min);


			if (value < 0.5m)
			{
				blue = (int)((1m - 2m * value) * 255);
				green = (int)(2m * value * 255);
			}
			else
			{
				value -= 0.5m;
				green = (int)((1m - 2m * value) * 255);
				red = (int)(2m * value * 255);
			}

			return Color.FromArgb(red, green, blue);
		}

		public decimal HighestNeighbour(int x, int y)
		{
			int[,] places = new int[,] { { x - 1, y - 1 }, { x - 1, y + 1 }, { x + 1, y - 1 }, { x + 1, y + 1 } };

			for(int i = 0; i < 4; i++)
			{
				if (places[i, 0] < 0 || places[i, 0] >= sizeX || places[i, 1] < 0 || places[i, 1] >= sizeY)
				{
					places[i, 0] = x;
					places[i, 1] = y;
				}
			}

			decimal highest = decimal.MinValue;

			for (int i = 0; i < 4; i++)
			{
				if(values[places[i, 0], places[i, 1]] > highest)
					highest = values[places[i, 0], places[i, 1]];
			}

			return highest;
		}


	}
}
