using System;
class TypeCastExample2
{
    public static void Main()
    {
        int a = 50000;
        try
        {
            short b = checked((short)a);
        }
        catch(Exception e)
        {
            Console.WriteLine("예외 : {0}", e.StackTrace);
            Console.WriteLine("--------------------------");
            Console.WriteLine("예외 : {0}", e.Message);
        }
    }
}