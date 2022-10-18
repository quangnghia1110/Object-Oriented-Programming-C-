using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Rectangle:Shape
    {
        private double width;
        private double length;

        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }
        public Rectangle()
        {
            this.width = 1.0;
            this.length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public Rectangle(double width, double length,string color,Boolean filled) : base(color,filled)
        {
            Width = width;
            Length = length;
        }
        public double getArea()
        {
            double kq=width*length;
            return kq;
        }
        public double setPerimeter()
        {
            double kq = (width + length) * 2;
            return kq;
        }
        public string toString()
        {
            string kq = $"Color={Color},Filled={Filled},Width={Width},Length={Length}";
            return kq;
        }
    }
}
