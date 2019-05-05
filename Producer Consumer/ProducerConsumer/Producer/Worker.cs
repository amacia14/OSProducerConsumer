
using Common;
using Producer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.HtmlControls;

namespace Producer
{
	public class Worker : IWorker
	{
		private Settings _settings;
		private ThreadManager<ProducerWorker> _threadManager;
		private ConcurrentBuffer _buffer { get; set; }

		public ConcurrentBuffer Buffer
		{
			get { return _buffer; }
			set
			{
				lock (locker)
				{
					_buffer = value;
				}
			}
		}

		private object locker = new object();

		public static Worker _worker = new Worker();

		private Worker()
		{
			_threadManager = new ThreadManager<ProducerWorker>();
		}

		public string Get()
			{
			if (_worker._buffer == null)
				return null;

			string url = "";
			bool isSuccess = _worker._buffer.TryTake(out url);
			if (!isSuccess)
				return null;
			//else

			var fileStream = File.Open(url, FileMode.Open);
			var item = (new StreamReader(fileStream)).ReadToEnd();
			fileStream.Close(); fileStream.Dispose();
			File.Delete(url);
			return item;
		}

		public HttpStatusCode Post(Settings newSettings)
		{
			if (_worker._settings == null)
				_worker._settings = new Settings();

			if (newSettings == null)
				return HttpStatusCode.BadRequest;

			if (_worker._settings.Equals(newSettings))
				return HttpStatusCode.OK;
			//else

			lock (_worker.locker)
			{

				if (_worker._buffer == null)
					_worker._buffer = new ConcurrentBuffer(newSettings.BufferSize);

				if (_worker._buffer.Size != newSettings.BufferSize)
				{
					var buffer = new ConcurrentBuffer(newSettings.BufferSize);

					//Grab all items in old buffer and place in new buffer.
					_worker._buffer.switching = true;
					string[] items = _worker._buffer.ToArray();
					foreach (var item in items)
					{
						buffer.TryAdd(item);
					}

					_worker._buffer = buffer;
					Parallel.ForEach(_worker._threadManager.GetRunningThreads(), (tuple) => { tuple.Item2._buffer = _worker._buffer; });
				}

				if (_worker._settings.ProducerWordCount != newSettings.ProducerWordCount)
					Parallel.ForEach(_worker._threadManager.GetRunningThreads(), (tuple) => { tuple.Item2.wordCount = newSettings.ProducerWordCount; });

				if (_worker._settings.ProducerSleepNum != newSettings.ProducerSleepNum)
					Parallel.ForEach(_worker._threadManager.GetRunningThreads(), (tuple) => { tuple.Item2.sleepCount = newSettings.ProducerSleepNum; });

				while (newSettings.NumOfProducers > _worker._threadManager.CurrentCount)
				{
					ProducerWorker producer = new ProducerWorker(_worker._buffer, newSettings.ProducerWordCount,
						newSettings.ProducerSleepNum);
					Thread thread = new Thread(producer.Produce)
					{
						Name = "Producer " + Guid.NewGuid().ToString(),
						IsBackground = false
					};
					thread.SetApartmentState(ApartmentState.MTA);

					_worker._threadManager.AddThread(thread, producer);
					thread.Start();
				}

				while (newSettings.NumOfProducers < _worker._threadManager.CurrentCount)
				{
					var tuple = _worker._threadManager.GetRunningThreads()[0];
					_worker._threadManager.KillThread();
				}

				_worker._settings = newSettings;
			}

			return HttpStatusCode.OK;
		}

		public void Reset()
		{
			_worker._buffer.switching = true;

			for (int i = 0; i < _threadManager.CurrentCount; i++)
			{
				_threadManager.KillThread();
			}

			_threadManager.ClearOld();

			_worker._settings = null;


			_worker._buffer = null;

			var path = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

			var files = Directory.EnumerateFiles(Path.Combine(path, "ConsumerProducerFiles"));

			foreach (var file in files)
			{
				try
				{
					File.Delete(file);
				}
				catch
				{
				}
			}

		}

		public bool Test()
		{
			return true;
		}

		public string[] BufferItems()
		{
			return _worker._buffer.ToArray();
		}

		public Settings CurrentSettings()
		{
			return _worker._settings;
		}
		
	}
}