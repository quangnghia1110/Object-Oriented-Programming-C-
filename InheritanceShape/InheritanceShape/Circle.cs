using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Circle:Shape
    {
        private double radius;
        public double Radius { get => radius; set => radius = value; }
        public Circle()
        {
            this.radius = 1.0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle(double radius, string color, bool filled):base(color,filled)
        {
            Radius=radius;
        }
        public double getRadius()
        {

            return Radius;
        }
        public void setRadius(double Radius)
        {
            this.Radius = Radius;
        }
        public double getArea()
        {
            double kq = 3.14 * Math.Pow(radius, 2);
            return kq;
        }
        public double getPerimeter()
        {
            double kq = 3.14 * 2 * radius;
            return kq;
        }
        public string toString()
        {
            string kq=base.toString()+$",Radius={radius}";
            return kq;
        }

    }
}
