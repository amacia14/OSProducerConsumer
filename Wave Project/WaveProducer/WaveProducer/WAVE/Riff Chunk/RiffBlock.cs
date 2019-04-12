using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveProducer.wave
{
    public class RiffBlock
    {
        #region variables
        //Should be "RIFF"
        //0x52494646 
        private static uint m_RiffID;

        private uint m_RiffSize;

        //should be "WAVE"
        //0x57415645
        private static uint m_RiffFormat;

        public uint RiffID
        {
            get { return m_RiffID; }
        }

        public uint RiffSize
        {
            get { return (m_RiffSize); }
        }

        public uint RiffFormat
        {
            get { return m_RiffFormat; }
        }

        #endregion

        public RiffBlock()
        {
        }

        #region Read File
        public RiffBlock(FileStream inFS)
        {
            ReadRiff(inFS);
        }

        public RiffBlock(byte[] inFS)
        {
            ReadRiff(inFS);
        }

        public void ReadRiff(FileStream inFS)
        {
            object locker = new object();
            byte[] buffer = new byte[12];

            lock (locker)
            {
                inFS.Seek(0, System.IO.SeekOrigin.Begin);
                inFS.Read(buffer, 0, 11);
            }

            ReadRiff(buffer);
        }

        public void ReadRiff(byte[] inFs)
        {
            int id = BitConverter.ToInt32(inFs, 0);
            id = Tricks.SwapEndianness(id);

            Debug.Assert(id == 0x52494646, "RIFF not valids");

            m_RiffSize = BitConverter.ToUInt32(inFs, 4);
        }
        #endregion

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("RIFF ID: " + RiffID.ToString());
            builder.AppendLine("RIFF Size: " + RiffSize.ToString());
            builder.AppendLine("Riff Format: " + RiffFormat.ToString());

            return builder.ToString();
        }

        public string ToByteString()
        {
			StringBuilder builder = new StringBuilder();
			var id = BitConverter.GetBytes(RiffID);
			var size = BitConverter.GetBytes(RiffSize);
			var format = BitConverter.GetBytes(RiffFormat);

			builder.AppendLine("RIFF ID: " + Tricks.ToByteString(id));
			builder.AppendLine("RIFF Size: " + Tricks.ToByteString(size));
			builder.AppendLine("Riff Format: " + Tricks.ToByteString(format));

			return builder.ToString();
        }
    }
}
