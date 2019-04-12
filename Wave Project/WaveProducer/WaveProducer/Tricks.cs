using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WaveProducer
{
    public static class Tricks
    {
        public static int SwapEndianness(int value)
        {
            var b1 = (value >> 0) & 0xff;
            var b2 = (value >> 8) & 0xff;
            var b3 = (value >> 16) & 0xff;
            var b4 = (value >> 24) & 0xff;

            return b1 << 24 | b2 << 16 | b3 << 8 | b4 << 0;
        }


        public static byte[] Serialize(object thing)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, thing);
                return stream.ToArray();
            }
        }

        public static string ToBitString(BitArray arr)
        {
			StringBuilder builder = new StringBuilder();
	        foreach (bool item in arr)
			{
				if (item)
					builder.Append("1");
				else
					builder.Append("0");
				builder.Append(" ");
			}

	        return builder.ToString();
        }

        public static string ToByteString(byte[] bytes)
        {
			StringBuilder builder = new StringBuilder();
			foreach (var item in bytes)
			{
				builder.Append(item + " ");
			}

			return builder.ToString();
        }
    }
}
