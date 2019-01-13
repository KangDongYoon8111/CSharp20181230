using System;

namespace Delegate1
{
    //Delegate 선언은 Action, Func로 대체할수 있다.
    //private delegate int OnjSum(int i, int j);    //1.선언
    //private delegate void OnjSum2(int i, int j);    //1.선언
    public class Delegate1
    {
        public static void Main(string[] args)
        {
            Delegate1 d1 = new Delegate1();

            Func<int, int, int> myMethod = d1.Sum;    //2.생성, 메소드이름을 인자로

            Console.WriteLine("두수 합 : {0}", myMethod(10, 30));  //3.실행

            Action<int,int> d2 = d1.Sum2;
            d2(10, 20);
        }

        int Sum(int i, int j)
        {
            return i + j;
        }

        void Sum2(int i, int j)
        {
            Console.WriteLine($"{i}+{j}={i + j}");
        }
    }
}