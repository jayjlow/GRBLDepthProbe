using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRBLDepthProbe
{
	class Truncator
	{
		static private string numbers = "0123456789.-+";
		public static void TruncateLine(ref string line)
		{
			string lineo = "";
			string currentnumber = "";
			bool wasnumber = false;
			bool comment = false;

			for (int c = 0; c < line.Length; c++)
			{
				if ("(;".Contains(line[c]))
					comment = true;


				if (!comment)
				{
					if (!numbers.Contains(line[c]))
					{
						if (wasnumber)
						{
							decimal d = decimal.Parse(currentnumber, Helpers.culture);
							d = Math.Round(d, Settings.DecimalPlaces);
							lineo += d.ToString(Helpers.culture);
							currentnumber = "";
							wasnumber = false;
						}
						lineo += line[c];
					}
					else
					{
						currentnumber += line[c];
						wasnumber = true;
					}

				}

				if (line[c] == ')')
					comment = false;

			}

			if (wasnumber)
			{
				decimal d = decimal.Parse(currentnumber, Helpers.culture);
				d = Math.Round(d, Settings.DecimalPlaces);
				lineo += d.ToString(Helpers.culture);
				currentnumber = "";
				wasnumber = false;
			}

			line = lineo;


		}
	}
}
