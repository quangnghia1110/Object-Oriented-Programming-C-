using System;
namespace test_3_9_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Nhap();
            Console.WriteLine(time.nextSecond().toPrint());
            Console.WriteLine(time.previosSecond().toPrint());
        }
    }
}

