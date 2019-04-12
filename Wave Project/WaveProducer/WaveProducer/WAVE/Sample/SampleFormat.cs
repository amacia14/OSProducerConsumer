using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveProducer.Wave
{
	public enum SampleFormat
	{
		PCM = 0x001,
		IEEE = 0x003,
		ALaw = 0x006,
		ULaw = 0x007,
		Other = 0xFFFE,
		Unkown
	}
}
