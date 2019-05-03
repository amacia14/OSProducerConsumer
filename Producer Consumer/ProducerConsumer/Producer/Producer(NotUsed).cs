using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Producer
{
	class Producer
	{
		private ConcurrentBuffer _buffer;

		public Producer(ConcurrentBuffer buffer)
		{
			_buffer = buffer;
		}
		
		public void Produce(int wordCount, int sleepCount)
		{
			while(true)
			{
				string ayy = Guid.NewGuid().ToString();
				using(FileStream fileStream = new FileStream("~/Files/" + ayy + ".txt", FileMode.Create))
				{
					writeFile(fileStream, wordCount);

					var success = _buffer.TryAdd(ayy);
					
					if(success)
						continue;
					else
					{
						Thread.Sleep(sleepCount * 2);
					}

				}
				Thread.Sleep(sleepCount);
			} 
			
		}

		public string randomString(int length)
		{
			char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
			Random r = new Random();
			var charString = "";
			for (int i = 0; i < length; i++)
			{
				if (i % 8 == 0)
				{
					charString += " ";
				}

				charString += alpha[r.Next(0, 25)].ToString();
			}
			Console.WriteLine(charString);
			return charString;
		}
		
		
		/// <summary>
		/// this methods will write set up the writestram to  guid.txt file
		/// </summary>
		/// <param name="Filename"></param>
		static void writeFile(Stream stream, int wordCount)
		{
			StreamWriter writer = new StreamWriter(stream);

			for (int wordNumber = 0; wordCount < wordCount; wordNumber++)
			{ 
				string input = "LOVE YOU TOO";
				int count = 0;

				//Algorithm for random word-
				//
		
						
				writer.Write(input);
			}
			stream.Flush();
		}
	}
}
