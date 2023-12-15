using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class ObjOrPro
    {
        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);

        static void SharedResource()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the shared resource!", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the shared resource", Thread.CurrentThread.Name);
            sem.Release();
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(SharedResource);
                threads[i].Name = "thread_" + i;
                threads[i].Start();
            }
            Console.Read();
        }
    }
}
