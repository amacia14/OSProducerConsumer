using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using WaveProducer.Wave;

namespace WaveProducer.Wave
{
	//Gves the value of a Sine Wave of a sample.
	public class Sample
	{
		private BitArray _value { get; set; }

		private SampleFormat _format { get; set; }

		public bool this[int pos] => _value[pos];

		public byte[] Value
		{
			get
			{
				int results = 0;
				for (int i = 0; i < _value.Length; i++)
				{
					if (_value[i])
						results += (2 * (i + 1));
				}
				return BitConverter.GetBytes(results);
			}
		}

		/// <summary>
		/// Create sample based on raw value.  Assumes PCM Format
		/// </summary>
		/// <param name="rawValue">The byte form of a sample</param>
		/// <returns>Sample</returns>
		public static Sample CreateSample(byte[] rawValue)
		{
			//ASSUME LITTLE ENDIAN
			BitArray arr = new BitArray(rawValue);
			Sample thing = new Sample()
			{
				_value = arr,
				_format = SampleFormat.PCM
			};
			return thing;
		}

		/// <summary>
		/// Create sample based on raw value and format
		/// </summary>
		/// <param name="rawValue">Byte form of a sample</param>
		/// <param name="format">The structre of the bytes</param>
		/// <returns>Sample</returns>
		public static Sample CreateSample(byte[] rawValue, SampleFormat format)
		{
			BitArray arr = new BitArray(rawValue);
			Sample result = new Sample()
			{
				_value = arr,
				_format = format
			};
			return result;
		}

		public object GetValue()
		{
			byte[] bytes = Value;
			switch (_format)
			{
				case SampleFormat.PCM:	return GetIntValue();
				case SampleFormat.ALaw: return bytes[0];
				case SampleFormat.ULaw: return bytes[0];
				case SampleFormat.IEEE:	return (_value.Length == 32) ? GetIEEEFormat() : GetDoubleFormat();
				case SampleFormat.Other:
				{
					//WHAT TO DO???
					break;
				} 
			}

			return null;
		}
		private dynamic GetIntValue()
		{
			byte[] bytes = Value;
			switch (_value.Length)
			{
				case int n when n <= 8:
					return _value[0];
				case int n when n < 17:
					return BitConverter.ToInt16(bytes, 0);
				case int n when n < 32:
					return BitConverter.ToInt32(IncreaseByteArray(bytes, 4), 0);
				case 32:
					return BitConverter.ToInt32(bytes, 0);
				case int n when n < 64:
					return BitConverter.ToInt64(IncreaseByteArray(bytes, 8), 0);
				case 64:
					return BitConverter.ToInt64(bytes, 0);
				default:
					throw new Exception("Not standard length: Need help");
			}
		}

		private byte[] IncreaseByteArray(byte[] arr, int length)
		{
			var newValue = new byte[length];
			for (int i = 0; i < newValue.Length; i++)
				newValue[i] = arr[i];
			return newValue;
		}

		private float GetIEEEFormat()
		{
			if (_value.Length == 32)
				return BitConverter.ToSingle(Value, 0);
			else
				throw new Exception("Sample is not float.");
		}

		private double GetDoubleFormat()
		{
			if (_value.Length == 64)
				return BitConverter.ToDouble(Value, 0);
			else
				throw new Exception("Sample is not double");
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(GetIntValue().ToString());

			return builder.ToString();
		}

		public string ToBitString()
		{
			StringBuilder builder = new StringBuilder();

			foreach (bool bit in _value)
				builder.AppendLine(bit ? "1" : "0");
			
			return builder.ToString();
		}

	}
}