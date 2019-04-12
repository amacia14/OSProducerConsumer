using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveProducer.Wave
{
	public class NonPCMFormat
	{
		private ushort _Size;
		private ushort _ValidBits;
		private int _SpeakerPosition;
		private Guid _SubFormat;

		public NonPCMFormat()
		{

		}

		public void ReadData(byte[] data)
		{

		}
	}
}
