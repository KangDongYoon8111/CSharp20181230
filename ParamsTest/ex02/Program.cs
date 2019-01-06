using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Minus(1, 2));
            Console.WriteLine(Minus(1));
            Console.WriteLine(Minus(i: 8, j: 9));
            Console.WriteLine(Minus(j: 87, i: 9));
            Console.WriteLine(Minus());
        }

        static int Minus(int i=0, int j = 0)
        {
            return i - j;
        }
    }
}