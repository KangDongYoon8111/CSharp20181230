using System;
using System.Threading;

public class ThreadTest
{
    public void FirstWork(object name)
    {
        Console.Write(name);

        for(int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000); //밀리세컨드 단위
            Console.Write($"F{i}");
        }
    }

    public void SecondWork(object name)
    {
        Console.Write(name);

        for(int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000);
            Console.Write($"S{i}");
        }
    }

    [MTAThread]
    public static void Main()
    {
        ThreadTest t = new ThreadTest();

        Thread first = new Thread(t.FirstWork);
        Thread second = new Thread(new ParameterizedThreadStart(t.SecondWork));

        first.Priority = ThreadPriority.Lowest;
        second.Priority = ThreadPriority.Highest;

        first.Start("First");
        second.Start("Second");
    }
}