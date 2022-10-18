using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCircle
{
    class Cylinder : Circle
    {
        private double height;

        public double Height { get => height; set => height = value; }


        public Cylinder()
        {
            this.height = 1.0;
        }
        public Cylinder(double radius)
        {
            this.Radius=radius;
            this.height=1;
            Console.WriteLine("Cylinder Constructors");
        }
        public Cylinder(double radius,double height)
        {
            this.Radius = radius;
            this.Height = height;
            Console.WriteLine("Cylinder Constructors");
        }

        public Cylinder(double radius, string color,double height):base(radius,color)
        {
            this.Height = height;
        }
        public double getHeight(double height)
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }

        public new double getVolume()
        {
            double kq = base.getArea()* height;
            return kq;
        }
        public new string toString()
        {
            string kq=base.toString()+$",Height={height}]";
            return kq;
        }
        
    }
}
