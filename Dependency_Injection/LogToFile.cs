using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
	public class LogToFile : Vrm.ILog
	{
		public LogToFile() : base()
		{

		}

		public void Log(string text)
		{
			System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت در فایل مورد نظر ثبت گردید.");
		}

		#region Dispose
		public void Dispose()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
