using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrm
{
	public class LogHandler : object
	{
		// Default Constructor
		public LogHandler() : base()
		{
			this.Logger = new LogToDatabase();
		}

		// Constructor OverLoading
		public LogHandler(ILog log)
		{
			this.Logger = log;
		}

		public ILog Logger { get; set; }

		//public void LogToDatabase(string text)
		//{
		//	System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت در بانک اطلاعاتی ثبت گردید.");
		//}

		//public void LogToFile(string text)
		//{
		//	System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت در فایل مورد نظر ثبت گردید.");
		//}

		public void Log(string text)
		{
			Logger.Log(text);
		}
	}
}
