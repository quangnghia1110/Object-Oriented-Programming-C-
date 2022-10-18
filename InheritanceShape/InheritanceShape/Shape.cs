using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Shape
    {
        private string color;
        private bool filled;

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public Shape()
        {
            this.color = "red";
            this.filled = true;
        }
        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public string getColor()
        {
            return Color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public bool isFilled()
        {
            return this.filled;
        }
        public void setFilled(bool filled)
        { 
            this.filled = filled;
        }
        public string toString()
        {
            string kq = $"Color={color},Filled={filled}";
            return kq;
        }
    }
}
