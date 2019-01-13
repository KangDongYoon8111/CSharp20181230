using System;

namespace lab1
{
    public delegate string FirstDelegate(int x);

    class DelegateTest
    {
        string name;

        static void Main()
        {
            FirstDelegate d1 = new FirstDelegate(StaticMethod);

            DelegateTest instance = new DelegateTest();
            instance.name = "My instance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

            Console.WriteLine(d1(10));
            Console.WriteLine(d2(5));

        }

        static string StaticMethod(int i)
        {
            return string.Format($"Static method: {i}");
        }

        string InstanceMethod(int i)
        {
            return string.Format($"{name} : {i}");
        }
    }
}