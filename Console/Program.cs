using Cofdream.Server;
using System;

namespace Cofdream.DoNetConsole
{
    [System.Serializable]
    public class ProcessInfo
    {
        public string ProcessName;
        public int ProcessId;
        public string CommandLine;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var server = new TCPServer();
            server.Init();
            Console.WriteLine("Server Init Done.");
        }
    }
}