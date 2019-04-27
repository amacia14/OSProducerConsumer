using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Common
{
	public static class Json
	{

		public static Stream Serialize<T>(T data, Stream stream)
		{
			using (stream)
			{
				StreamWriter writer = new StreamWriter(stream);

				var thing = JsonConvert.SerializeObject(data);

				writer.Write(thing);

				writer.Flush();
			}

			return stream;
		}

		public static T DeSerialize<T>(Stream stream)
		{
			StreamReader reader = new StreamReader(stream);

			string value = reader.ReadToEnd();
			T thing = JsonConvert.DeserializeObject<T>(value);
			

			return thing;
		}
	}
}
