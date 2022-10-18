using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Circle c = new Circle(0.8, "blue", true);
            Rectangle r = new Rectangle(10, 5, "red", false);
            Square s = new Square(9, "yellow", true);
            Console.WriteLine(c.toString());
            Console.WriteLine(r.toString());
            Console.WriteLine(s.toString());
            Console.WriteLine("Diện tích hình tròn: " + c.getArea());
            Console.WriteLine("Chu vi hình tròn: " + c.getPerimeter());
            Console.WriteLine("Diện tích hình vuông: " + r.getArea());
            Console.WriteLine("Chu vi hình vuông: " + r.setPerimeter());

        }
    }
}