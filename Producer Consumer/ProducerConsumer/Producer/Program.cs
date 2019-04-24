using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
		
		public void producer(int wordCount, int sleepCount)
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
				//Algorithm for random word

				writer.Write(input);
			}
			
			stream.Flush();
		}
	}
}
