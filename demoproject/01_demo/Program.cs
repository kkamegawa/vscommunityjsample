using System;
using System.Diagnostics;
using System.Linq;

namespace _01_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLog = new EventLog();
            myLog.Log = "Application";
            var collection = myLog.Entries;
            Console.WriteLine(collection[0].Message);
        }
    }
}
