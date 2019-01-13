using System;

delegate int SumDeli(int i, int j);

class DeliTest
{
    static void Main()
    {
        SumDeli s1 = DeliTest.Sum1;
        SumDeli s2 = new SumDeli(DeliTest.Sum2);

        
    }
}