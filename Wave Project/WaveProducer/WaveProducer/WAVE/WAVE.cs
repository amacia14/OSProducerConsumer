using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using WMPLib;
using WaveProducer;
using WaveProducer.wave;

namespace WaveProducer.Wave
{
    public class WAVE
    {
        //Want to create file 
        //      Different class
        //When recording, if stream is too large, place things in file.

        public RiffBlock RIFF;
        public FmtBlock FormatBlock;
        public DataBlock data;

        
        public static WAVE ReadWave(string path)
        {
	        byte[] data = File.ReadAllBytes(path);

            WAVE results = new WAVE();
            
            results.RIFF = new RiffBlock(data);

            results.FormatBlock = new FmtBlock(data);

            results.data = new DataBlock(File.OpenRead(path), results.FormatBlock);
            
            return results;
        }
        
        //ChunkSize: Variable
        //Format: 1 auto
        //FormatChunkSize: 16
        //Channels: Presdefined, 1 or 2
        //Sample Rate: Predefined
        //Byte Rate: Predefined, samplerate * numChannels * Bits per sample / 8
        //Block Align: Predefined NumChannels * bitsPerSample / 8
        //Bits per sample: Predefined, 8, 16, 24, 36
        //Data Chunk Size: Predefined???
        //Data: Variable
        public static WAVE CreateWave(short numChannels, int sampleRate, short bitsPerSample)
        {
        //    var FormatChunkSize = (int)GetBytes(0, 4, files);
        //    var AudioFormat = (short)GetBytes(4, 2, files);
        //    var NumChannels = (short)GetBytes(6, 2, files);
        //      when have multiple channels, use for loop (total samples) inside a loop (per channel)
        //      So, Channels read channel 0, then channel 1, then channel 2, then channel 0.  Each sample is dedicated to each channel.
        //    var ByteRate = (int)GetBytes(8, 4, files);
        //    var SampleRate = (int)GetBytes(12, 4, files);
        //    var BlockAlign = (short)GetBytes(16, 2, files);
        //    var BitsPerSample = (short)GetBytes(18, 2, files);
            return new WAVE();
    }

        public static object GetBytes(int index, int count, List<byte> list)
        {
            var bytes = list.GetRange(index, count).ToArray();

            switch (count)
            {
                case 2:
                    return BitConverter.ToInt16(bytes, 0);
                case 4:
                    return BitConverter.ToInt32(bytes, 0);
                case 6:
                    return BitConverter.ToInt64(bytes, 0);
                default:
                    throw new Exception("Something went wrong on conversion");
            }
        }

        //Export file into readable format where it seperates all values and data values means something to me.
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(RIFF.ToString());
            builder.AppendLine(FormatBlock.ToString());
            builder.AppendLine(data.ToString());

            return builder.ToString();
        }

        public string ToByteString()
        {
	        StringBuilder builder = new StringBuilder();

	        builder.AppendLine(RIFF.ToByteString());
	        builder.AppendLine(FormatBlock.ToByteString());
			builder.AppendLine(data.ToBitString());

			return builder.ToString();
        }
    }
}
