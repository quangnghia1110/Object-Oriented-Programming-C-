using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCircle
{
    class Circle
    {

        private double radius;
        private string color;

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getArea()
        {
            double kq = 3.14 * Math.Pow(radius, 2);
            return kq;
        }
        public string toString()
        {
            string kq = $"Circle[radius={radius},color={color}";
            return kq;
        }
    }
}
