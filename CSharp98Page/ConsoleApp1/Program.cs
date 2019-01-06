using System;

class A
{
    static void Main()
    {
        string a = "Hello";
        string b = "C#";
        string result = $"{a} , {b} 화이팅!";

        Console.WriteLine(a + " , " + b + " 화이팅!");
        Console.WriteLine("{0} , {1} 화이팅!", a, b);
        Console.WriteLine($"{a} , {b} 화이팅!");
        Console.WriteLine(result);
    }
}