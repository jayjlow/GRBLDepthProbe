using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRBLDepthProbe
{
	static class Helpers
	{
		public static bool GetDecimal(this TextBox box, out decimal value)
		{
			if (!decimal.TryParse(box.Text.Replace(',', '.'),System.Globalization.NumberStyles.Float, culture, out value))
			{
				ToolTip ttip = new ToolTip();
				ttip.ToolTipTitle = "Please enter a valid number";
				ttip.ToolTipIcon = ToolTipIcon.Error;
				ttip.Show("(0-9 . or , allowed as decimal mark)",box);
				return false;
			}
			return true;
		}

		public static bool GetInt(this TextBox box, out int value)
		{
			if (!int.TryParse(box.Text.Replace(',', '.'), System.Globalization.NumberStyles.Float, culture, out value))
			{
				ToolTip ttip = new ToolTip();
				ttip.ToolTipTitle = "Please enter a valid number";
				ttip.ToolTipIcon = ToolTipIcon.Error;
				ttip.Show("(0-9)", box);
				return false;
			}
			return true;
		}

		public static bool GetIntGreaterEqualZero(this TextBox box, out int value)
		{
			if (!int.TryParse(box.Text.Replace(',', '.'), System.Globalization.NumberStyles.Float, culture, out value) && value >= 0)
			{
				ToolTip ttip = new ToolTip();
				ttip.ToolTipTitle = "Please enter a valid number";
				ttip.ToolTipIcon = ToolTipIcon.Error;
				ttip.Show("(0-9, must be grater than or equlal to zero)", box);
				return false;
			}
			return true;
		}

		public static System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
	}
}
