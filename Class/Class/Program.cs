using System;

namespace ConsoleApplication2
{
    interface Dog
    {
        string name { get; set; }
        void jitda();
        /*{
            Console.WriteLine(name + "가 짖다.");
        }*/
    }

    class Pudle : Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~~~.");
        }
        public void Work()
        {
            Console.WriteLine(name + " 일한다.");
        }
    }

    class Jindo : Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~~~");
        }
        public void run()
        {
            Console.WriteLine(name + " 달린다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            ((Pudle)p).Work();

            Dog j = new Jindo();
            j.name = "진돌이";
            j.jitda();
            ((Jindo)j).run();

            /*Pudle p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            p.work();

            Jindo j = new Jindo();
            j.name = "진돌이";
            j.jitda();
            j.run();*/
        }
    }
}