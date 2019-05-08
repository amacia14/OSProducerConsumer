using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using Common;
using Producer;

namespace ProducerWCF
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service : Producer.IWorker
	{

		private static Producer.Worker worker = Worker._worker;

		public string[] BufferItems()
		{
			return worker.BufferItems();
		}

		public Settings CurrentSettings()
		{
			return worker.CurrentSettings();
		}

		public string Get()
		{
			return worker.Get();
		}
		
		public HttpStatusCode Post(Settings newSettings)
		{
			return worker.Post(newSettings);
		}

		public void Reset()
		{
			worker.Reset();
		}

		public bool Test()
		{
			return worker.Test();
		}
	}
}
