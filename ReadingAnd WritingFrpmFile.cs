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


1/31/2017
--------------------
SMDU - SMDU is a webservice exposed to CRDE to pass the request  XML for evaluation. SMDU send the result as result XML.
Investor - FNMA (Fannie Mae)

StageEvaluaitons - SP - Loads the loans which are eligible for tonight's batch evaluation. 
GetBatchEvaluationByEvaluationId - SP - JP calls the SP to pick loans one by one to process. (In production multi-threading will pickup ~5 loans at a time)

NPVEvaluation - Input Fields and SMDU version
SMDUEvaluationData - Ouput Fields
SMDURequestResponseLog - For everything

Find out the expansion for SMDU 

JP - Job Processor
