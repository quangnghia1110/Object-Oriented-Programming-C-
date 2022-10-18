using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePoint
{
    class Point2D
    {
        private float x;
        private float y;
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
            
        }
        public Point2D()
        {
            this.X = 0.0f;
            this.Y = 0.0f;
        }
        
        public void setXY(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public float[] getXY()
        {
            float[] test = new float[2];
            test[0] = this.X;
            test[1] = this.Y;
            return test;
        }

        public string toString()
        {
            string kq = $"{x},{y}";
            return kq;
        }

    }
}
