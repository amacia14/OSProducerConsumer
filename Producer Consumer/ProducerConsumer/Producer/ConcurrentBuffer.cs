using System.Collections.Concurrent;

namespace Producer
{
	public class ConcurrentBuffer
	{
		private System.Collections.Concurrent.IProducerConsumerCollection<string> _buffer;

		private int size { get; set; }

		public ConcurrentBuffer(int size)
		{
			_buffer = new ConcurrentQueue<string>();
			this.size = size;
		}

		public bool TryAdd(string item)
		{
			if (size + 1 >= size)
			{
				return false;
			}
			else
			{
				var success = _buffer.TryAdd(item);
				if (success == true)
				{
					size++;
					return true;
				}
				else
					return false;
			}
		}

		public bool TryTake(out string item)
		{
			var success = _buffer.TryTake(out item);
			if (success == true)
			{
				size--;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}