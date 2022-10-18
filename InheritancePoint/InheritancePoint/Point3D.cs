using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePoint
{
    class Point3D:Point2D
    {
        private float z;
        public float Z { get => z; set => z = value; }
        public Point3D()
        {
            this.Z = 0.0f;
        }
        public Point3D(float x, float y, float z):base(x,y)
        {
            this.Z = z;
        }
        public void setXYZ(float x, float y, float z)
        {
            base.setXY(x, y);
            this.z = z;
        }

        public float[] getXYZ()
        {
            float[] test = new float[3];
            test[0] = this.X;
            test[1] = this.Y;
            test[2] = this.z;
            return test;
        }
        public new string toString()
        {
            string kq=base.toString()+$",{z}";
            return kq;
        }
    }
}
