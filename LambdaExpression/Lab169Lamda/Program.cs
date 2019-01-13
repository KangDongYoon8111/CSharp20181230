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
            int total = 0;

            SumDeligate SumDeli = (num) =>
            {
                for (int i = 1; i <= num; i++)
                {
                    total += i;
                }
                return total;
            };

            Console.WriteLine($"1부터 {val}까지의 합은 : {SumDeli(val)}");

        }
    }
}