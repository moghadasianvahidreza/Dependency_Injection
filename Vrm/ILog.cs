using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrm
{
	public interface ILog : IDisposable
	{
		void Log(string text);
	}
}
