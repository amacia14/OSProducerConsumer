using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AudioUtils;
using WMPDXMLib;
using WaveProducer.Wave;

namespace WaveProducer
{
    class Program
    {
	    static void Main(string[] args)
	    {
		    Console.WriteLine("test");

		    List<Task> list = new List<Task>();

		    var largeChannel = Task.Run(() =>
		    {
			    var testB = DateTime.Now;
			    var file = WAVE.ReadWave(
				    @"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\8 Channel\8_Channel_ID.wav");
			    var testA = DateTime.Now;

			    ToFile(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\8 Channel\define.txt", file);

			    var final = testA - testB;
			    Console.WriteLine("Finished high channel: " + final.TotalSeconds + " seconds");
		    });

		    var test = Task.Run(() =>
		    {
			    var b = DateTime.Now;
			    var wasss = Wave.WAVE.ReadWave(
				    @"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\Untitled\untitled.wav");
			    var a = DateTime.Now;

			    ToFile(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\Untitled\analyze.txt", wasss);

			    var t = a - b;
			    Console.WriteLine("Finished test" + t.TotalSeconds + "Seconds");

		    });

		    var wave = Task.Run(() =>
		    {
			    var be = DateTime.Now;
			    var wavess =
				    Wave.WAVE.ReadWave(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\Mono Channel\Mono.wav");
			    var af = DateTime.Now;

			    ToFile(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\Mono Channel\Define.txt", wavess);
			    var ti = af - be;
				Console.WriteLine("Finished wave. " + ti.TotalSeconds + " Seconds");
		    });

		    var waveFile = Task.Run(() =>
		    {
			    var bef = DateTime.Now;
			    var waves = WAVE.ReadWave(
				    @"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\int16 AFsp\M1F1-int16-AFsp.wav");
			    var aft = DateTime.Now;
			    ToFile(@"C:\Users\Jesse.LAPTOP-PC4FVCVE\Desktop\Wave Stuff\int16 AFsp\Define2.txt", waves);

			    var tim = aft - bef;
			    Console.WriteLine("Finished Alaw code. " + tim.TotalSeconds + " Seconds");
		    });

		    list.Add(test);
		    list.Add(wave);
		    list.Add(waveFile);
		    list.Add(wave);

		    Task.WaitAll(list.ToArray());
		    Console.WriteLine("Done");
		    Console.ReadLine();
		    Console.ReadLine();
	    }

	    public static void ToFile(string path, WAVE file)
        {
            var writer = File.CreateText(path);

            writer.Write(file.ToString());

            writer.Close();
        }
        public static void ToFile(string path, WaveFile file)
        {
            var writer = File.CreateText(path);

            writer.Write(file.ToString());

            writer.Close();
        }
    }
}
