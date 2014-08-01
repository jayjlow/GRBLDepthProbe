using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GRBLDepthProbe
{
	static partial class Settings
	{

		public static string ComPort = "COM4";
		public static int BaudRate = 115200;

		public static int ReceiveInterval = 50;
		public static int DecimalPlaces = 3;

		public static int Timeout = 20000;

		public static decimal height = 40;
		public static decimal width = 40;
		public static decimal grid = 5;
		public static decimal safety = 2;
		public static decimal plunge = 50;
		public static decimal maxDepth = -10;
		public static decimal minimumDistance = 1;
		public static int retrys = 3;
	}
}
