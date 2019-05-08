using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
	public class ThreadManager<T>
	{
		/// <summary>
		/// Threads that are currently running
		/// </summary>
		public List<Tuple<Thread, T>> _threads { get; set; }

		/// <summary>
		/// Threads that are currently dead.
		/// </summary>
		public List<Tuple<Thread, T>> _oldThreads { get; set; }

		public ThreadManager()
		{
			_threads = new List<Tuple<Thread, T>>();
			_oldThreads = new List<Tuple<Thread, T>>();
		}

		public int CurrentCount
		{
			get { return _threads.Count; }
		}

		public int OldCount
		{
			get { return _oldThreads.Count; }
		}

		public void AddThread(Thread thread, T data)
		{
			var tuple = new Tuple<Thread,T>(thread,data);
			_threads.Add(tuple);
		}

		public void KillThread()
		{
			var thread = _threads.First();
			_threads.Remove(thread);

			thread.Item1.Abort();
			_oldThreads.Add(thread);
		}

		public void ClearOld()
		{
			_oldThreads.RemoveRange(0, _oldThreads.Count);
		}

		public List<Tuple<Thread,T>> GetRunningThreads()
		{
			return _threads;
		}

		public List<Tuple<Thread, T>> GetDeadThreads()
		{
			return _oldThreads;
		}
	}
}
