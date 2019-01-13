using System;
using System.Threading;

namespace lab1
{
    class ThreadTest
    {
        static void Thmethod()
        {
            int id = AppDomain.GetCurrentThreadId();
            Console.WriteLine("Thread[{0}] Thmethod Method Running", id);
        }

        static void Main()
        {
            int id = AppDomain.GetCurrentThreadId();
            Console.WriteLine("Main Thread[{0}]", id);

            for(int i = 0; i < 10; i++)
            {
                Thread th = new Thread(new ThreadStart(Thmethod));
                th.Start();
            }
        }
    }
}