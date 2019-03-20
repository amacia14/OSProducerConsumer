using System;
using System.IO;

namespace Helloworld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream();
            BufferedStream buffer = new BufferedStream();

            Console.WriteLine(("Hello world"));
        }
    }
}