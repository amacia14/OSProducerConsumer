namespace Common.settings
{
    public class Settings
    {
        private int numOfClients;
        private int numOfProducers;
        private int bufferSize;
        private int consumersleepNum;
        private int producerSleepNum;

        /// <summary>
        ///  Will look at the previous setting and will
        /// return the names of the variables that have been changed 
        /// </summary>
        /// <returns> names of variables that have been modified </returns>
        public void stateChange()
        {
            
            
            
            
        }
        
        /// <summary>
        /// will make the changes necessary
        /// or if no changes have been made
        /// the method will send settings to the producer.
        /// </summary>
        public static void changeSettings(){

          if (numOfClients != x) // Some previous client state)
          {
                
          }
         
         if (numOfProducers != x)//some previous producer state
         {
                //change state of producer
         }
         
         if (bufferSize != x)// x is some previous buffer size
         {
             //change size of producer 
         }

         if (consumersleepNum != x) // x is some previous sleep num
         {
             // change sleep num 
         }

         if (producerSleepNum != x) // x is some previous producer sleep num
         {
             
         }

        }
     
    }
   
}