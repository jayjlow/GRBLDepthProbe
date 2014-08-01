using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRBLDepthProbe
{
	partial class Setup : Form
	{
		PortWrapper port;
		public bool cancel = true;

		public Setup(PortWrapper port)
		{
			InitializeComponent();
			this.port = port;
		}

		private void jog_Click(object sender, EventArgs e)
		{
			if(port.Execute(string.Format(Helpers.culture, "G91G0{0}{1}", ((Button)sender).Text, numericUpDown1.Value)) == CommandResult.Error)
			{
				MessageBox.Show("Error");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (SaveSettings())
			{
				this.cancel = false;
				this.Close();
			}
		}

		private void digitsBOX_TextChanged(object sender, EventArgs e)
		{
			int x;
			if (digitsBOX.GetIntGreaterEqualZero(out x))
				numericUpDown1.DecimalPlaces = x;
		}

		bool SaveSettings()
		{
			bool ok = true;

			ok &= widthBOX.GetDecimal(out Settings.width);
			ok &= heightBOX.GetDecimal(out Settings.height);
			ok &= gridBOX.GetDecimal(out Settings.grid);
			ok &= safetyHeightBOX.GetDecimal(out Settings.safety);
			ok &= plungeRateBOX.GetDecimal(out Settings.plunge);
			ok &= maxDepthBOX.GetDecimal(out Settings.maxDepth);
			ok &= addedSafetyBOX.GetDecimal(out Settings.minimumDistance);
			ok &= maxRetrysBOX.GetIntGreaterEqualZero(out Settings.retrys);
			ok &= digitsBOX.GetIntGreaterEqualZero(out Settings.DecimalPlaces);

			Settings.SaveSettings();

			return ok;
		}




		private void button8_Click(object sender, EventArgs e)
		{
			if (port.Execute(string.Format("G92X0Y0Z0", ((Button)sender).Text, numericUpDown1.Value)) == CommandResult.Error)
			{
				MessageBox.Show("Error");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			bool ok = true;
			ok &= plungeRateBOX.GetDecimal(out Settings.plunge);
			ok &= maxDepthBOX.GetDecimal(out Settings.maxDepth);
			if (ok)
			{
				if (port.Probe().result == CommandResult.Error)
				{
					MessageBox.Show("Error");
				}
			}
		}

	}
}
