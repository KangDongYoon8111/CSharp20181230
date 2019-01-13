using System;

namespace ConsoleApplication24
{
    delegate bool OjcDeligate(object obj1, object obj2);    //우리가 만든 버블 소트기

    class OjcSorter
    {
        //obj는 정렬 대상, 정렬의 타겟
        //deli는 뒤집을지 말지를 결정하는 메소드를 참고하는 델리게이트
        public static void BubbleSort(object[] obj, OjcDeligate deli)
        {
            object tmp;

            for(int i = 0; i < obj.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    //사용자가 작성한 정렬의 기준이되는 메소드를 호출하여 뒤짚을지를 결정
                    //비교대상 둘중 i는 뒤에 있는것, j는 앞에 있는것
                    if (deli(obj[j], obj[i]))
                    {
                        tmp = obj[i];
                        obj[i] = obj[j];
                        obj[j] = tmp;
                    }
                }
            }
        }
    }

    class Dog
    {
        string name;
        public Dog(string name)
        {
            this.name = name;
        }

        public static bool MySort(object d1, object d2)
        {
            //이름순 오름차순정렬을 위해
            //앞에 있는 d1.nam이 크면 뒤집으라고 true를 리턴
            //return String.Compare(d1.ToSting(),d2.ToString()) > 0 ? true : false;
            return ((((Dog)d1).name, CompareTo(((Dog)d2).name) > 0) ? true : false);
        }

        public override string ToString()
        {
            return "Dog : " + name;
        }
    }

    class Emp
    {
        string name;
        int sal;
        public Emp(string name, int sal)
        {
            this.name = name;
            this.sal = sal;
        }
        public static bool MySort(object e1, object e2)
        {
            //급여순 오름차순정렬을 위해
            //앞에 있는 e1.sal이 크면 뒤집으라고 true를 리턴
            return (((Emp)e1).sal > ((Emp)e2).sal) ? true : false);
        }

        public override string ToString()
        {
            return "Emp : " + name + "," + sal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog[] d = new Dog[4];
            d[0] = new Dog("멍멍이");  d[1] = new Dog("푸들이");
            d[2] = new Dog("진돌이");  d[3] = new Dog("삽살이");

            OjcDeligate deli = new OjcDeligate(Do)
        }
    }
}