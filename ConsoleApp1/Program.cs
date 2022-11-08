
using System;
using System.Threading;

namespace multithreads
{
    class Program {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;

            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);
            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUP);

            thread1.Start();
            thread2.Start();
            Console.WriteLine(mainThread.Name+ " is complete.");
        }
        public static void CountDown()
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : "+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete.");
        }
        public static void CountUP()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete.");
        }
    }
}
