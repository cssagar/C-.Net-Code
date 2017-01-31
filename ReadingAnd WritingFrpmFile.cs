using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOExample_29_Jan
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //writing to file
            //StreamWriter sw = new StreamWriter(@"C:\Shashikant\IOExample_29_Jan\IOExample_29_Jan\Sample.txt",true);
            //sw.AutoFlush = true;
            //sw.Write("Hello");

            //Reading from File
            StreamReader sr = new StreamReader(@"C:\Shashikant\IOExample_29_Jan\IOExample_29_Jan\Sample.txt");
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            
            //string str = sr.ReadLine();
           // while (str != null)
           // {
           //     Console.WriteLine(str);
           //     str = sr.ReadLine();
           // }
           

            Console.ReadKey();
        }
    }
}
