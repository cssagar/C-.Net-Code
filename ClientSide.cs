using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace ClientSide
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpClient t1 = new TcpClient("127.0.0.1", 9081);
            NetworkStream ns = t1.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            string str = Console.ReadLine();

            while(str != "End")
            {
                sw.WriteLine(str);
                str = Console.ReadLine();
            }
            ////writing to file
            //StreamWriter sw = new StreamWriter(@"C:\Shashikant\IOExample_29_Jan\IOExample_29_Jan\Sample.txt", true);
            //sw.AutoFlush = true;
            //sw.Write("Hello");

            Console.ReadKey();
        }
    }
}
