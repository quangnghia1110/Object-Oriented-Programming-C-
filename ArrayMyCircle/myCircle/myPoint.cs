﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCircle1
{
    class myPoint
    {
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public myPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        ~myPoint()
        {

        }
        public string print()
        {
            string kq = $"({x},{y})";
            return kq;
        }

        


    }
}
