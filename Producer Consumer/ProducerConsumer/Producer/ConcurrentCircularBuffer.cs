using System.Collections.Concurrent;

namespace Producer
{
	public class ConcurrentCircularBuffer<T>
	{
		private System.Collections.Concurrent.ConcurrentQueue<string> _buffer;

		private int _last = 0;
		private int _size;
		private object _lockObject = new object();
		private object _index;

		public ConcurrentCircularBuffer(int size)
		{
			this._size = size;
			_buffer = new ConcurrentQueue<string>();
		}

		public void put(string item)
		{
			lock (_lockObject)
			{
				_last++;
				_last = _last > _size ? 1 : _last;
				_buffer.Enqueue(item);
			}
		}

		public string Read()
		{
			lock (_lockObject)
			{
				string thing;
				var success = _buffer.TryDequeue(out thing);
				if (success)
					return thing;
				else
					return "";
			}
		}
	}
}