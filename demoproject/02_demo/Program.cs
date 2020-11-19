using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace _02_demo
{
    public class MyEventSource : EventSource
    {
        public static MyEventSource Log = new MyEventSource();
        public void Startup() { WriteEvent(1); }
        public void OpenFileStart(string fileName) { WriteEvent(2, fileName); }
        public void OpenFileStop() { WriteEvent(3);  }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string logFileName = new MyEventSource.GetName(typeof(MyEventSource));
            IEnumerable<EventSource> eventSources = MyEventSource.GetSources();
            MyEventSource.Log.Startup();
            MyEventSource.Log.OpenFileStart("SampleLog");
            MyEventSource.Log.OpenFileStop();
        }
    }
}
