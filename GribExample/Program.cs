using Grib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GribExample
{
	class Program
	{
		static void Main(string[] args)
		{

			using (GribFile file = new GribFile(@".\jpeg.grib2")) {
				foreach (GribMessage msg in file) {
					Console.Write(msg.GridType);
					// do something
				}
			}

		    new ManualResetEvent(false).WaitOne();
		}
	}
}
