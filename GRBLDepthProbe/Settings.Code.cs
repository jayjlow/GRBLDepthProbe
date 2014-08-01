using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRBLDepthProbe
{
	partial class Settings
	{
		private const string filepath = "settings.txt";

		private static string[] file_lines = { };

		public static void Initialize()
		{
			try
			{
				if (!File.Exists(filepath))
				{
					File.Create(filepath).Close();
				}
				file_lines = File.ReadAllLines(filepath);
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show("Error while reading Settings:\n" + e.StackTrace);
			}


			System.Reflection.FieldInfo[] fieldInfo = typeof(Settings).GetFields();

			foreach (System.Reflection.FieldInfo info in fieldInfo)
			{
				object defvalue = info.GetValue(null);
				
				if (defvalue is string)
				{
					info.SetValue(null, GET(info.Name, (string)defvalue));
				}
				else if (defvalue is int)
				{
					info.SetValue(null, GETi(info.Name, (int)defvalue));
				}
			}


		}

		public static void SaveSettings()
		{
			StringBuilder b = new StringBuilder();

			System.Reflection.FieldInfo[] fieldInfo = typeof(Settings).GetFields();

			foreach (System.Reflection.FieldInfo info in fieldInfo)
			{
				object value = info.GetValue(null);
				if (value is string)
				{
					b.AppendLine(info.Name + "=" + (string)value);
				}
				else if (value is int)
				{
					b.AppendLine(info.Name + "=" + ((int)value).ToString());
				}
			}

			try
			{
				if(File.ReadAllText(filepath) != b.ToString())
					File.WriteAllText(filepath, b.ToString());
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show("Error while writing Settings:\n" + e.StackTrace);
			}

		}



		private static string GET(string option, string defaultValue)
		{
			int linecount = 0;
			while (linecount < file_lines.Length)
			{
				string[] split = file_lines[linecount].Split('=');

				if (split.Length != 2)
					continue;

				if (split[0] == option)
				{
					return split[1];
				}
				linecount++;
			}
			return defaultValue;
		}

		private static int GETi(string option, int defaultValue)
		{
			string value = GET(option, defaultValue.ToString());
			int output = defaultValue;
			int.TryParse(value, out output);
			return output;
		}
	}
}
