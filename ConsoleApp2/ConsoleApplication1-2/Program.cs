using System;

namespace ConsoleApplication1
{
    class EventPublisher
    {
        //public delegate void MyEventHandler();
        public event EventHandler MyEvent;
        public void Do()
        { 
            MyEvent?.Invoke(null, null);
        }
    }

    //구독자 클래스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();

            //p.MyEvent += new EventHandler(doAction);
            p.MyEvent += doAction;
            
            p.Do();
        }

        //MyEvent 라는 이벤트가 발생하면 호출되는 메소드
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}