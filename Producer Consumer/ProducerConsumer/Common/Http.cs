using System;
using System.Collections.Generic;
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

    public static class Http
    {
	    private static string url = "";
	    private static JsonSerializer serializer = JsonSerializer.Create();

		public static object Post(object data)
	    {
		    
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		    httpWebRequest.ContentType = "application/json";
		    httpWebRequest.Method = "POST"; 

		    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
		    {
			    JsonWriter writer = new JsonTextWriter(streamWriter);
				serializer.Serialize(writer, data);
				
				writer.Flush();
				writer.Close();
			    streamWriter.Close();
		    }

		    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		    object result = null;
			using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
		    {
			    JsonReader reader = new JsonTextReader(new StringReader(streamReader.ReadToEnd()));
			    result = serializer.Deserialize(reader);
				
				reader.Close();
				streamReader.Close();
		    }

			return result;
	    }

		//public static bool Get()
		//{
		//	var httpRequest = WebRequest.Create(url);
		//}
    }
}
