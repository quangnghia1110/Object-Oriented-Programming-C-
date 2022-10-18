using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace myCircle1
{
    internal class myCircle
    {
        private int radius;
        private myPoint center;
        public myCircle(int radius,myPoint center)
        {
            this.radius = radius;
            this.center = center;
        }
        ~myCircle()
        {

        }
        public int Radius { get => radius; set => radius = value; }
        internal myPoint Center { get => center; set => center = value; }
        public string toString()
        {
            string kq = $"MyCircle[radius={radius}, myPoint={center.print()}]";
            return kq;
        }
        
        public double GetArea()
        {
            double kq = 3.14 * Math.Pow(radius, 2);
            return kq;
        }
        public double Circumference()
        {
            double kq = 3.14 * radius * 2;
            return kq;
        }
        public double Distance(myCircle another)
        {
            double kq = Math.Sqrt(1.0 * (Math.Pow((Center.X - another.Center.X), 2) + Math.Pow((Center.Y - another.Center.Y), 2)));
            return kq;
        }
    }
}
