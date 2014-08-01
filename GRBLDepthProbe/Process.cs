using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRBLDepthProbe
{
	partial class Process : Form
	{
		PortWrapper port;
		HeightMap map;

		int sizeX, sizeY, totalReadings;



		public Process(PortWrapper w)
		{
			InitializeComponent();
			port = w;

			sizeX = (int)(Settings.width / Settings.grid) + 1;
			sizeY = (int)(Settings.height / Settings.grid) + 1;
			totalReadings = sizeX * sizeY;
			progressBar1.Maximum = totalReadings;

			map = new HeightMap(sizeX, sizeY, Settings.grid);

			backgroundWorker1.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			if (port.Execute("G90G0Z{0}", Settings.safety) == CommandResult.Error)
				MessageBox.Show(port.LastError);



			for (int cX = 0; cX < sizeX; cX++)
			{
				for (int cY = 0; cY < sizeY; cY++)
				{
					decimal safety = Settings.safety;
					if (map.HighestNeighbour(cX, cY) + Settings.minimumDistance > safety)
						safety = map.HighestNeighbour(cX, cY) + Settings.minimumDistance;

					if (port.Execute("G0Z{0}", safety) == CommandResult.Error)
						MessageBox.Show(port.LastError);

					if (port.Execute("G0X{0}Y{1}", cX * Settings.grid, cY * Settings.grid) == CommandResult.Error)
						MessageBox.Show(port.LastError);

					int retrys = 0;

					bool ok = false;

					while (retrys < Settings.retrys && !ok)
					{
						port.WaitForIdle();
						Response r = port.Probe();

						switch (r.result)
						{
							case CommandResult.Error:
								MessageBox.Show(port.LastError);
								break;


							case CommandResult.ProbeClosed:
								safety += Settings.minimumDistance;
								if (port.Execute("G0Z{0}", safety) == CommandResult.Error)
									MessageBox.Show(port.LastError);
								break;

							case CommandResult.Ok:
								ok = true;
								map.values[cX, cY] = r.height;
								map.currentreadings++;
								backgroundWorker1.ReportProgress(0, null);
								break;

						}
						retrys++;
					}


				}
			}
			if (port.Execute("G0Z{0}", Settings.safety) == CommandResult.Error)
				MessageBox.Show(port.LastError);
			

		}


		private void button1_Click(object sender, EventArgs e)
		{
			backgroundWorker1.CancelAsync();
		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			progressBar1.Value++;
			pictureBox1.Image = map.ToBitmap();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			map.SaveToFile(saveFileDialog1.FileName);
		}

		

	}
}
