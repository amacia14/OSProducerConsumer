using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;


namespace Producer
{
	public class ProducerWorker
	{
		public ConcurrentBuffer _buffer;
		public int wordCount;
		public int sleepCount;
		private bool _stop { get; set; }

		public bool Stop
		{
			get { return _stop; }
			set
			{
				lock (locker)
				{
					_stop = value;
				}
			}
		}

		private object locker = new object();
		
		public ProducerWorker(ConcurrentBuffer buffer, int wordCount, int sleepCount)
		{
			_buffer = buffer;
			this.wordCount = wordCount;
			this.sleepCount = sleepCount;
			Stop = false;
		}
		
		public void Produce()
		{
			var path = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

			while(!_stop)
			{

				string fileName = Path.Combine(path, "ConsumerProducerFiles", Guid.NewGuid().ToString() + ".txt");
				using(StreamWriter fileStream = File.CreateText(fileName))
				{
					WriteFile(fileStream, wordCount);
				}

				var success = _buffer.TryAdd(fileName);

				if (!success)
				{
					try
					{
						File.Delete(fileName);
					}
					finally
					{
						Thread.Sleep(sleepCount);
					}
				}
				Thread.Sleep(sleepCount);
			} 
		}
		
		private const string alpha = "abcdefghijklmnopqrstuvwxyz";
		private string RandomString()
		{
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] data = new byte[1];
			do
			{
				rng.GetBytes(data);
			} while (data[0] > 18);

			var length = data[0];
			data = new byte[length];
			rng.GetBytes(data);

			var charString = "";
			for (int i = 0; i < length; i++)
			{
				charString += alpha[data[i] % alpha.Length].ToString();
			}

			charString += ' ';
			return charString;
		}


		/// <summary>
		/// this methods will write set up the writestram to  guid.txt file
		/// </summary>
		/// <param name="Filename"></param>
		private void WriteFile(StreamWriter writer, int wordCount)
		{
			for (int wordNumber = 0; wordNumber < wordCount; wordNumber++)
			{
				string word = RandomString();

				writer.Write(word);
			}

			writer.Flush();
		}
	}
}
