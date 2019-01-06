using System;
using System.Collections;

public class MyStack
{
    public static void Main()
    {
        // Creates and initializes a new Stack.
        Stack myStack = new Stack();
        myStack.Push("OJC");
        myStack.Push("ASIA");
        myStack.Push("Thank You!");

        Console.WriteLine("myStack의 건수:{0}", myStack.Count);

        Console.WriteLine(myStack.Pop());

        Console.WriteLine(myStack.Peek());

        PrintValues(myStack);
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach(Object obj in myCollection)
        {
            Console.Write("{0} ", obj);
        }
        Console.WriteLine();
    }
}