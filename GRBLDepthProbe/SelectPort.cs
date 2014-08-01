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
	public partial class SelectPort : Form
	{
		public SerialPort port;
		public bool terminated = true;
		public SelectPort()
		{
			InitializeComponent();
			button1_Click(null, null);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();
			string[] ports = SerialPort.GetPortNames();
			comboBox1.Items.AddRange(ports);

			for (int x = 0; x < comboBox1.Items.Count; x++)
			{
				if (((string)comboBox1.Items[x]).Equals(Settings.ComPort))
				{
					comboBox1.SelectedIndex = x;
					break;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			uint baud;

			if(uint.TryParse(textBox1.Text, out baud))
			{
				port = new SerialPort((string)comboBox1.SelectedItem, (int)baud);
				port.DtrEnable = true;

				try
				{
					port.Open();

					string result = "";

					DateTime start = DateTime.Now;

					while((DateTime.Now - start).TotalMilliseconds < 3000)
					{
						result += port.ReadExisting();
						if(result.ToLower().Contains("grbl"))
						{
							terminated = false;
							this.Close();
							Settings.ComPort = (string)comboBox1.SelectedItem;
							Settings.BaudRate = (int)baud;
							Settings.SaveSettings();
							return;
						}
						System.Threading.Thread.Sleep(Settings.ReceiveInterval);

					}
					MessageBox.Show("Serial Port does not have GRBL connected\nare you using the right baud rate?");
					port.Close();
				}
				catch (Exception ex) { MessageBox.Show("could not open serial port:\n" + ex.Message); }
			}
			else
			{
				MessageBox.Show("please enter a valid baudrate");

			}
		
		}

	}
}
