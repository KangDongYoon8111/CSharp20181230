using System;

namespace ConstructorTest
{
    class Emp
    {
        string name;

        /*public Emp()    //기본생성자 생성자, new할 때 호출, 객체를 초기화
        {
            name = "홍길이";
            Console.WriteLine("EMP 객체생성..." + name);
        }*/

        ~Emp()
        {
            Console.WriteLine("EMP 소멸" + name); //소멸자, Finalize
        }

        public Emp(string name = "홍길이") //생성자, 생성자 오버로딩
        {
            this.name = name;
            Console.WriteLine("EMP 객체생성..." + name);
        }
    }

    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Emp e1 = new Emp("광개토");
        }
    }
}
