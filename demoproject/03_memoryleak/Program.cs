using System;
using System.Runtime.InteropServices;

namespace _03_memoryleak
{
    public class MemoryManagement
    {
        private IntPtr _buffer;

        public MemoryManagement()
        {
            _buffer = Marshal.AllocHGlobal(1000);
        }
        public void AddMemory(int value)
        {
            _buffer = new IntPtr(value);
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            var memory = new MemoryManagement();
            memory.AddMemory(100);

        }
    }
}
