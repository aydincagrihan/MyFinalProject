using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
	//Birbirinin alternatifi olan herşeyi interface ile implement edilir
	public class FileLogger:ILogger
	{
		public void Log()
		{
			
			Console.WriteLine("Dosyaya Loglandı");
		}
	}
}
