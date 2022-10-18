
using System;
using System.Text;

namespace InheritancePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Point3D p = new Point3D(5,10,8);
            Console.WriteLine(p.toString());
            Console.ReadKey();
        }
    }
}