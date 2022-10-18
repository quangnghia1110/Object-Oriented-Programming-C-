using System;
public static class MyMath
{
    public static float PI = 3.14f;
    public static int squared(int n) { return n * n; }
}
class Program
{
   static void Main(string[] args)
    {
        int squared = MyMath.squared(10);
        float pi = MyMath.PI;
        Console.WriteLine("squared: " + squared);
        Console.WriteLine("PI: " + pi);
        Console.ReadKey();
    }
}
