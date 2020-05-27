using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dependency_Injection
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Library
			//Vrm.LogHandler oLogHandler = new Vrm.LogHandler();

			//oLogHandler.LogToDatabase("متنی برای لاگ شدن");
			//oLogHandler.LogToFile("متنی برای لاگ شدن");

			// **************************************************
			// **************************************************

			// Framework (Change Strategy Pattern)
			//Vrm.ILog oLogger = new Vrm.LogToDatabase();
			//Vrm.ILog oLogger = new LogToFile();
			//Vrm.ILog oLogger = new LogBySms();

			Vrm.LogHandler logHandler = new Vrm.LogHandler();
			//Vrm.LogHandler logHandler = new Vrm.LogHandler(oLogger);

			logHandler.Log(text: "متنی برای لاگ شدن");
		}
	}
}
