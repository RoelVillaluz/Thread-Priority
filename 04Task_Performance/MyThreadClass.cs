using System;
using System.Threading;

namespace _04Task_Performance
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(500);  
            }

            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"The thread 0x{threadId} has exited with code 0 (0x0).");
        }

        public static void Thread2()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(1500);  
            }

            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"The thread 0x{threadId} has exited with code 0 (0x0).");
        }
    }
}
