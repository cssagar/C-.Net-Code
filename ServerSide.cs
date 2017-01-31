using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener t1 = new TcpListener(IPAddress.Loopback,9081);
            t1.Start();
            TcpClient tc = t1.AcceptTcpClient();
            NetworkStream ns = tc.GetStream();
            StreamReader sr = new StreamReader(ns);
            string str = sr.ReadLine();
            while (str != "End")
            {
                Console.WriteLine("Server Recorded : " + str);
                str = sr.ReadLine();
            }

            ////Reading From File
            //StreamReader sr = new StreamReader(@"C:\Shashikant\IOExample_29_Jan\IOExample_29_Jan\Sample.txt");
            //string str = sr.ReadToEnd();
            //Console.WriteLine(str);


            Console.ReadKey();
        }
    }
}
