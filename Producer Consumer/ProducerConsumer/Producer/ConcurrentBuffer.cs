using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Producer
{
	public class ConcurrentBuffer
	{
		private System.Collections.Concurrent.IProducerConsumerCollection<string> _buffer;

		private Semaphore _available;
		private Semaphore _items;
		public int Size;
		private object _object;

		public bool switching;

		public ConcurrentBuffer(int size)
		{
			_buffer = new ConcurrentQueue<string>();
			Size = size;
			_available = new Semaphore(size, size);
			_items = new Semaphore(0, size);
			switching = false;
			_object = new object();
		}

		public string[] ToArray()
		{
			return _buffer.ToArray();
		}

		/// <summary>
		/// Tries to add an item
		/// </summary>
		/// <param name="item">The item to add</param>
		/// <returns>true if we did add an item. False, otherwise.</returns>
		public bool TryAdd(string item)
		{
			if (switching == true)
				return false;

			var available = _available.WaitOne(3000);
			if (!available)
			{
				return false;
			}
			else
			{
				var success = _buffer.TryAdd(item);
				if (success == true)
				{
					_items.Release(1);
					return true;
				}
				else
				{
					_available.Release(1);
					//did not add an item.  Uncomment this.
					//_items.Release(0);
					return false;
				}
			}
		}

		/// <summary>
		/// Tries to take an item
		/// </summary>
		/// <param name="item">the item to put in</param>
		/// <returns>True if we took an item.  False, otherwise.</returns>
		public bool TryTake(out string item)
		{
			item = null;
			if (switching == true)
				return false;

			var hasItem = _items.WaitOne(3000);
			if (hasItem)
			{
				var success = _buffer.TryTake(out item);
				if (success == true)
				{
					_available.Release(1);
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				item = null;
				return false;
			}
		}
	}
}