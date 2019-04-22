using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
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
		private ConcurrentBuffer _buffer { get; set; }

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
					if (response == null)
					{
						context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
						context.Response.Flush();
						return;
					}

					context.Response.StatusCode = (int) HttpStatusCode.OK;

					Json.Serialize((string)response, context.Response.OutputStream);
					context.Response.Flush();
					return;
				}
				default:
				{
					context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
					context.Response.Flush();
					return;
				}
			}
		}

		private string Get()
		{
			if (_buffer == null)
				return null;

			string url = "";
			bool isSuccess = _buffer.TryTake(out url);
			if (!isSuccess)
			{
				return null;
			}

			var fileStream = File.Open(url, FileMode.Open);
			return new StreamReader(fileStream).ReadToEnd();
		}

		private HttpStatusCode Post(Settings settings)
		{
			if (settings == null)
				return HttpStatusCode.BadRequest;
			_settings = settings;

			if(_buffer == null || _settings.BufferSize > _buffer.Size)
				_buffer = new ConcurrentBuffer(_settings.BufferSize);
			if (_settings.NumOfProducers > _threads.Count)
			{
				Task.Run(() =>
				{
					//TODO: Assign producer method to the thread with a delegate
					//Send a method to update number of words
					//Send a method to update producer sleep
					//Thread thread = new Thread();
				});
			}
			
			return HttpStatusCode.OK;
		}

		public bool IsReusable
		{
			get
			{
				return true;
			}
		}
	}
}