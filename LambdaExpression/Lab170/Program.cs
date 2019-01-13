using System;
using System.Linq;

namespace ConsoleApplication6
{
    class Program
    {
        static bool MyWhere(int n) { return n % 2 == 1; }

        static void Main(string[] args)
        {
            int[] scores = { 30, 54, 64, 54, 99, 11 };

            int oddScoreSum = scores.Where(n => n % 2 == 1).Sum();
            Console.WriteLine($"{oddScoreSum} 홀수의 합");

            int oddCount = scores.Where(n => n % 2 == 1).Count();
            Console.WriteLine($"{oddCount} 홀수의 개수");

            int Count = scores.Where(n => n > 50).Count();
            Console.WriteLine($"{Count} 50보다 큰 수의 개수");

            int Max = scores.Max();
            Console.WriteLine($"{Max} 배열의 최대값");

            int Min = scores.Min();
            Console.WriteLine($"{Min} 배열의 최소값");
        }
    }
}