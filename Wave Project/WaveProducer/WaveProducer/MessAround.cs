using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace WaveProducer
{
    class MessAround
    {
        public static void makeFile()
        {

            //open file to see structure and create file in text form
            List<byte> files = new List<byte>(File.ReadAllBytes(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\Untitled\untitled.wav"));
            files.RemoveRange(50, files.Count - 51);
            var thing = File.CreateText(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\untitled.txt");
            var thin2 = File.CreateText(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\untitled2.txt");
            
            StringBuilder builder = new StringBuilder();
            foreach (var item in files)
            {
                builder.Append(item + "\n");
            }


            string wow = toHex(files.ToArray());

            thing.Write(wow);
            thin2.Write(builder.ToString());
            thing.Close();
            thin2.Close();
        }

        public static string toHex(byte[] list)
        {
            StringBuilder builder = new StringBuilder(list.Length * 2);
            foreach (var item in list)
            {
                builder.AppendFormat("{0:x2} ", item);
            }

            return builder.ToString();
        }
        
    }
}
