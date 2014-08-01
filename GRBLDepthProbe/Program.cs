using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GRBLDepthProbe
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Settings.Initialize();


			SelectPort selectPort = new SelectPort();
			Application.Run(selectPort);

			if (selectPort.terminated)
				return;

			Settings.SaveSettings();

			SerialPort port = selectPort.port;
			PortWrapper w = new PortWrapper(port);

			Setup setup = new Setup(w);
			setup.Location = selectPort.Location;

			Application.Run(setup);

			if (setup.cancel)
			{
				port.Close();
				return;
			}

			Application.Run(new Process(w));
		}
	}
}
