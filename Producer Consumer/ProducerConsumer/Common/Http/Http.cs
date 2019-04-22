using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
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
	    private string _baseUrl = "/";
	    private int _port;
	    private static string producer = "Producer.ashx";
		public static JsonSerializer _Serializer = JsonSerializer.Create();
		
		public Http (string baseUrl, int port)
		{
			_baseUrl = baseUrl;
			_port = port;
		}

	    public HttpStatusCode Post(Settings data)
	    {
		    return Post(data, _baseUrl + ":" + _port + "/" + "Producer.ashx");
	    }

		/// <summary>
		/// Does HTTP POST protocol to send any data
		/// </summary>
		/// <param name="data">Any data to post.</param>
		/// <param name="url">The handler location.</param>
		/// <returns>HttpStatusCode</returns>
		private  HttpStatusCode Post(Settings data, string url)
	    {
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		    httpWebRequest.ContentType = "application/json";
		    httpWebRequest.Method = "POST";

			var stream = Json.Serialize(data, httpWebRequest.GetRequestStream());

			stream.Flush();

		    WebResponse response = httpWebRequest.GetResponse();

			var result = (HttpStatusCode)Json.DeSerialize(response.GetResponseStream());

			return result;
	    }

		public string Get()
		{
			return Get("Producer.ashx");
		}

		/// <summary>
		/// Get an object from the url
		/// </summary>
		/// <param name="url">The handler</param>
		/// <returns>Contents of file</returns>
		public string Get(string url)
		{
			var httpRequest = WebRequest.Create(_baseUrl + ":" + _port + "/" + url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "GET";
			

			var httpReponse = (HttpWebResponse) httpRequest.GetResponse();

			if (httpReponse.StatusCode != HttpStatusCode.OK)
				return null;
			else
				return (string)Json.DeSerialize(httpReponse.GetResponseStream());
		}
	}
}
