using InheritanceCircle;
using System;
using System.Text;

namespace InheritanceTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cylinder c = new Cylinder(45,"blue",18);
            Console.WriteLine("Diện tích hình tròn: " + c.getArea());
            Console.WriteLine(c.toString());
            Console.WriteLine("Thể tích hình tròn: " + c.getVolume());
            Console.ReadKey();
        }
    }
}