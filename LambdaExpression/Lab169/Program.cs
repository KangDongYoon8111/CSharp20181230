using System;

namespace ConsoleApplication23
{
    delegate int SumDeligate(int val);

    class Program
    {
        static void Main(string[] args)
        {
            string readVal = Console.ReadLine();
            int val = Convert.ToInt32(readVal);

            SumDeligate SumDeli = new SumDeligate(Sum);

            Console.WriteLine($"1부터 {val}까지의 합은 : {SumDeli(val)}");

            //-----------------------------------------------------------------
            readVal = Console.ReadLine();
            val = Convert.ToInt32(readVal);

            //델리게이트를 이용한 익명 메소드
            SumDeligate SumDeli2 = delegate (int num)
            {
                int sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                return sum;
            };
            Console.WriteLine($"1부터 {val}까지의 합은 : {SumDeli2(val)}");
        }

        static int Sum(int num)
        {
            int sum = 0;
            for(int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}