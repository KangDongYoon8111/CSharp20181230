using System;

namespace lab2
{
    class Test
    {
        private EventHandler handler;
        public event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("add operation");
            }

            remove
            {
                Console.WriteLine("remove operation");
            }
        }

        public event EventHandler MyEvent2;

        public void Do()
        {
            MyEvent2?.Invoke(null, null);
        }

        static void Main()
        {
            Test t = new Test();

            t.MyEvent += new EventHandler(t.DoNothing);
            t.MyEvent2 += new EventHandler(t.DoNothing);
            t.MyEvent -= null;
            t.Do();
        }

        void DoNothing(object sender, EventArgs e)
        {
            Console.WriteLine("DoNothing Called...");
        }
    }
}