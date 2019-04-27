using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;
using System.Xml;
using Newtonsoft.Json;

namespace Common
{

    public class Http
    {
	    private string _baseUrl = "http://";
	    private static string _producer = "Producer.ashx";
		public static JsonSerializer _Serializer = JsonSerializer.Create();
		
		public Http (string baseUrl, int port)
		{
			_baseUrl = "http://" + baseUrl + ":" + port + "/";
		}

		#region Post
	    public HttpStatusCode Post(Settings data)
	    {
		    return Post(data, _baseUrl + _producer);
	    }

		/// <summary>
		/// Does HTTP POST protocol to send any data
		/// </summary>
		/// <param name="data">Any data to post.</param>
		/// <param name="url">The handler location.</param>
		/// <returns>HttpStatusCode</returns>
		private  HttpStatusCode Post(Settings data, string url)
	    {
			var httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Method = "POST";
		    var stream = Json.Serialize(data, httpWebRequest.GetRequestStream());
		    httpWebRequest.ContentType = "application/json";

			stream.Flush();

			try
			{

				WebResponse response = httpWebRequest.GetResponse();

				var result = (HttpStatusCode) Json.DeSerialize<object>(response.GetResponseStream());

				return result;
			}
			catch
			{
				return HttpStatusCode.BadRequest;
			}


	    }
		#endregion

		#region Get
		public string Get()
		{
			return Get(_producer);
		}

		/// <summary>
		/// Get an object from the url
		/// </summary>
		/// <param name="url">The handler</param>
		/// <returns>Contents of file</returns>
		public string Get(string url)
		{
			var httpRequest = WebRequest.Create(_baseUrl + url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "GET";
			

			var httpReponse = (HttpWebResponse) httpRequest.GetResponse();

			if (httpReponse.StatusCode != HttpStatusCode.OK)
				return null;
			else
				return Json.DeSerialize<string>(httpReponse.GetResponseStream());
		}
		#endregion

		#region Test

		public bool TestConnection()
		{
			return TestConnection(_producer);
		}

		public bool TestConnection(string url)
		{
			var httpRequest = WebRequest.Create(_baseUrl + url);
			httpRequest.ContentType = "text/plain";
			httpRequest.Method = "GET";

			try
			{
				var httpResponse = (HttpWebResponse) httpRequest.GetResponse();
				StreamReader reader = new StreamReader(httpResponse.GetResponseStream());
				if(reader.ReadToEnd().Contains("ping pong"))
					return true;
				else
					return false;
			}
			catch(Exception e)
			{
				var x = e.Message;

				return false;
			}
		}
		#endregion
	}
}
