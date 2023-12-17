
class ObjOrPro
{
    // A list of max 10 threads
    static Thread[] threads = new Thread[10];

    // A semaphore with an initial count of 3 and max count of 3
    static Semaphore sem = new Semaphore(3, 3);

    static void SharedResource()
    {
        // Thread requests semaphore
        Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
        sem.WaitOne();

        // Thread enters resource and is suspended for 300 ms
        Console.WriteLine("{0} enters the shared resource!", Thread.CurrentThread.Name);
        Thread.Sleep(300);

        // Thread leaves resource and releases one lock
        Console.WriteLine("{0} is leaving the shared resource", Thread.CurrentThread.Name);
        sem.Release();
    }

    static void Main(string[] args)
    {
        // Creates and starts 10 threads
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(SharedResource);
            threads[i].Name = "thread_" + i;
            threads[i].Start();
        }
        Console.Read();
    }
}
