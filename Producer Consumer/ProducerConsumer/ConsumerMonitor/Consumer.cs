using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common;
using ConsumerMonitor.ProducerWCF;

namespace ConsumerMonitor
{
	public class Consumer
	{
		public int _consumerSleepNum { get; set; }
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

		private WorkerClient _Producer { get; set; }
		private List<string> _wordFound { get; }
		private object locker = new object();
		private string _englishList { get; set; }
		public string Sentence
		{
			get
			{
				StringWriter writer = new StringWriter(new StringBuilder());
				foreach (var word in _wordFound.ToArray())
				{
					writer.Write(word + " ");
				}
				writer.Write(".");
				return writer.ToString();
			}
		}



		public Consumer(int consumerSleepNum, WorkerClient connection)
		{
			this._consumerSleepNum = consumerSleepNum;
			_Producer = connection;
			_wordFound = new List<string>();
			Stop = false;
		}

		private void GetEnglish(string url)
		{
			var directory = System.IO.Directory.GetCurrentDirectory() + "\\";
			var file = File.OpenText(directory + url).ReadToEnd().ToLower();

			_englishList = file;
		}

		public void Consume()
		{
			GetEnglish("words.txt");
			while (!_stop)
			{
				try
				{
					string data = null;
					try
					{
						data = _Producer.Get();
					}
					catch
					{
						Thread.Sleep(_consumerSleepNum * 2);
						continue;
					}
					if (data == null || data.Length == 0 || data.Equals(""))
					{
						Thread.Sleep(_consumerSleepNum * 2);
						continue;
					}

					data = data.ToLower();
					var words = data.Split(' ').Where(x => x.Length > 0).Where(x => !String.Equals(x, "")).ToList();
					
					foreach (var word in words)
					{
						try
						{
							var yes = _englishList.Contains("\n" + word + "\n");
							if (yes && word.Length > 3)
								_wordFound.Add(word);
						}
						catch{}
					}

					Thread.Sleep(_consumerSleepNum);
				}
				catch(Exception exception)
				{
					var e = exception;
					Thread.Sleep(_consumerSleepNum * 2);
				}
			}
		}
	}
}
