using Common;
using Producer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Producer
{
	[ServiceContract]
	public interface IWorker
	{
		[OperationContract]
		string Get();

		[OperationContract]
		HttpStatusCode Post(Settings newSettings);

		[OperationContract]
		void Reset();

		[OperationContract]
		bool Test();

		[OperationContract]
		string[] BufferItems();

		[OperationContract]
		Settings CurrentSettings();
		
	}
}