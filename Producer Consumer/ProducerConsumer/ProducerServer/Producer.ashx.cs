using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web;
using System.Web.UI;
using Common;
using Newtonsoft.Json;
using Producer;

namespace ProducerServer
{
	/// <summary>
	/// Summary description for Producer
	/// </summary>
	public class Producer : IHttpHandler
	{
		private Settings _settings;
		private List<Thread> _threads { get; set; }
		private ConcurrentBuffer _buffer { get; }

		public Producer()
		{
			_threads = new List<Thread>();
		}


		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "application/json";
			var request = context.Request;

			object response = null;
			Type responseType = null;

			switch (request.HttpMethod.ToLower())
			{
				case "post":
				{
					Settings settings = null;
					responseType = typeof(HttpStatusCode);
					var status = Post(settings);
					context.Response.StatusCode = (int) status;
					context.Response.Flush();
					return;
				}
				case "get":
				{
					responseType = typeof(string);
					response = Get();
					Json.Serialize((string)response, context.Response.OutputStream);
					context.Response.Flush();
					return;
				}
				default:
				{
					context.Response.StatusCode = 400;
					context.Response.Flush();
					return;
				}
			}
		}

		private string Get()
		{
			return "Hello world";
		}

		private HttpStatusCode Post(Settings settings)
		{
			_settings = settings;

			if(_buffer == null || _settings.BufferSize > _buffer.Size)
				_buffer = new ConcurrentBuffer(_settings.BufferSize);
			if (_settings.NumOfProducers > _threads.Count)
			{
				Thread thread = new Thread();
			}
				
			return HttpStatusCode.OK;
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}