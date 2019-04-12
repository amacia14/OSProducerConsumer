using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveProducer.Wave;

namespace WaveProducer.wave
{
    public class FmtBlock
    {
        #region variables
        public static uint _FormatID = 0x666d7420;
        private uint _FormatSize;
        private ushort _FormatCode;
        private ushort _NumChannels;
        private uint _SamplesPerSec;
        private uint _AverageBytesPerSec;
        private ushort _BlockAlign;
        private ushort _BitsPerSample;

        public uint FormatSize { get { return _FormatSize; } }

        public SampleFormat FormatCode
        {
	        get
	        {
		        switch (_FormatCode)
		        {
					case 0x0001: return SampleFormat.PCM;
					case 0x0003: return SampleFormat.IEEE;
					case 0x0006: return SampleFormat.ALaw;
					case 0x0007: return SampleFormat.ULaw;
					case 0xFFFE: return SampleFormat.Other;
					default: throw new Exception("File incorrect");
		        }
	        }
        }
        public ushort NumChannels { get { return _NumChannels; } }
        public uint SamplesPerSec { get { return _SamplesPerSec; } }
        public uint AverageBytesPerSec { get { return _AverageBytesPerSec; } }
        public ushort BlockAlign { get { return _BlockAlign; } }
        public ushort BitsPerSample { get { return _BitsPerSample; } }

        #endregion

        /// <summary>
        /// Build empty Format Block
        /// </summary>
        public FmtBlock()
        {
        }

        /// <summary>
        /// Reads Format block from a given file
        /// </summary>
        /// <param name="inFS"></param>
        public FmtBlock(FileStream inFS)
        {
            ReadFmt(inFS);
        }

        public FmtBlock(byte[] data)
        {
            ReadFmt(data);
        }

        public void ReadFmt(FileStream inFS)
        {
            object locker = new object();
            byte[] buffer = new byte[24];

            lock (locker)
            {
                inFS.Seek(12, System.IO.SeekOrigin.Begin);
                inFS.Read(buffer, 0, 23);
            }
            ReadFmt(buffer);
        }

        public void ReadFmt(byte[] inFS)
        {

            var id = BitConverter.ToInt32(inFS, 12);
            id = Tricks.SwapEndianness(id);

            Debug.Assert(id == _FormatID, "Format ID Not Valid");

            _FormatSize = BitConverter.ToUInt32(inFS, 16);
            _FormatCode = BitConverter.ToUInt16(inFS, 20);
            _NumChannels = BitConverter.ToUInt16(inFS, 22);
            _SamplesPerSec = BitConverter.ToUInt32(inFS, 24);
            _AverageBytesPerSec = BitConverter.ToUInt32(inFS, 28);
            _BlockAlign = BitConverter.ToUInt16(inFS, 32);
            _BitsPerSample = BitConverter.ToUInt16(inFS, 34);

			//TODO: Determine format code and react to it
			var size = BitConverter.ToUInt16(inFS, 36);
			if (size == 0)
				return;


        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Format Size: " + FormatSize);
            builder.AppendLine("Format Tag: " + FormatCode);
            builder.AppendLine("Number of Channels: " + _NumChannels);
            builder.AppendLine("Samples per Samples: " + SamplesPerSec);
            builder.AppendLine("Average Bytes Per Seconds: " + AverageBytesPerSec);
            builder.AppendLine("Block Align: " + BlockAlign);
            builder.AppendLine("Bits Per Sample: " + BitsPerSample);

            return builder.ToString();
        }

        public string ToByteString()
        {
			StringBuilder builder = new StringBuilder();

			var size = BitConverter.GetBytes(_FormatSize);
			var numOfChannels = BitConverter.GetBytes(_NumChannels);
			var samplesASec = BitConverter.GetBytes(_SamplesPerSec);
			var averageBytes = BitConverter.GetBytes(_AverageBytesPerSec);
			var blocks = BitConverter.GetBytes(_BlockAlign);
			var bits = BitConverter.GetBytes(_BitsPerSample);
			
			builder.AppendLine("Format Size: " + Tricks.ToByteString(size));
			builder.AppendLine("Format Tag: " + FormatCode);
			builder.AppendLine("Number of Channels: " + Tricks.ToByteString(numOfChannels));
			builder.AppendLine("Samples per Samples: " + Tricks.ToByteString(samplesASec));
			builder.AppendLine("Average Bytes Per Seconds: " + Tricks.ToByteString(averageBytes));
			builder.AppendLine("Block Align: " + Tricks.ToByteString(blocks));
			builder.AppendLine("Bits Per Sample: " + Tricks.ToByteString(bits));

			return builder.ToString();
        }
    }
}
