using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WaveProducer.Wave;

namespace WaveProducer.wave
{
	public class DataBlock
	{
		public static uint DataID = 0x64617461;

		public uint DataSize { get; private set; }

		public Channel this[int pos]
		{
			get { return _data[pos]; }
		}

		public int NumSamples { get; private set; }

		private List<Channel> _data;

		private DataBlock()
		{
		}

		public DataBlock(byte[] data, FmtBlock fmt)
		{
			ReadData(data, fmt);
		}

		public DataBlock(FileStream inFS, FmtBlock fmt)
		{
			ReadData(inFS, fmt);
		}

		public void ReadData(FileStream inFS, FmtBlock fmt)
		{
			object locker = new object();
			byte[] buffer = new byte[inFS.Length];

			lock (locker)
			{
				inFS.Seek(0, System.IO.SeekOrigin.Begin);
				inFS.Read(buffer, 0, (int)(inFS.Length - 1));
			}

			ReadData(buffer, fmt);
			Read(buffer, fmt);
		}

		public void ReadData(byte[] data, FmtBlock fmt)
		{
			int id = BitConverter.ToInt32(data, 36);
			id = Tricks.SwapEndianness(id);

			if(id != 0x64617461)
				Console.WriteLine("Something happened");

			DataSize = BitConverter.ToUInt32(data, 40);

			NumSamples = (int) (DataSize / 2);
		}

		public void Read(byte[] data, FmtBlock fmt)
		{
			_data = new List<Channel>(fmt.NumChannels);

			for (int c = 1; c <= fmt.NumChannels; c++)
			{
				_data.Add(new Channel((byte)c));
			}

			Task[] list = new Task[fmt.NumChannels];
			var number = 0;
			foreach (var item in _data)
			{
				var task = new Task(() =>
				{
					var channelNumber = item.channelNumber - 1;
					var i = (fmt.BitsPerSample / 8) * (channelNumber) + 44;
					var skip = fmt.BlockAlign;

					for (; i < data.Length; i += skip)
					{
						byte[] sample = new byte[fmt.BitsPerSample / 8];

						try
						{
							Array.Copy(data, i, sample, 0, sample.Length);
						}
						catch (Exception e)
						{
							Console.WriteLine(e);
							Console.ReadLine();
							Environment.Exit(-1);
						}

						item.AddSample(Sample.CreateSample(sample));
					}

					Console.WriteLine("Channel " + item.channelNumber + " finished");
				});
				list[number] = task;
				number++;
				task.Start(TaskScheduler.Current);
			}

			//Wait until all channels are done getting samples
			Task.WaitAll(list);
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();

			builder.AppendLine("Data Size: " + DataSize);
			builder.AppendLine("Number of Samples: " + NumSamples);
			builder.AppendLine("Data: ");


			
			
			Task<string>[] tasks = new Task<string>[_data.Count];

			foreach (var item in _data)
			{
				var task = new Task<string>(() =>
				{
					StringBuilder build = new StringBuilder();
					build.AppendLine(item.ToString());
					return build.ToString();
				});
				tasks[item.channelNumber - 1] = task;

				task.Start();
			}

			Console.WriteLine();
			Task.WaitAll(tasks);
			foreach (var item in tasks)
			{
				builder.AppendLine(item.Result);
			}

			return builder.ToString();
		}

		public string ToBitString()
		{
			StringBuilder builder = new StringBuilder();

			var dataSize = BitConverter.GetBytes(DataSize);
			var numSamples = BitConverter.GetBytes(NumSamples);

			var dataSizeString = Tricks.ToByteString(dataSize);
			var numSamplesString = Tricks.ToByteString(numSamples);

			builder.AppendLine("Data Size: " + dataSizeString);
			builder.AppendLine("Number of Samples: " + numSamplesString);
			builder.AppendLine("Data: ");


			Task<string>[] tasks = new Task<string>[_data.Count];

			foreach (var item in _data)
			{
				var task = new Task<string>(() =>
				{
					StringBuilder build = new StringBuilder();
					build.AppendLine(item.ToBitString());
					return build.ToString();
				});
				tasks[item.channelNumber - 1] = task;

				task.Start();
			}

			Task.WaitAll(tasks);

			foreach (var item in tasks)
			{
				builder.AppendLine(item.Result);
			}

			return builder.ToString();

		}
	}
}