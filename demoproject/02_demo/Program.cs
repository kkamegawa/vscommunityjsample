using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System;

namespace _02_demo
{
    [EventSource(Name = EventSourceName)]
    public class MyEventSource : EventSource
    {
        private const string EventSourceName = "SampleNetCore";
        public static MyEventSource Log = new MyEventSource();

        public void Startup() { WriteEvent(1); }
        public void OpenFileStart(string fileName) { WriteEvent(2, fileName); }
        public void OpenFileStop() { WriteEvent(3);  }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyEventSource.Log.Startup();
            MyEventSource.Log.OpenFileStart("SampleLog");
            MyEventSource.Log.Write("Write SampleLog");
            MyEventSource.Log.OpenFileStop();
        }
    }
}
