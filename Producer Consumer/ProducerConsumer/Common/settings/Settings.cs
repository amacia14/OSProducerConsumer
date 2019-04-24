using System;

namespace Common
{
	[Serializable]
	public class Settings
    {
        public int NumOfClients { get; set; }
        public int NumOfProducers { get; set; }
        public int BufferSize { get; set; }
        public int ConsumersleepNum { get; set; }
        public int ProducerWordCount { get; set; }
        public int ProducerSleepNum { get; set; }

		/// <summary>
		///  Will look at the previous setting and will
		/// return the names of the variables that have been changed 
		/// </summary>
		/// <returns> names of variables that have been modified </returns>
		public Settings(int numConsumer, int numProducer, int bufferSize, int consumerSleep, int producerWord, int producerSleep)
		{
			this.NumOfClients = numConsumer;
			this.NumOfProducers = numProducer;
			this.BufferSize = bufferSize;
			this.ConsumersleepNum = consumerSleep;
			this.ProducerWordCount = producerWord;
			this.ProducerSleepNum = producerSleep;

		}
    }
   
}