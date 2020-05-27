using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
	public class LogBySms : Vrm.ILog
	{
		public LogBySms() : base()
		{

		}

		public void Log(string text)
		{
			System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت به وسیله ارسال پیام کوتاه لاگ گردید.");
		}

		#region Dispose
		public void Dispose()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
