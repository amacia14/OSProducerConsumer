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

    public static class Http<T>
    {
	    private static string baseurl = "/";
	    
	    private static JsonSerializer serializer = JsonSerializer.Create();

	    public static HttpStatusCode Post(T data)
	    {
		    return Post(data, baseurl + "Post.aspx");
	    }

		/// <summary>
		/// Does HTTP POST protocol to send any data
		/// </summary>
		/// <param name="data">Any data to post.</param>
		/// <param name="url">The handler location.</param>
		/// <returns>HttpStatusCode</returns>
		public static HttpStatusCode Post(T data, string url)
	    {
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		    httpWebRequest.ContentType = "application/json";
		    httpWebRequest.Method = "POST"; 

			//Do content length

		    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
		    {
			    JsonWriter writer = new JsonTextWriter(streamWriter);
				serializer.Serialize(writer, data);
				
				writer.Flush();
				writer.Close();
			    streamWriter.Close();
		    }

		    WebResponse response = httpWebRequest.GetResponse();
			
			Console.WriteLine("Received data");

			HttpStatusCode result;
			using (var streamReader = response.GetResponseStream())
			{
				JsonReader reader = new JsonTextReader(new StreamReader(streamReader));
				result  = (HttpStatusCode)serializer.Deserialize(reader);

				reader.Close();
			}
			response.Dispose();

			return result;
	    }

		public static T Get()
		{
			return Get("Get.aspx");
		}

		/// <summary>
		/// Get an object from the url
		/// </summary>
		/// <param name="url">The handler</param>
		/// <returns>The object you choose</returns>
		public static T Get(string url)
		{
			var httpRequest = WebRequest.Create(baseurl + url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "GET";


			var httpReponse = (HttpWebResponse) httpRequest.GetResponse();
			T result;
			using (var streamReader = new StreamReader(httpReponse.GetResponseStream()))
			{
				JsonReader reader = new JsonTextReader(new StringReader(streamReader.ReadToEnd()));
				result = (T)serializer.Deserialize(reader);

				reader.Close();
				streamReader.Close();
			}

			return result;
		}
	}
}
