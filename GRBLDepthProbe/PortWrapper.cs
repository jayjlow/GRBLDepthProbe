using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRBLDepthProbe
{

	enum CommandResult
	{
		Ok,
		ProbeClosed,
		Error
	}

	struct Response
	{
		public CommandResult result;
		public decimal height;
	};

	class PortWrapper
	{
		SerialPort port;

		public string LastError = "";

		public PortWrapper(SerialPort port)
		{
			this.port = port;
		}

		public void WaitForIdle()
		{
			while (true)
			{
				port.Write("?");
				Console.WriteLine("PC>?");

				string response = "";
				while (!response.Contains(">"))
				{
					response += port.ReadExisting();
					System.Threading.Thread.Sleep(Settings.ReceiveInterval);
				}

				Console.WriteLine("response");

				if (response.ToLower().Contains("idle"))
					return;

				System.Threading.Thread.Sleep(400);
			}
		}
		public CommandResult Execute(string command, params object[] para)
		{
			port.ReadExisting();

			command = string.Format(Helpers.culture, command, para);
			Truncator.TruncateLine(ref command);

			Console.WriteLine("PC>" + command);

			port.Write(command);
			port.Write("\r");

			string response = "";

			DateTime start = DateTime.Now;

			while (!response.Contains("ok") && !response.Contains("error"))
			{
				response += port.ReadExisting();
				System.Threading.Thread.Sleep(Settings.ReceiveInterval);
			}

			Console.WriteLine("GRBL>" + response);

			if (response .Contains( "ok"))
				return CommandResult.Ok;
			LastError = response;

			return CommandResult.Error;
		}

		public Response Probe()
		{
			port.ReadExisting();
			string command = string.Format(Helpers.culture, "G38.2Z{0}F{1}", Settings.maxDepth, Settings.plunge);
			Truncator.TruncateLine(ref command);

			Console.WriteLine("PC>" + command);
			port.Write(command);
			port.Write("\r");

			string response = "";

			DateTime start = DateTime.Now;

			while ((!response.Contains("ok") && !response.Contains("error")))
			{
				response += port.ReadExisting();
				System.Threading.Thread.Sleep(Settings.ReceiveInterval);
			}

			Console.WriteLine("GRBL>" + response);

			Response r = new Response();


			if(response.Contains("ok"))
			{
				string[] fields = response.Split(',', ':', ']');
				
				r.height = decimal.Parse(fields[3], Helpers.culture);
				r.result = CommandResult.Ok;
			}

			if (response.Contains("error"))
			{ 
				if(response.Contains("36"))
					r.result = CommandResult.ProbeClosed;
				else
					r.result = CommandResult.Error;
			}
			return r;

		}

	}
}
