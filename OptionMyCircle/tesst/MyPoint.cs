using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Circle
{
    class MyPoint
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public MyPoint(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public MyPoint() { }

        public string ToString()
        {
            string kq = $"({x},{y})";
            return kq;
        }

        public double Distance(MyPoint point2)
        {
            double kq = Math.Sqrt(1.0 * (Math.Pow((x - point2.X), 2) + Math.Pow((y - point2.Y), 2)));
            return kq;
        }
    }
}