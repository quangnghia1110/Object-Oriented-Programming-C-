using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Circle
{
    class MyCircle
    {
        private MyPoint center;
        private int radius;

        public MyPoint Center
        {
            get { return center; }
            set { center = value; }
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public MyCircle() { }

        public MyCircle(int _x = 0, int _y = 0, int _radius = 1)
        {
            center = new MyPoint(_x, _y);
            radius = _radius;
        }

        public MyCircle(MyPoint _center, int _radius)
        {
            center = _center;
            radius = _radius;
        }

        public int GetCenterX() { return center.X; }
        public void SetCenterX(int _x) { center.X = _x; }
        public int GetCenterY() { return center.Y; }
        public void SetCenterY(int _y) { center.Y = _y; }

        public int[] GetCenterXY()
        {
            int[] xy = { center.X, center.Y };
            return xy;
        }

        public void SetCenterXY(int _x, int _y)
        {
            center.X = _x;
            center.Y = _y;
        }

        public string ToString()
        {
            string kq = $"MyCircle[radius={Radius}, center={center.ToString()}]";
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

        public double Distance(MyCircle another)
        {
            double kq = Math.Sqrt(1.0 * (Math.Pow((Center.X - another.Center.X), 2) + Math.Pow((Center.Y - another.Center.Y), 2)));
            return kq;
        }
    }
}