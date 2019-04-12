using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveProducer.Wave;

namespace WaveProducer.Wave
{
    public class Channel
    {
        public List<Sample> data;

        public byte channelNumber;

        public Channel(byte channelNumber)
        {
            data = new List<Sample>();
            this.channelNumber = channelNumber;
        }

        public void AddSample(Sample data)
        {
            this.data.Add(data);
        }

        public override string ToString()
        {
	        StringBuilder builder = new StringBuilder();

	        builder.AppendLine("Channel Number: " + channelNumber);
	        foreach (var item in data)
	        {
		        builder.AppendLine(item.ToString());
	        }

	        builder.AppendLine("Channel data: " + channelNumber + "end");
	        builder.AppendLine("______________________________________");

	        return builder.ToString();
        }

        public string ToBitString()
        {
			StringBuilder builder = new StringBuilder();

			builder.AppendLine("Channel Number: " + channelNumber);
			foreach (var item in data)
			{
				builder.AppendLine(item.ToBitString());
			}

			builder.AppendLine("Channel data " + channelNumber + " end");
			builder.AppendLine("__________________________________________");

			return builder.ToString();
        }
    }
}
