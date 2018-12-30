using System;

class TypeCastExample1
{
    public static void Main()
    {
        short a = 10;
        int b = a;
        int c = 50000;

        short d = (short)c;
        Console.WriteLine("Short : {0}", d);
    }
}
