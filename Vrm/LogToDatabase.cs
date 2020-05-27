using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrm
{
	public class LogToDatabase : ILog
	{
		public LogToDatabase() : base()
		{

		}

		public void Log(string text)
		{
			System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت در بانک اطلاعاتی ثبت گردید.");
		}

		#region Dispose
		public void Dispose()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
