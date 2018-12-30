using System;

namespace IsAsTest
{
    class Emp   //최 상위 클래스는 Object 모든 최상위 클래스는 Object
    {
        public override string ToString()
        {
            return "EMP";
        }
    }

    class Programmer : Emp { }

    class Program
    {
        static void Main()
        {
            Programmer p = new Programmer();

            Emp e = p as Emp;   // p를 EMP로 형변환하고 OK면 EMP를 리턴, 형변환 안되면 null
            //Emp e = (Emp)e    p를 EMP로 형변환시 실패면 죽음.
            if(e != null)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
    }
}