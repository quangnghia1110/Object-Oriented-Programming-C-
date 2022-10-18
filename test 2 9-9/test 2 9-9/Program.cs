using System;
using test_2_9_9;

namespace vd1
{
    class Program
    {
        static void Main(string[]args)
        {
            SinhVien sv = new SinhVien("21110559","Ngô Quang Nghĩa",2003);
            Console.WriteLine(sv.In());
            Console.ReadKey();
        }
    }
}
