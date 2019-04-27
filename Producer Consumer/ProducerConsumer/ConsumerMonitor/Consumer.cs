using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common;

namespace ConsumerMonitor
{
	public class Consumer
	{
		private int _consumerSleepNum { get; set; }
		private Http _httpConnection { get; set; }
		private List<string> _wordFound { get; }

		public string Sentence
		{
			get
			{
				StringWriter writer = new StringWriter(new StringBuilder());
				foreach (var word in _wordFound)
				{
					writer.Write(word + " ");
				}
				writer.Write(".");
				return writer.ToString();
			}
		}

		//Key: Hash, key: word
		private Dictionary<string, string> _englishList { get; set; }

		public Consumer(int consumerSleepNum, Http connection)
		{
			this._consumerSleepNum = consumerSleepNum;
			_httpConnection = connection;
			_englishList = new Dictionary<string, string>();
			_wordFound = new List<string>();
		}

		private void GetEnglish(string url)
		{
			var file = File.OpenText(url).ReadToEnd().ToLower();
			var words = file.Split('\r', '\n');
			var hash = words.ToHashSet().ToList();

			for(int i = 0; i < words.Length; i++)
			{
				_englishList.Add(hash[i], words[i]);
			}
		}

		public void Consume()
		{
			GetEnglish("~/words.txt");

			while (true)
			{
				string data = _httpConnection.Get().ToLower();
				if (data == null || data == "")
				{
					Thread.Sleep(_consumerSleepNum * 2);
					continue;
				}
				var wordsHashed = data.Split(' ').ToHashSet().ToList();

				Parallel.For(0, wordsHashed.Count, i => {
					_wordFound.Add(_englishList[wordsHashed[i]]);
				});

				Thread.Sleep(_consumerSleepNum);
			}
		}
	}
}
